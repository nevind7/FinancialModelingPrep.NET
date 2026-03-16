using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.StockMarket;

public sealed record StockScreenerItem
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("companyName")]
    public string CompanyName { get; init; } = string.Empty;

    [JsonPropertyName("marketCap")]
    public long MarketCap { get; init; }

    [JsonPropertyName("sector")]
    public string Sector { get; init; } = string.Empty;

    [JsonPropertyName("industry")]
    public string Industry { get; init; } = string.Empty;

    [JsonPropertyName("beta")]
    public decimal Beta { get; init; }

    [JsonPropertyName("price")]
    public decimal Price { get; init; }

    [JsonPropertyName("lastAnnualDividend")]
    public decimal LastAnnualDividend { get; init; }

    [JsonPropertyName("volume")]
    public long Volume { get; init; }

    [JsonPropertyName("exchange")]
    public string Exchange { get; init; } = string.Empty;

    [JsonPropertyName("exchangeShortName")]
    public string ExchangeShortName { get; init; } = string.Empty;

    [JsonPropertyName("country")]
    public string Country { get; init; } = string.Empty;

    [JsonPropertyName("isEtf")]
    public bool IsEtf { get; init; }

    [JsonPropertyName("isFund")]
    public bool IsFund { get; init; }

    [JsonPropertyName("isActivelyTrading")]
    public bool IsActivelyTrading { get; init; }
}