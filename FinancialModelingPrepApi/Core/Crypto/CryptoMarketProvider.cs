using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.Crypto;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Crypto;

namespace FinancialModelingPrep.Core.Crypto;

public sealed class CryptoMarketProvider : ICryptoMarketProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public CryptoMarketProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public Task<ApiResponse<List<CryptoItem>>> GetAvailableCryptocurrencies()
    {
        const string url = Endpoint.AvailableCryptocurrencies;

        return client.GetJsonAsync<List<CryptoItem>>(url);
    }

    public Task<ApiResponse<List<CryptoHistoricalPriceDailyItem>>> GetDailyPrices(string symbol)
    {
        const string url = Endpoint.HistoricalPriceFull;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        return client.GetJsonAsync<List<CryptoHistoricalPriceDailyItem>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period)
    {
        const string url = Endpoint.HistoricalChart;

        string pricePeriod = EnumMappings.HistoricalPrices[period];

        // TODO: Fix this... probably not correct
        var pathParams = new NameValueCollection
        {
            { "pricePeriod", pricePeriod }
        };

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        return client.GetJsonAsync<List<CryptoHistoricalPricePeriodListing>>(url, pathParams, queryString);
    }
}