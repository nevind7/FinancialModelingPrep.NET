using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record AftermarketQuote
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("bidSize")]
    public int BidSize { get; init; }

    [JsonPropertyName("bidPrice")]
    public double BidPrice { get; init; }

    [JsonPropertyName("askSize")]
    public int AskSize { get; init; }

    [JsonPropertyName("askPrice")]
    public double AskPrice { get; init; }

    [JsonPropertyName("volume")]
    public long Volume { get; init; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; init; }
}