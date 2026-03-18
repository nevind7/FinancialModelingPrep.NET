using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record InsiderTradingResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("filingDate")]
    public string FilingDate { get; init; } = string.Empty;

    [JsonPropertyName("transactionDate")]
    public string TransactionDate { get; init; } = string.Empty;

    [JsonPropertyName("reportingName")]
    public string ReportingName { get; init; } = string.Empty;

    [JsonPropertyName("typeOfOwner")]
    public string TypeOfOwner { get; init; } = string.Empty;

    [JsonPropertyName("transactionType")]
    public string TransactionType { get; init; } = string.Empty;

    [JsonPropertyName("securitiesTransacted")]
    public decimal SecuritiesTransacted { get; init; }

    [JsonPropertyName("price")]
    public decimal Price { get; init; }

    [JsonPropertyName("securitiesOwned")]
    public decimal SecuritiesOwned { get; init; }

    [JsonPropertyName("securityName")]
    public string SecurityName { get; init; } = string.Empty;

    [JsonPropertyName("acquistionOrDisposition")]
    public string AcquisitionOrDisposition { get; init; } = string.Empty;
}
