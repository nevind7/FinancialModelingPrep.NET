using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.AdvancedData;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.AdvancedData;

namespace FinancialModelingPrep.Core.AdvancedData;

public class AdvancedDataProvider : IAdvancedDataProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public AdvancedDataProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public Task<ApiResponse<string>> GetAnnualReportsForm10KJsonAsync(string symbol, int year)
        => GetFinancialReportsJsonAsync(symbol, year, Period.Annual, null);

    public Task<ApiResponse<string>> GetQuarterlyReportsForm10QJsonAsync(string symbol, int year, Quarter quarter)
        => GetFinancialReportsJsonAsync(symbol, year, Period.Quarter, quarter);

    private Task<ApiResponse<string>> GetFinancialReportsJsonAsync(string symbol, int year, Period period, Quarter? quarter)
    {
        const string url = Endpoint.FinancialReportsJson;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
        queryString.Add("year", year);

        if (period == Period.Quarter && quarter != null)
        {
            queryString.Add("period", quarter.Value.ToString());
        }
        else
        {
            queryString.Add("period", "FY");
        }

        return client.GetStringAsync(url, new NameValueCollection(), queryString);
    }

    public Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationByCikAsync(string cik)
        => GetStandardIndustrialClassificationInternalAsync("cik", cik);

    public Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationBySicCodeAsync(string sic)
        => GetStandardIndustrialClassificationInternalAsync("sicCode", sic);

    public Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationBySymbolAsync(string symbol)
        => GetStandardIndustrialClassificationInternalAsync("symbol", symbol);

    private async Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationInternalAsync(string queryParamName, string queryParamValue)
    {
        const string url = Endpoint.StandardIndustrialClassification;

        var queryString = new QueryStringBuilder();
        queryString.Add(queryParamName, queryParamValue);

        var result = await client.GetJsonAsync<List<StandardIndustrialClassificationResponse>>(url, new NameValueCollection(), queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<StandardIndustrialClassificationResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public async Task<ApiResponse<List<CompanyPeersResponse>>> GetStockPeersAsync(string symbol)
    {
        const string url = Endpoint.StockPeers;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<CompanyPeersResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<List<CompanyPeersResponse>>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data);
    }

    public Task<ApiResponse<List<SectorPEResponse>>> GetSectorsPriceEarningsRatioAsync(string date, string exchange)
        => GetGenericPERationAsync<SectorPEResponse>(Endpoint.SectorPESnapshot, date, exchange);

    public Task<ApiResponse<List<IndustryPEResponse>>> GetIndustriesPriceEarningsRatioAsync(string date, string exchange)
        => GetGenericPERationAsync<IndustryPEResponse>(Endpoint.IndustryPESnapshot, date, exchange);

    private Task<ApiResponse<List<T>>> GetGenericPERationAsync<T>(string url, string date, string exchange)
    {
        if (string.IsNullOrEmpty(url))
        {
            throw new ArgumentException($"'{nameof(url)}' cannot be null or empty.", nameof(url));
        }

        if (string.IsNullOrEmpty(date))
        {
            throw new ArgumentException($"'{nameof(date)}' cannot be null or empty.", nameof(date));
        }

        if (string.IsNullOrEmpty(exchange))
        {
            throw new ArgumentException($"'{nameof(exchange)}' cannot be null or empty.", nameof(exchange));
        }

        var queryString = new QueryStringBuilder();
        queryString.Add(nameof(date), date);
        queryString.Add(nameof(exchange), exchange);

        return client.GetJsonAsync<List<T>>(url, new NameValueCollection(), queryString);
    }

    public async Task<ApiResponse<SharesFloatResponse>> GetSharesFloatAsync(string symbol)
    {
        const string url = Endpoint.SharesFloat;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<SharesFloatResponse>>(url, new NameValueCollection(), queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<SharesFloatResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public Task<ApiResponse<List<ESGScoreResponse>>> GetESGScoreAsync(string symbol)
    {
        const string url = Endpoint.ESGRatings;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        return client.GetJsonAsync<List<ESGScoreResponse>>(url, new NameValueCollection(), queryString);
    }

    public async Task<ApiResponse<FinancialScoreResponse>> GetFinancialScoreAsync(string symbol)
    {
        const string url = Endpoint.FinancialScores;
        
        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<FinancialScoreResponse>>(url, new NameValueCollection(), queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<FinancialScoreResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }
}