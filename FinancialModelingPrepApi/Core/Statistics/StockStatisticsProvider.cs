using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.Statistics;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Statistics;

namespace FinancialModelingPrep.Core.Statistics
{
    /// <inheritdoc/>
    public class StockStatisticsProvider : IStockStatisticsProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public StockStatisticsProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        /// <inheritdoc/>
        public Task<ApiResponse<List<AnalystEstimateItem>>> GetAnalystEstimatesAsync(string symbol, Period period = Period.Annual, int? limit = 30)
        {
            const string url = "analyst-estimates/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol },
            };

            var queryString = new QueryStringBuilder();

            queryString.Add("period", period.ToString().ToLower());

            if (limit != null)
            {
                queryString.Add("limit", limit);
            }

            return client.GetJsonAsync<List<AnalystEstimateItem>>(url, pathParams, queryString);
        }

        public Task<ApiResponse<List<SocialSentimentItem>>> GetSocialSentimentAsync(string symbol, int page = 0)
        {
            const string url = "historical/social-sentiment/";

            var queryString = new QueryStringBuilder();
            queryString.Add("symbol", symbol);
            queryString.Add("page", page.ToString());

            return client.GetJsonAsync<List<SocialSentimentItem>>(url, new NameValueCollection(), queryString);
        }
    }
}
