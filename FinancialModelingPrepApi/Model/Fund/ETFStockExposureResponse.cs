using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Fund;

public class ETFStockExposureResponse
{
    [JsonPropertyName("symbol")]
    public string EtfSymbol { get; set; }

    [JsonPropertyName("asset")]
    public string AssetExposure { get; set; }

    [JsonPropertyName("sharesNumber")]
    public double SharesNumber { get; set; }

    [JsonPropertyName("weightPercentage")]
    public double WeightPercentage { get; set; }

    [JsonPropertyName("marketValue")]
    public double MarketValue { get; set; }
}