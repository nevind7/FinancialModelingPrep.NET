using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.Crypto;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Crypto;

namespace FinancialModelingPrep.Core.Crypto
{
    public sealed class CryptoMarketProvider : ICryptoMarketProvider
    {
        private readonly FinancialModelingPrepHttpClient client;

        public CryptoMarketProvider(FinancialModelingPrepHttpClient client)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Task<ApiResponse<List<CryptoItem>>> GetAvilableCryptocurrencies()
        {

            const string url = "symbol/available-cryptocurrencies";

            var pathParams = new NameValueCollection();
           
            return client.GetJsonAsync<List<CryptoItem>>(url, pathParams, null);
        }

        public Task<ApiResponse<CryptoHistoricalPriceDailyItem>> GetDailyPrices(string symbol)
        {
            const string url = "historical-price-full/[symbol]";

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol }
            };

            return client.GetJsonAsync<CryptoHistoricalPriceDailyItem>(url, pathParams, null);
        }

        public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period)
        {
            const string url = "historical-chart/[pricePeriod]/[symbol]";

            string pricePeriod = EnumMappings.HistoricalPrices[period];

            var pathParams = new NameValueCollection
            {
                { "symbol", symbol },
                { "pricePeriod", pricePeriod }
            };

            var queryString = new QueryStringBuilder();

            return client.GetJsonAsync<List<CryptoHistoricalPricePeriodListing>>(url, pathParams, queryString);
        }
    }
}
