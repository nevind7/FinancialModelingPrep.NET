using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.StockTimeSeries;
using Xunit;
using Xunit.Abstractions;

namespace Tests.StockTimeSeries;

public class StockTimeSeriesTests : TestingBase
{
    private readonly IStockTimeSeriesProvider api;

    public StockTimeSeriesTests(ITestOutputHelper testOutput) : base(testOutput)
    {
        api = ServiceProvider.GetRequiredService<IStockTimeSeriesProvider>();
    }

    [Fact]
    public async Task GetHistoricalStockSplitsAsync()
    {
        var result = await api.GetHistoricalStockSplitsAsync("AAPL");

        result.AssertNoErrors();

        var split = result.Data.First(data => data.Date == "2020-08-31");

        Assert.Equal(4.0, split.Numerator);
        Assert.Equal(1.0, split.Denominator);
    }

    [Fact]
    public async Task GetHistoricalDailyPricesAsync()
    {
        var result = await api.GetHistoricalDailyPricesAsync("AAPL");

        result.AssertNoErrors();

        var split = result.Data.First(data => data.Date == DateOnly.Parse("2021-06-04"));

        Assert.Equal((decimal)125.89, split.Close.GetValueOrDefault(), 2);
        Assert.Equal((decimal)124.07d, split.Open.GetValueOrDefault(), 2);
        Assert.Equal((decimal)126.16, split.High.GetValueOrDefault(), 2);
        Assert.Equal((decimal)123.85, split.Low.GetValueOrDefault(), 2);
    }

    [Theory]
    [InlineData("AMD")]
    [InlineData("O")]
    [InlineData("BZZUY")]
    [InlineData("PPL.TO")]
    [InlineData("LGEN.L")]
    [InlineData("AGS.BR")]
    public async Task GetHistoricalDailyPricesAsync_2(string ticker)
    {
        var result = await api.GetHistoricalDailyPricesAsync(ticker);

        result.AssertNoErrors();
        Assert.NotEmpty(result.Data);
    }

    [Fact]
    public async Task GetHistoricalDailyPricesUsingFromToAsync()
    {
        var result = await api.GetHistoricalDailyPricesAsync("AAPL", "2021-06-03", "2021-06-05");

        result.AssertNoErrors();

        Assert.Equal(2, result.Data.Count);

        var split = result.Data.First(data => data.Date == DateOnly.Parse("2021-06-04"));

        Assert.Equal((decimal)125.89, split.Close.GetValueOrDefault(), 2);
        Assert.Equal((decimal)124.07, split.Open.GetValueOrDefault(), 2);
        Assert.Equal((decimal)126.16, split.High.GetValueOrDefault(), 2);
        Assert.Equal((decimal)123.85, split.Low.GetValueOrDefault(), 2);
    }

    [Theory]
    [MemberData(nameof(AvailableHistoricalChartSeries))]
    public async Task GetHistoricalPricesForChartWithVolume(HistoricalChartSeries series)
    {
        var fromDate = new DateTime(2025, 2, 2);
        var toDate = new DateTime(2025, 2, 4);

        var result = await api.GetHistoricalPricesForChartWithVolume("AAPL", series, fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"), false);

        result.AssertNoErrors();
            
        Assert.Equal(toDate.Date, DateTime.Parse(result.Data.First().Date).Date);
        Assert.Equal(fromDate.Date.AddDays(1), DateTime.Parse(result.Data.Last().Date).Date);

        Assert.True(result.Data.Count > 0);
    }

    [Theory]
    [MemberData(nameof(AvailableHistoricalChartSeries))]
    public async Task GetHistoricalPricesForChartWithVolume2(HistoricalChartSeries series)
    {
        var fromDate = new DateTime(2025, 2, 2);
        var toDate = new DateTime(2025, 2, 4);

        var result = await api.GetHistoricalPricesForChartWithVolume("AGS.BR", series, fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"), false);

        result.AssertNoErrors();

        Assert.Equal(toDate.Date, DateTime.Parse(result.Data.First().Date).Date);
        Assert.Equal(fromDate.Date.AddDays(1), DateTime.Parse(result.Data.Last().Date).Date);

        Assert.True(result.Data.Count > 0);
    }

    [Theory]
    [MemberData(nameof(AvailableHistoricalChartSeries))]
    public async Task GetHistoricalPricesForChartWithVolumeExtended(HistoricalChartSeries series)
    {
        var fromDate = new DateTime(2025, 2, 2);
        var toDate = new DateTime(2025, 2, 4);

        var result = await api.GetHistoricalPricesForChartWithVolume("AAPL", series, fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"), true);

        result.AssertNoErrors();

        Assert.Equal(toDate.Date, DateTime.Parse(result.Data.First().Date).Date);
        Assert.Equal(fromDate.Date.AddDays(1), DateTime.Parse(result.Data.Last().Date).Date);

        Assert.True(DateTime.Parse(result.Data.First().Date).Hour > 15);
        Assert.True(DateTime.Parse(result.Data.Last().Date).Hour < 9);

        Assert.True(result.Data.Count > 0);
    }

    public static IEnumerable<object[]> AvailableHistoricalChartSeries
    {
        get
        {
            foreach (var enumValue in Enum.GetValues<HistoricalChartSeries>())
            {
                yield return new object[] { enumValue };
            }
        }
    }
}