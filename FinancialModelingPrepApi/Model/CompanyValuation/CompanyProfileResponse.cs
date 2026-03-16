using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record CompanyProfileResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; init; }

    [JsonPropertyName("marketCap")]
    public long MarketCap { get; init; }

    [JsonPropertyName("beta")]
    public decimal Beta { get; init; }

    [JsonPropertyName("lastDividend")]
    public decimal LastDividend { get; init; }

    [JsonPropertyName("range")]
    public string Range { get; init; } = string.Empty;

    [JsonPropertyName("change")]
    public decimal Change { get; init; }

    [JsonPropertyName("changePercentage")]
    public decimal ChangePercentage { get; init; }

    [JsonPropertyName("volume")]
    public long Volume { get; init; }

    [JsonPropertyName("averageVolume")]
    public long AverageVolume { get; init; }

    [JsonPropertyName("companyName")]
    public string CompanyName { get; init; } = string.Empty;

    [JsonPropertyName("currency")]
    public string Currency { get; init; } = string.Empty;

    [JsonPropertyName("cik")]
    public string Cik { get; init; } = string.Empty;

    [JsonPropertyName("isin")]
    public string Isin { get; init; } = string.Empty;

    [JsonPropertyName("cusip")]
    public string Cusip { get; init; } = string.Empty;

    [JsonPropertyName("exchangeFullName")]
    public string ExchangeFullName { get; init; } = string.Empty;

    [JsonPropertyName("exchange")]
    public string Exchange { get; init; } = string.Empty;

    [JsonPropertyName("industry")]
    public string Industry { get; init; } = string.Empty;

    [JsonPropertyName("website")]
    public string Website { get; init; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;

    [JsonPropertyName("ceo")]
    public string Ceo { get; init; } = string.Empty;

    [JsonPropertyName("sector")]
    public string Sector { get; init; } = string.Empty;

    [JsonPropertyName("country")]
    public string Country { get; init; } = string.Empty;

    [JsonPropertyName("fullTimeEmployees")]
    public string FullTimeEmployees { get; init; } = string.Empty;

    [JsonPropertyName("phone")]
    public string Phone { get; init; } = string.Empty;

    [JsonPropertyName("address")]
    public string Address { get; init; } = string.Empty;

    [JsonPropertyName("city")]
    public string City { get; init; } = string.Empty;

    [JsonPropertyName("state")]
    public string State { get; init; } = string.Empty;

    [JsonPropertyName("zip")]
    public string Zip { get; init; } = string.Empty;

    [JsonPropertyName("image")]
    public string Image { get; init; } = string.Empty;

    [JsonPropertyName("ipoDate")]
    public DateOnly IpoDate { get; init; }

    [JsonPropertyName("defaultImage")]
    public bool DefaultImage { get; init; }

    [JsonPropertyName("isEtf")]
    public bool IsEtf { get; init; }

    [JsonPropertyName("isActivelyTrading")]
    public bool IsActivelyTrading { get; init; }

    [JsonPropertyName("isAdr")]
    public bool IsAdr { get; init; }

    [JsonPropertyName("isFund")]
    public bool IsFund { get; init; }
}