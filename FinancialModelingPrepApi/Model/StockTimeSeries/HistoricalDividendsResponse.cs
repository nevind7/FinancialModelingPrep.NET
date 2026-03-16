using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.StockTimeSeries;

public sealed record HistoricalDividendsResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    [JsonPropertyName("adjOpen")]
    public decimal AdjOpen { get; init; }

    [JsonPropertyName("adjHigh")]
    public decimal AdjHigh { get; init; }

    [JsonPropertyName("adjLow")]
    public decimal AdjLow { get; init; }

    [JsonPropertyName("adjClose")]
    public decimal AdjClose { get; init; }

    [JsonPropertyName("volume")]
    public long Volume { get; init; }
}