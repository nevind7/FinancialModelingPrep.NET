using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.CompanyValuation;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.CompanyValuation;

namespace FinancialModelingPrep.Core.CompanyValuation;

public class CompanyValuationProvider : ICompanyValuationProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public CompanyValuationProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public async Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol)
    {
        const string url = Endpoint.CompanyProfile;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<CompanyProfileResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<CompanyProfileResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public Task<ApiResponse<List<SymbolResponse>>> GetETFListAsync()
    {
        const string url = Endpoint.ETFList;

        return client.GetJsonAsync<List<SymbolResponse>>(url);
    }

    public Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync()
    {
        const string url = Endpoint.StockList;
        
        return client.GetJsonAsync<List<SymbolResponse>>(url);
    }

    public Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync()
    {
        const string url = Endpoint.ActivelyTradingList;
        
        return client.GetJsonAsync<List<SymbolResponse>>(url);
    }

    public Task<ApiResponse<List<string>>> GetSymbolsWithFinancialStatementsAsync()
    {
        const string url = Endpoint.FinancialStatementSymbolList;
        
        return client.GetJsonAsync<List<string>>(url);
    }

    public Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
    {
        const string url = Endpoint.EnterpriseValue;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        // mandatory
        queryString.Add("period", period.ToString().ToLower());
            

        return client.GetJsonAsync<List<EnterpriseValueResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
    {
        const string url = Endpoint.BalanceSheetStatement;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        if (period == Period.Quarter)
        {
            queryString.Add("period", period.ToString().ToLower());
        }

        return client.GetJsonAsync<List<BalanceSheetResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
    {
        const string url = Endpoint.CashFlowStatement;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
            
        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        if (period == Period.Quarter)
        {
            queryString.Add("period", period.ToString().ToLower());
        }

        return client.GetJsonAsync<List<CashFlowResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
    {
        const string url = Endpoint.IncomeStatement;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
            
        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        if (period == Period.Quarter)
        {
            queryString.Add("period", period.ToString().ToLower());
        }

        return client.GetJsonAsync<List<IncomeStatementResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(string symbol, string? from = null, string? to = null, int? page = 0, int? limit = 50)
    {
        const string url = Endpoint.StockNews;
        
        var queryString = new QueryStringBuilder();
        queryString.Add("symbols", symbol);

        if (string.IsNullOrWhiteSpace(from) == false)
        {
            queryString.Add("from", from);
        }
        
        if (string.IsNullOrWhiteSpace(to) == false)
        {
            queryString.Add("to", to);
        }
        
        if (page.HasValue)
        {
            queryString.Add("page", page);
        }
        
        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<StockNewsResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<StockNewsResponse>>> GetLatestStockNewsAsync(string? from = null, string? to = null, int? page = 0, int? limit = 20)
    {
        const string url = Endpoint.LatestStockNews;
        
        var queryString = new QueryStringBuilder();

        if (string.IsNullOrWhiteSpace(from) == false)
        {
            queryString.Add("from", from);
        }
        
        if (string.IsNullOrWhiteSpace(to) == false)
        {
            queryString.Add("to", to);
        }
        
        if (page.HasValue)
        {
            queryString.Add("page", page);
        }
        
        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<StockNewsResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(IEnumerable<string> symbols, string? from = null, string? to = null, int? page = 0, int? limit = 50)
    {
        return GetStockNewsAsync(string.Join(',', symbols), from, to, page, limit);
    }

    public async Task<ApiResponse<CompanyRatingResponse>> GetCompanyRatingAsync(string symbol)
    {
        const string url = Endpoint.CompanyRating;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<CompanyRatingResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<CompanyRatingResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public Task<ApiResponse<List<CompanyRatingResponse>>> GetHistoricalCompanyRatingAsync(string symbol, int? limit = 140)
    {
        const string url = Endpoint.HistoricalCompanyRating;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<CompanyRatingResponse>>(url, queryString: queryString);
    }

    public async Task<ApiResponse<DCFResponse>> GetDiscountedCashFlowAsync(string symbol)
    {
        const string url = Endpoint.DiscountedCashFlow;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<DCFResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<DCFResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public async Task<ApiResponse<RatiosTTMResponse>> GetRatiosTTMAsync(string symbol)
    {
        const string url = Endpoint.RatiosTTM;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<RatiosTTMResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<RatiosTTMResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public async Task<ApiResponse<KeyMetricsTTMResponse>> GetCompanyKeyMetricsTTMAsync(string symbol)
    {
        const string url = Endpoint.KeyMetricsTTM;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<KeyMetricsTTMResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<KeyMetricsTTMResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public Task<ApiResponse<List<KeyMetricsResponse>>> GetCompanyKeyMetricsAsync(string symbol, Period period = Period.Annual, int? limit = 130)
    {
        const string url = Endpoint.KeyMetrics;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        if (period != Period.Annual)
        {
            queryString.Add("period", period.ToString().ToLower());
        }

        return client.GetJsonAsync<List<KeyMetricsResponse>>(url, queryString: queryString);
    }

    public async Task<ApiResponse<QuoteResponse>> GetQuoteAsync(string symbol)
    {
        const string url = Endpoint.Quote;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<QuoteResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<QuoteResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }
    
    public async Task<ApiResponse<QuoteShortResponse>> GetQuoteShortAsync(string symbol)
    {
        const string url = Endpoint.QuoteShort;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<QuoteShortResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<QuoteShortResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(IEnumerable<string> symbols)
    {
        const string url = Endpoint.BulkQuote;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbols", string.Join(',', symbols));

        if (string.IsNullOrEmpty(string.Join(',', symbols)))
        {
            throw new ArgumentException(
                "List of symbols cannot result in an empty string. At least one ticker symbol needs to be added.",
                nameof(symbols));
        }

        return client.GetJsonAsync<List<QuoteResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(Exchange exchange)
    {
        const string url = Endpoint.ExchangeQuote;

        var queryString = new QueryStringBuilder();
        queryString.Add("exchange", exchange.ToString());

        return client.GetJsonAsync<List<QuoteResponse>>(url, queryString: queryString);
    }

    public async Task<ApiResponse<MarketCapResponse>> GetMarketCapitalizationAsync(string symbol)
    {
        const string url = Endpoint.MarketCapitalization;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<MarketCapResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<MarketCapResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }
    
    public async Task<ApiResponse<StockPriceChangeResponse>> GetStockPriceChangeAsync(string symbol)
    {
        const string url = Endpoint.StockPriceChange;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<StockPriceChangeResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<StockPriceChangeResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }


    public Task<ApiResponse<List<MarketCapResponse>>> GetHistoricalMarketCapitalizationAsync(string symbol, string? from = null, string? to = null, int? limit = 100)
    {
        const string url = Endpoint.HistoricalMarketCapitalization;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
        
        if (string.IsNullOrWhiteSpace(from) == false)
        {
            queryString.Add("from", from);
        }
        
        if (string.IsNullOrWhiteSpace(to) == false)
        {
            queryString.Add("to", to);
        }

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<MarketCapResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<TickerSearchResponse>>> SearchAsync(string query, Exchange? exchange, int? limit = null)
        => SearchInternalAsync(query, exchange, limit);
        
    private Task<ApiResponse<List<TickerSearchResponse>>> SearchInternalAsync(string query, Exchange? exchange, int? limit)
    {
        var queryString = new QueryStringBuilder();
        queryString.Add("query", query);
            
        if (exchange.HasValue)
        {
            queryString.Add("exchange", exchange.Value.ToString());
        }

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<TickerSearchResponse>>(Endpoint.TickerSearch, queryString: queryString);
    }

    public Task<ApiResponse<List<PressReleasesResponse>>> GetPressReleasesAsync(string symbol, int? page = null)
    {
        const string url = Endpoint.PressReleases;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (page != null)
        {
            queryString.Add("page", page);
        }

        return client.GetJsonAsync<List<PressReleasesResponse>>(url, queryString: queryString);
    }

    /// <inheritdoc />
    public Task<ApiResponse<List<SymbolChangeResponse>>> GetSymbolChangesAsync()
    {
        const string url = Endpoint.SymbolChange;

        return client.GetJsonAsync<List<SymbolChangeResponse>>(url);
    }

    public async Task<ApiResponse<PriceTargetConsensusResponse>> GetPriceTargetConsensusAsync(string symbol)
    {
        const string url = Endpoint.PriceTargetConsensus;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<PriceTargetConsensusResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<PriceTargetConsensusResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public async Task<ApiResponse<UpgradeDowngradeConsensusResponse>> GetUpgradeDowngradeConsensusAsync(string symbol)
    {
        const string url = Endpoint.UpgradeDowngradeConsensus;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        var result = await client.GetJsonAsync<List<UpgradeDowngradeConsensusResponse>>(url, queryString: queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<UpgradeDowngradeConsensusResponse>(result.Error);
        }

        return ApiResponse.FromSuccess(result.Data.First());
    }

    public Task<ApiResponse<List<InsiderTradingResponse>>> GetInsiderTradingAsync(string symbol, int? limit = 10)
    {
        const string url = Endpoint.InsiderTrading;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<InsiderTradingResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<GradeResponse>>> GetGradesAsync(string symbol)
    {
        const string url = Endpoint.Grades;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
        
        return client.GetJsonAsync<List<GradeResponse>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<InsiderTradingStatisticItem>>> GetInsiderTradingStatisticsAsync(string symbol)
    {
        const string url = Endpoint.InsiderTradingStatistic;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        return client.GetJsonAsync<List<InsiderTradingStatisticItem>>(url, queryString: queryString);
    }

    public Task<ApiResponse<List<EarningsSurpriseItem>>> GetEarningsSurprisesBulkAsync(int year)
    {
        const string url = Endpoint.EarningsSurprisesBulk;

        var queryString = new QueryStringBuilder();
        queryString.Add("year", year);

        return client.GetJsonAsync<List<EarningsSurpriseItem>>(url, queryString: queryString);
    }
}