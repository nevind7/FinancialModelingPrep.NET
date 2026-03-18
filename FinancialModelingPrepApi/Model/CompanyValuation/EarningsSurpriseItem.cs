using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record EarningsSurpriseItem
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    [JsonPropertyName("actualEarningResult")]
    public decimal? ActualEarningResult { get; init; }

    [JsonPropertyName("estimatedEarning")]
    public decimal? EstimatedEarning { get; init; }
}
