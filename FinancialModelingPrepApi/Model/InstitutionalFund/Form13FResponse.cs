using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.InstitutionalFund;

public sealed record Form13FResponse
{
    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    [JsonPropertyName("filingDate")]
    public DateOnly FilingDate { get; init; }

    [JsonPropertyName("acceptedDate")]
    public DateOnly AcceptedDate { get; init; }

    [JsonPropertyName("cik")]
    public string Cik { get; init; } = string.Empty;

    [JsonPropertyName("securityCusip")]
    public string SecurityCusip { get; init; } = string.Empty;

    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("nameOfIssuer")]
    public string NameOfIssuer { get; init; } = string.Empty;

    [JsonPropertyName("shares")]
    public long Shares { get; init; }

    [JsonPropertyName("titleOfClass")]
    public string TitleOfClass { get; init; } = string.Empty;

    [JsonPropertyName("sharesType")]
    public string SharesType { get; init; } = string.Empty;

    [JsonPropertyName("putCallShare")]
    public string PutCallShare { get; init; } = string.Empty;

    [JsonPropertyName("value")]
    public long Value { get; init; }

    [JsonPropertyName("link")]
    public string Link { get; init; } = string.Empty;

    [JsonPropertyName("finalLink")]
    public string FinalLink { get; init; } = string.Empty;
}