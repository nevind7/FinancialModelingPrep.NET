using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.TechnicalIndicators;

public sealed record TechnicalIndicatorItem
{
    [JsonPropertyName("date")]
    public string Date { get; init; } = string.Empty;

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

    [JsonPropertyName("sma")]
    public decimal? Sma { get; init; }

    [JsonPropertyName("ema")]
    public decimal? Ema { get; init; }

    [JsonPropertyName("wma")]
    public decimal? Wma { get; init; }

    [JsonPropertyName("dema")]
    public decimal? Dema { get; init; }

    [JsonPropertyName("tema")]
    public decimal? Tema { get; init; }

    [JsonPropertyName("rsi")]
    public decimal? Rsi { get; init; }

    [JsonPropertyName("adx")]
    public decimal? Adx { get; init; }

    [JsonPropertyName("williams")]
    public decimal? Williams { get; init; }

    [JsonPropertyName("standardDeviation")]
    public decimal? StandardDeviation { get; init; }
}
