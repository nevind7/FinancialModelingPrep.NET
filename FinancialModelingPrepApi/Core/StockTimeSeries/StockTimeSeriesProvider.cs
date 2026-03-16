using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.StockTimeSeries;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.StockTimeSeries;

namespace FinancialModelingPrep.Core.StockTimeSeries
{
    public class StockTimeSeriesProvider : IStockTimeSeriesProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public StockTimeSeriesProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceResponse>> GetHistoricalDailyPricesAsync(string symbol)
        {
            const string url = "historical-price-full/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            return client.GetJsonAsync<HistoricalPriceResponse>(url, pathParams, null);
        }
        
        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceResponse>> GetHistoricalDailyPricesAsync(string symbol, string from, string to)
        {
            const string url = "historical-price-full/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();
            queryString.Add("from", from);
            queryString.Add("to", to);

            return client.GetJsonAsync<HistoricalPriceResponse>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceForLineChartResponse>> GetHistoricalDailyPricesForLineChartAsync(string symbol)
        {
            const string url = "historical-price-full/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("serietype", "line");

            return client.GetJsonAsync<HistoricalPriceForLineChartResponse>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalPriceForLineChartResponse>> GetHistoricalDailyPricesForLineChartAsync(string symbol, string from, string to)
        {
            const string url = "historical-price-full/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("serietype", "line");
            queryString.Add("from", from);
            queryString.Add("to", to);

            return client.GetJsonAsync<HistoricalPriceForLineChartResponse>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalDividendsResponse>> GetHistoricalDividendsAsync(string symbol)
        {
            const string url = "historical-price-full/stock_dividend/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            return client.GetJsonAsync<HistoricalDividendsResponse>(url, pathParams, null);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<HistoricalPriceForChartWithVolumeResponse>>> GetHistoricalPricesForChartWithVolume(string symbol, HistoricalChartSeries series, string from, string to, bool extended)
        {
            const string url = "historical-chart/[series]/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "series", HistoricalChartSeriesToString(series) },
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();
            queryString.Add("from", from);
            queryString.Add("to", to);
            queryString.Add("extended", extended ? "true" : "false");

            return client.GetJsonAsync<List<HistoricalPriceForChartWithVolumeResponse>>(url, pathParams, queryString);
        }

        /// <inheritdoc/>
        public Task<ApiResponse<HistoricalStockSplitResponse[]>> GetHistoricalStockSplitsAsync(string symbol)
        {
            const string url = "splits";

            var queryString = new QueryStringBuilder();
            queryString.Add("symbol", symbol);

            var pathParams = new NameValueCollection();
         
            return client.GetJsonAsync<HistoricalStockSplitResponse[]>(url, pathParams, queryString);
        }

        private static string HistoricalChartSeriesToString(HistoricalChartSeries series)
        {
            return series switch
            {
                HistoricalChartSeries.OneMinute => "1min",
                HistoricalChartSeries.FiveMinutes => "5min",
                HistoricalChartSeries.FifteenMinutes => "15min",
                HistoricalChartSeries.ThirtyMinutes => "30min",
                HistoricalChartSeries.Hourly => "1hour",
                HistoricalChartSeries.FourHours => "4hour",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
