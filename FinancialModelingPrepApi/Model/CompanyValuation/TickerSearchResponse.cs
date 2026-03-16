using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public class TickerSearchResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("exchangeFullName")]
    public string StockExchange { get; set; }

    [JsonPropertyName("exchange")]
    public string ExchangeShortName { get; set; }
}