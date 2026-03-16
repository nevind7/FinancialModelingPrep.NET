using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Calendars;

public class DividendCalendarResponse
{
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
        
    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    [JsonPropertyName("adjDividend")]
    public decimal AdjDividend { get; set; }
        
    [JsonPropertyName("dividend")]
    public decimal? Dividend { get; set; }

    [JsonPropertyName("recordDate")]
    public string RecordDate { get; init; } = string.Empty;

    [JsonPropertyName("paymentDate")]
    public string PaymentDate { get; init; } = string.Empty;

    [JsonPropertyName("declarationDate")]
    public string DeclarationDate { get; init; } = string.Empty;
        
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
        
    [JsonPropertyName("yield")]
    public decimal Yield { get; set; }
}