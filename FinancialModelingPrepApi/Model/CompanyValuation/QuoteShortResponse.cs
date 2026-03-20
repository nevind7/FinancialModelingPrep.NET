using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public class QuoteShortResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
    
    [JsonPropertyName("price")]
    public double? Price { get; set; }
    
    [JsonPropertyName("change")]
    public double? Change { get; set; }
    
    [JsonPropertyName("volume")]
    public double? Volume { get; set; }
}