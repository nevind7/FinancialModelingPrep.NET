using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.MarketIndexes;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.MarketIndexes;

namespace FinancialModelingPrep.Core.MarketIndexes
{
    public class MarketIndexesProvider : IMarketIndexesProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public MarketIndexesProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetDowJonesCompaniesAsync()
        {
            const string url = "dowjones_constituent";

            var pathParams = new NameValueCollection();
          
            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetNasdaqCompaniesAsync()
        {
            const string url = "nasdaq_constituent";

            var pathParams = new NameValueCollection();

            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }

        public Task<ApiResponse<List<IndexConstituentResponse>>> GetSP500CompaniesAsync()
        {
            const string url = "sp500_constituent";

            var pathParams = new NameValueCollection();
           
            return client.GetJsonAsync<List<IndexConstituentResponse>>(url, pathParams, null);
        }
    }
}
