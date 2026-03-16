using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Crypto;

public class CryptoHistoricalPricePeriodListing
{
    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("open")]
    public decimal Open { get; set; }

    [JsonPropertyName("high")]
    public decimal High { get; set; }

    [JsonPropertyName("low")]
    public decimal Low { get; set; }

    [JsonPropertyName("close")]
    public decimal Close { get; set; }

    [JsonPropertyName("volume")]
    public double Volume { get; set; }
}