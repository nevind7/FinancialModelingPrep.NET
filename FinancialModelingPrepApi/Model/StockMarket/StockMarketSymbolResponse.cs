using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.StockMarket;

public sealed record StockMarketSymbolResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    [JsonPropertyName("change")]
    public decimal Change { get; init; }

    [JsonPropertyName("changesPercentage")]
    public decimal ChangesPercentage { get; init; }

    [JsonPropertyName("exchange")]
    public string Exchange { get; init; } = string.Empty;
}