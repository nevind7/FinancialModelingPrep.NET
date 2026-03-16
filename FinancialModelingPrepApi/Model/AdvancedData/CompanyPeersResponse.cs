using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.AdvancedData;

public sealed record CompanyPeersResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("companyName")]
    public string CompanyName { get; init; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; init; }

    [JsonPropertyName("mktCap")]
    public long MarketCap { get; init; }
}