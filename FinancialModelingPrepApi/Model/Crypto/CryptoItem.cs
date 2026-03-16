using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Crypto;

public sealed record CryptoItem
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    [JsonPropertyName("exchange")]
    public string Exchange { get; init; } = string.Empty;

    [JsonPropertyName("icoDate")]
    public DateOnly? IcoDate { get; init; }

    [JsonPropertyName("circulatingSupply")]
    public decimal? CirculatingSupply { get; init; }

    [JsonPropertyName("totalSupply")]
    public decimal? TotalSupply { get; init; }
}