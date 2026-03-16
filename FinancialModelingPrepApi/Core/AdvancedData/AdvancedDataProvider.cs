using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.AdvancedData;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.AdvancedData;

namespace FinancialModelingPrep.Core.AdvancedData
{
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
            const string url = "financial-reports-json";

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
            const string url = "standard_industrial_classification";

            var queryString = new QueryStringBuilder();
            queryString.Add(queryParamName, queryParamValue);

            var result = await client.GetJsonAsync<List<StandardIndustrialClassificationResponse>>(url, new NameValueCollection(), queryString);

            if (result.HasError)
            {
                return ApiResponse.FromError<StandardIndustrialClassificationResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public async Task<ApiResponse<CompanyPeersResponse>> GetStockPeersAsync(string symbol)
        {
            const string url = "stock_peers";

            var queryString = new QueryStringBuilder();
            queryString.Add("symbol", symbol);

            var result = await client.GetJsonAsync<List<CompanyPeersResponse>>(url, new NameValueCollection(), queryString);

            if (result.HasError)
            {
                return ApiResponse.FromError<CompanyPeersResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<SectorPEResponse>>> GetSectorsPriceEarningsRatioAsync(string date, string exchange)
            => GetGenericPERationAsync<SectorPEResponse>("/sector_price_earning_ratio", date, exchange);

            public Task<ApiResponse<List<IndustryPEResponse>>> GetIndustriesPriceEarningsRatioAsync(string date, string exchange)
            => GetGenericPERationAsync<IndustryPEResponse>("/industry_price_earning_ratio", date, exchange);

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
            const string url = "shares_float";

            var queryString = new QueryStringBuilder();
            queryString.Add("symbol", symbol);

            var result = await client.GetJsonAsync<List<SharesFloatResponse>>(url, new NameValueCollection(), queryString);

            if (result.HasError)
            {
                return ApiResponse.FromError<SharesFloatResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }

        public Task<ApiResponse<List<ESGScoreResponse>>> GetESGScoreAsync(string symbol)
        {
            const string url = "esg-environmental-social-governance-data";

            var queryString = new QueryStringBuilder();
            queryString.Add("symbol", symbol);

            return client.GetJsonAsync<List<ESGScoreResponse>>(url, new NameValueCollection(), queryString);
        }

        public async Task<ApiResponse<FinancialScoreResponse>> GetFinancialScoreAsync(string symbol)
        {
            const string url = "financial-scores";
        
            var queryString = new QueryStringBuilder();
            queryString.Add("symbol", symbol);

            var result = await client.GetJsonAsync<List<FinancialScoreResponse>>(url, new NameValueCollection(), queryString);

            if (result.HasError)
            {
                return ApiResponse.FromError<FinancialScoreResponse>(result.Error);
            }

            return ApiResponse.FromSucces(result.Data.First());
        }
    }
}
