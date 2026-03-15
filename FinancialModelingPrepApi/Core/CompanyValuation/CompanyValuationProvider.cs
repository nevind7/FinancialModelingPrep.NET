using MatthiWare.FinancialModelingPrep.Abstractions.CompanyValuation;
using MatthiWare.FinancialModelingPrep.Core.Http;
using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.CompanyValuation;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Core.CompanyValuation
{
    public class CompanyValuationProvider : ICompanyValuationProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CompanyValuationProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new System.ArgumentNullException(nameof(client));
        }

        public async Task<ApiResponse<CompanyProfileResponse>> GetCompanyProfileAsync(string symbol)
        {
            const string url = "profile/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<CompanyProfileResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<CompanyProfileResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetETFListAsync()
        {
            const string url = "etf/list";

            return client.GetJsonAsync<List<SymbolResponse>>(url, new NameValueCollection(), null);
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetSymbolsListAsync()
        {
            const string url = "stock/list";

            var pathParams = new NameValueCollection();

            return client.GetJsonAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<SymbolResponse>>> GetTradableSymbolsListAsync()
        {
            const string url = "available-traded/list";

            var pathParams = new NameValueCollection();

            return client.GetJsonAsync<List<SymbolResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<string>>> GetSymbolsWithFinancialStatementsAsync()
        {
            const string url = "financial-statement-symbol-lists";

            var pathParams = new NameValueCollection();

            return client.GetJsonAsync<List<string>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<EnterpriseValueResponse>>> GetEnterpriseValueAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "enterprise-values/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            // mandatory
            queryString.Add("period", period.ToString().ToLower());
            

            return client.GetJsonAsync<List<EnterpriseValueResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<BalanceSheetResponse>>> GetBalanceSheetStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "balance-sheet-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<BalanceSheetResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<CashFlowResponse>>> GetCashFlowStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "cash-flow-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<CashFlowResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<IncomeStatementResponse>>> GetIncomeStatementAsync(string symbol, Period period = Period.Quarter, int? limit = 40)
        {
            const string url = "income-statement/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            if (period == Period.Quarter)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<IncomeStatementResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(string symbol, int? limit = 50)
        {
            const string url = "stock_news";

            var pathParams = new NameValueCollection();

            var queryString = new QueryStringBuilder();

            queryString.Add("tickers", symbol);
            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetLatestStockNewsAsync(int? limit = 50)
        {
            const string url = "stock_news";

            var pathParams = new NameValueCollection();

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<StockNewsResponse>>> GetStockNewsAsync(IEnumerable<string> symbols, int? limit = 50)
        {
            const string url = "stock_news";

            var pathParams = new NameValueCollection();
        
            var queryString = new QueryStringBuilder();

            queryString.Add("tickers", string.Join(',', symbols));

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<StockNewsResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<CompanyRatingResponse>> GetCompanyRatingAsync(string symbol)
        {
            const string url = "rating/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<CompanyRatingResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<CompanyRatingResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<CompanyRatingResponse>>> GetHistoricalCompanyRatingAsync(string symbol, int? limit = 140)
        {
            const string url = "historical-rating/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<CompanyRatingResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<DCFResponse>> GetDiscountedCashFlowAsync(string symbol)
        {
            const string url = "discounted-cash-flow/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<DCFResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<DCFResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public async Task<ApiResponse<RatiosTTMResponse>> GetRatiosTTMAsync(string symbol)
        {
            const string url = "ratios-ttm/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<RatiosTTMResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<RatiosTTMResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public async Task<ApiResponse<KeyMetricsTTMResponse>> GetCompanyKeyMetricsTTMAsync(string symbol)
        {
            const string url = "key-metrics-ttm/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<KeyMetricsTTMResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<KeyMetricsTTMResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<KeyMetricsResponse>>> GetCompanyKeyMetricsAsync(string symbol, Period period = Period.Annual, int? limit = 130)
        {
            const string url = "key-metrics/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            if (period != Period.Annual)
            {
                queryString.Add("period", period.ToString().ToLower());
            }

            return client.GetJsonAsync<List<KeyMetricsResponse>>(url, pathParams, queryString);
        }

        public async Task<ApiResponse<QuoteResponse>> GetQuoteAsync(string symbol)
        {
            const string url = "quote/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<QuoteResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<QuoteResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(IEnumerable<string> symbols)
        {
            const string url = "quote/[symbols]";

            var pathParams = new NameValueCollection()
            {
                { "symbols", string.Join(',', symbols) }
            };

            if (string.IsNullOrEmpty(pathParams["symbols"]))
            {
                throw new ArgumentException(
                    "List of symbols cannot result in an empty string. At least one ticker symbol needs to be added.",
                    nameof(symbols));
            }

            return client.GetJsonAsync<List<QuoteResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<QuoteResponse>>> GetQuotesAsync(Exchange exchange)
        {
            const string url = "quotes/[exchange]";

            var pathParams = new NameValueCollection()
            {
                { "exchange", exchange.ToString() }
            };

            return client.GetJsonAsync<List<QuoteResponse>>(url, pathParams, null);
        }

        public async Task<ApiResponse<MarketCapResponse>> GetMarketCapitalizationAsync(string symbol)
        {
            const string url = "historical-market-capitalization/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var result = await client.GetJsonAsync<List<MarketCapResponse>>(url, pathParams, null);

            if (result.HasError)
            {
                return ApiResponse.FromError<MarketCapResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<MarketCapResponse>>> GetHistoricalMarketCapitalizationAsync(string symbol, int? limit = 100)
        {
            const string url = "historical-market-capitalization/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol }
            };

            var queryString = new QueryStringBuilder();
            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<MarketCapResponse>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<TickerSearchResponse>>> SearchAsync(string query, Exchange? exchange, int? limit = null)
            => SearchInternalAsync(query, exchange, false, limit);

        public Task<ApiResponse<List<TickerSearchResponse>>> SearchByTickerAsync(string query, Exchange? exchange, int? limit = null)
            => SearchInternalAsync(query, exchange, true, limit);

        private Task<ApiResponse<List<TickerSearchResponse>>> SearchInternalAsync(string query, Exchange? exchange, bool byTicker, int? limit)
        {
            const string url = "search";
            const string urlByTicker = "/search-ticker";

            var pathParams = new NameValueCollection();
          
            var queryString = new QueryStringBuilder();

            queryString.Add("query", query);
            if (exchange.HasValue) queryString.Add("exchange", exchange.Value.ToString());

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<TickerSearchResponse>>(byTicker ? urlByTicker : url, pathParams, queryString);
        }

        public Task<ApiResponse<List<PressReleasesResponse>>> GetPressReleasesAsync(string symbol, int? page = null)
        {
            const string url = "press-releases/[symbol]";

            var pathParams = new NameValueCollection()
            {
                { "symbol", symbol},
            };

            var queryString = new QueryStringBuilder();

            if (page != null)
            {
                queryString.Add("page", page);
            }

            return client.GetJsonAsync<List<PressReleasesResponse>>(url, pathParams, queryString);
        }

        /// <inheritdoc />
        public Task<ApiResponse<List<SymbolChangeResponse>>> GetSymbolChangesAsync()
        {
            const string url = "symbol_change";

            return client.GetJsonAsync<List<SymbolChangeResponse>>(url, new NameValueCollection(), null);

        }
    }
}
