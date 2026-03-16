using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Calendars;

public class StockSplitCalendarResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
    
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("numerator")]
    public double Numerator { get; set; }

    [JsonPropertyName("denominator")]
    public double Denominator { get; set; }
}