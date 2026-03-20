using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed class GradeResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    [JsonPropertyName("gradingCompany")]
    public string GradingCompany { get; set; } = string.Empty;

    [JsonPropertyName("previousGrade")]
    public string PreviousGrade { get; set; } = string.Empty;

    [JsonPropertyName("newGrade")]
    public string NewGrade { get; set; } = string.Empty;

    [JsonPropertyName("action")]
    public string Action { get; set; } = string.Empty;
}
