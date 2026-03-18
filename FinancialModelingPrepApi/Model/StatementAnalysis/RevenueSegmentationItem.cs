using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.StatementAnalysis;

public sealed record RevenueSegmentationItem
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("fiscalYear")]
    public int FiscalYear { get; init; }

    [JsonPropertyName("period")]
    public string Period { get; init; } = string.Empty;

    [JsonPropertyName("reportedCurrency")]
    public string? ReportedCurrency { get; init; }

    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    /// <summary>
    /// Dynamic product/segment breakdown — keys are segment names, values are revenue in the reported currency.
    /// </summary>
    [JsonPropertyName("data")]
    public Dictionary<string, long> Data { get; init; } = new();
}
