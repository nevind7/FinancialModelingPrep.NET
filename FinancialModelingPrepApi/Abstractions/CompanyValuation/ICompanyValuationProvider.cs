using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.CompanyValuation;

namespace FinancialModelingPrep.Abstractions.CompanyValuation;

public interface ICompanyValuationProvider
{
    /// <summary>
    /// Public comapnies sometimes change their symbol and thanks to this endpoint you will be able to know if there is any symbol change happened. 
    /// Data for new symbol is getting transferred from the old symbol the same day
    /// </summary>
    /// <returns></returns>
    Task<ApiResponse<List<SymbolChangeResponse>>> GetSymbolChangesAsync();

    Task<ApiResponse<QuoteResponse>> GetQuoteAsync(string symbol);
    Task<ApiResponse<QuoteShortResponse>> GetQuoteShortAsync(string symbol);
    Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(IEnumerable<string> symbols);
    Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(Exchange exchange);

    Task<ApiResponse<StockPriceChangeResponse>> GetStockPriceChangeAsync(string symbol);

    Task<ApiResponse<List<TickerSearchResponse>>> SearchAsync(string query, Exchange? exchange, int? limit = null);

    Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol);
    Task<ApiResponse<RatiosTTMResponse>> GetRatiosTTMAsync(string symbol);
    Task<ApiResponse<KeyMetricsTTMResponse>> GetCompanyKeyMetricsTTMAsync(string symbol);
    Task<ApiResponse<List<KeyMetricsResponse>>> GetCompanyKeyMetricsAsync(string symbol, Period period = Period.Annual, int? limit = 130);

    Task<ApiResponse<DCFResponse>> GetDiscountedCashFlowAsync(string symbol);

    Task<ApiResponse<MarketCapResponse>> GetMarketCapitalizationAsync(string symbol);
    Task<ApiResponse<List<MarketCapResponse>>> GetHistoricalMarketCapitalizationAsync(string symbol, string? from = null, string? to = null, int? limit = 100);

    Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync();
    Task<ApiResponse<List<string>>> GetSymbolsWithFinancialStatementsAsync();
    Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync();
    Task<ApiResponse<List<SymbolResponse>>> GetETFListAsync();

    Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int? limit = 40);
    
    Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);
    Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);
    Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40);

    Task<ApiResponse<List<StockNewsResponse>>> GetLatestStockNewsAsync(string? from = null, string? to = null, int? page = 0, int? limit = 20);
    Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(string symbol, string? from = null, string? to = null, int? page = 0, int? limit = 50);
    Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(IEnumerable<string> symbols, string? from = null, string? to = null, int? page = 0, int? limit = 50);

    Task<ApiResponse<CompanyRatingResponse>> GetCompanyRatingAsync(string symbol);
    Task<ApiResponse<List<CompanyRatingResponse>>> GetHistoricalCompanyRatingAsync(string symbol, int? limit = 140);

    Task<ApiResponse<List<PressReleasesResponse>>> GetPressReleasesAsync(string symbol, int? page = null);

    Task<ApiResponse<PriceTargetConsensusResponse>> GetPriceTargetConsensusAsync(string symbol);
    Task<ApiResponse<PriceTargetSummaryResponse>> GetPriceTargetSummaryAsync(string symbol);
    Task<ApiResponse<UpgradeDowngradeConsensusResponse>> GetUpgradeDowngradeConsensusAsync(string symbol);
    Task<ApiResponse<List<GradeResponse>>> GetGradesAsync(string symbol);
    public Task<ApiResponse<List<InsiderTradingResponse>>> GetInsiderTradingAsync(string symbol, int? limit = 10);
    Task<ApiResponse<List<InsiderTradingStatisticItem>>> GetInsiderTradingStatisticsAsync(string symbol);
    Task<ApiResponse<List<EarningsSurpriseItem>>> GetEarningsSurprisesBulkAsync(int year);
}