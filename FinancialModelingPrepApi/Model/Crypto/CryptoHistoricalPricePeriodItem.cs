using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Crypto
{
    public class CryptoHistoricalPriceDailyItem
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<CyptoHistoricalPriceDailyListing> HistoricalPrices { get; set; }
    }
}
