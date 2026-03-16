using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Crypto;

public sealed record CryptoHistoricalPriceDailyItem
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    [JsonPropertyName("open")]
    public decimal Open { get; init; }

    [JsonPropertyName("high")]
    public decimal High { get; init; }

    [JsonPropertyName("low")]
    public decimal Low { get; init; }

    [JsonPropertyName("close")]
    public decimal Close { get; init; }

    [JsonPropertyName("volume")]
    public long Volume { get; init; }

    [JsonPropertyName("change")]
    public decimal Change { get; init; }

    [JsonPropertyName("changePercent")]
    public decimal ChangePercent { get; init; }

    [JsonPropertyName("vwap")]
    public decimal Vwap { get; init; }
}