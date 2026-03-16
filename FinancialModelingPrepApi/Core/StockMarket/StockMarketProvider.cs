using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.StockMarket;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.StockMarket;

namespace FinancialModelingPrep.Core.StockMarket;

public sealed class StockMarketProvider : IStockMarketProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public StockMarketProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public Task<ApiResponse<List<StockScreenerItem>>> StockScreener(int? marketCapMoreThan = null, int? marketCapLowerThan = null, decimal? priceMoreThan = null, decimal? priceLowerThan = null,
        decimal? betaMoreThan = null, decimal? betaLowerThan = null, int? volumeMoreThan = null, int? volumeLowerThan = null, bool? isEtf = null, bool? isActivelyTraded = null,
        Sector? sector = null, Industry? industry = null, Country? country = null, Exchange? exchange = null, int? limit = 30)
    {
        const string url = Endpoint.CompanyScreener;

        var pathParams = new NameValueCollection();

        var queryString = new QueryStringBuilder();

        if (marketCapMoreThan.HasValue)
        {
            queryString.Add("marketCapMoreThan", marketCapMoreThan.Value.ToString());
        }

        if (marketCapLowerThan.HasValue)
        {
            queryString.Add("marketCapLowerThan", marketCapLowerThan.Value.ToString());
        }

        if (priceMoreThan.HasValue)
        {
            queryString.Add("priceMoreThan", priceMoreThan.Value.ToString());
        }

        if (priceLowerThan.HasValue)
        {
            queryString.Add("priceLowerThan", priceLowerThan.Value.ToString());
        }

        if (betaMoreThan.HasValue)
        {
            queryString.Add("betaMoreThan", betaMoreThan.Value.ToString());
        }

        if (betaLowerThan.HasValue)
        {
            queryString.Add("betaLowerThan", betaLowerThan.Value.ToString());
        }

        if (volumeMoreThan.HasValue)
        {
            queryString.Add("volumeMoreThan", volumeMoreThan.Value.ToString());
        }
        
        if (volumeLowerThan.HasValue)
        {
            queryString.Add("volumeLowerThan", volumeLowerThan.Value.ToString());
        }

        if (isEtf.HasValue)
        {
            queryString.Add("isEtf", isEtf.Value.ToString());
        }

        if (sector.HasValue)
        {
            queryString.Add("sector", EnumMappings.Sectors[sector.Value]);
        }

        if (industry.HasValue)
        {
            queryString.Add("industry", EnumMappings.Industries[industry.Value]);
        }

        if (country.HasValue)
        {
            queryString.Add("country", country.Value.ToString());
        }

        if (exchange.HasValue)
        {
            queryString.Add("exchange", exchange.Value.ToString().ToLower());
        }
                
        queryString.Add("limit", limit.Value.ToString());
            

        return client.GetJsonAsync<List<StockScreenerItem>>(url, pathParams, queryString);
    }

    public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestGainerStocksAsync()
        => GetStockMarketData(Endpoint.BiggestGainers);

    public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestLoserStocksAsync()
        => GetStockMarketData(Endpoint.BiggestLosers);

    public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetMostActiveStocksAsync()
        => GetStockMarketData(Endpoint.MostActive);

    private Task<ApiResponse<List<StockMarketSymbolResponse>>> GetStockMarketData(string endpoint)
    {
        const string url = "[endpoint]";

        var pathParams = new NameValueCollection
        {
            { "endpoint", endpoint },
        };

        return client.GetJsonAsync<List<StockMarketSymbolResponse>>(url, pathParams, null);
    }
}