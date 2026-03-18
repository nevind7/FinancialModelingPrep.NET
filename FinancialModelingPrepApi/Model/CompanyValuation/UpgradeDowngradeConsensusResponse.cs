using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record UpgradeDowngradeConsensusResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("strongBuy")]
    public int StrongBuy { get; init; }

    [JsonPropertyName("buy")]
    public int Buy { get; init; }

    [JsonPropertyName("hold")]
    public int Hold { get; init; }

    [JsonPropertyName("sell")]
    public int Sell { get; init; }

    [JsonPropertyName("strongSell")]
    public int StrongSell { get; init; }

    [JsonPropertyName("consensus")]
    public string Consensus { get; init; } = string.Empty;
}
