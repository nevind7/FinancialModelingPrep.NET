using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record CompanyRatingResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("rating")]
    public string Rating { get; init; } = string.Empty;

    [JsonPropertyName("overallScore")]
    public int OverallScore { get; init; }

    [JsonPropertyName("discountedCashFlowScore")]
    public int DiscountedCashFlowScore { get; init; }

    [JsonPropertyName("returnOnEquityScore")]
    public int ReturnOnEquityScore { get; init; }

    [JsonPropertyName("returnOnAssetsScore")]
    public int ReturnOnAssetsScore { get; init; }

    [JsonPropertyName("debtToEquityScore")]
    public int DebtToEquityScore { get; init; }

    [JsonPropertyName("priceToEarningsScore")]
    public int PriceToEarningsScore { get; init; }

    [JsonPropertyName("priceToBookScore")]
    public int PriceToBookScore { get; init; }
}