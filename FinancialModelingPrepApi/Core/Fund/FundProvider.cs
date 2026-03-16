using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.Fund;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Fund;

namespace FinancialModelingPrep.Core.Fund
{
    public class FundProvider : IFundProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public FundProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<ETFStockExposureResponse>>> GetETFStockExposureAsync(string symbol)
        {
            const string url = "etf-stock-exposure/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            return client.GetJsonAsync<List<ETFStockExposureResponse>>(url, pathParams, null);
        }
    }
}
