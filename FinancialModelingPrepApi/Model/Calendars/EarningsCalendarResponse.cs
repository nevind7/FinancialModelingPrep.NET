using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Calendars;

public sealed record EarningsCalendarResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("date")]
    public DateOnly? Date { get; init; }

    [JsonPropertyName("epsActual")]
    public decimal? EpsActual { get; init; }

    [JsonPropertyName("epsEstimated")]
    public decimal? EpsEstimated { get; init; }

    [JsonPropertyName("revenueActual")]
    public decimal? RevenueActual { get; init; }

    [JsonPropertyName("revenueEstimated")]
    public decimal? RevenueEstimated { get; init; }

    [JsonPropertyName("lastUpdated")]
    public DateOnly? LastUpdated { get; init; }
}