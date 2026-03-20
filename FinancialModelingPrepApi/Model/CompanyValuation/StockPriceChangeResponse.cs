using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record StockPriceChangeResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("1D")]
    public double OneDay { get; init; }

    [JsonPropertyName("5D")]
    public double FiveDay { get; init; }

    [JsonPropertyName("1M")]
    public double OneMonth { get; init; }

    [JsonPropertyName("3M")]
    public double ThreeMonth { get; init; }

    [JsonPropertyName("6M")]
    public double SixMonth { get; init; }

    [JsonPropertyName("ytd")]
    public double Ytd { get; init; }

    [JsonPropertyName("1Y")]
    public double OneYear { get; init; }

    [JsonPropertyName("3Y")]
    public double ThreeYear { get; init; }

    [JsonPropertyName("5Y")]
    public double FiveYear { get; init; }

    [JsonPropertyName("10Y")]
    public double TenYear { get; init; }

    [JsonPropertyName("max")]
    public double Max { get; init; }
}