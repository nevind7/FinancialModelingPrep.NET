using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.InstitutionalFund;

public class CusipMapperResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("cusip")]
    public string Cusip { get; set; }

    [JsonPropertyName("companyName")]
    public string Company { get; set; }
    
    [JsonPropertyName("marketCap")]
    public decimal MarketCap { get; set; }
}