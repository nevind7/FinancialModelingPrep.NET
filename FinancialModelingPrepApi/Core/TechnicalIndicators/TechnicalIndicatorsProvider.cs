using FinancialModelingPrep.Abstractions.TechnicalIndicators;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.TechnicalIndicators;

namespace FinancialModelingPrep.Core.TechnicalIndicators;

public class TechnicalIndicatorsProvider : ITechnicalIndicatorsProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public TechnicalIndicatorsProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<TechnicalIndicatorItem>>> GetAsync(
        TechnicalIndicator indicator,
        string symbol,
        int periodLength,
        string timeframe,
        string? from = null,
        string? to = null)
    {
        var url = indicator switch
        {
            TechnicalIndicator.Sma               => Endpoint.Sma,
            TechnicalIndicator.Ema               => Endpoint.Ema,
            TechnicalIndicator.Wma               => Endpoint.Wma,
            TechnicalIndicator.Dema              => Endpoint.Dema,
            TechnicalIndicator.Tema              => Endpoint.Tema,
            TechnicalIndicator.Rsi               => Endpoint.Rsi,
            TechnicalIndicator.StandardDeviation => Endpoint.StandardDeviation,
            TechnicalIndicator.Williams          => Endpoint.Williams,
            TechnicalIndicator.Adx               => Endpoint.Adx,
            _ => throw new ArgumentOutOfRangeException(nameof(indicator), indicator, null),
        };

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
        queryString.Add("periodLength", periodLength);
        queryString.Add("timeframe", timeframe);
        if (from != null) queryString.Add("from", from);
        if (to != null) queryString.Add("to", to);

        return client.GetJsonAsync<List<TechnicalIndicatorItem>>(url, queryString: queryString);
    }
}
