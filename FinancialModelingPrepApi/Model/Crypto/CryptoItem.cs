using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Crypto
{
    public class CryptoItem
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("stockExchange")]
        public string StockExchange { get; set; }

        [JsonPropertyName("exchangeShortName")]
        public string ExchangeShortName { get; set; }

    }
}
