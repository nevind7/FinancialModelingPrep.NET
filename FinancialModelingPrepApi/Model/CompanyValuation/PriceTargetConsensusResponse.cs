using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record PriceTargetConsensusResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("targetHigh")]
    public decimal? TargetHigh { get; init; }

    [JsonPropertyName("targetLow")]
    public decimal? TargetLow { get; init; }

    [JsonPropertyName("targetMedian")]
    public decimal? TargetMedian { get; init; }

    [JsonPropertyName("targetConsensus")]
    public decimal? TargetConsensus { get; init; }
}
