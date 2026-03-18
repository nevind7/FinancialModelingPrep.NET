using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record InsiderTradingStatisticItem
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("cik")]
    public string Cik { get; init; } = string.Empty;

    [JsonPropertyName("year")]
    public int Year { get; init; }

    [JsonPropertyName("quarter")]
    public int Quarter { get; init; }

    [JsonPropertyName("acquiredTransactions")]
    public int AcquiredTransactions { get; init; }

    [JsonPropertyName("disposedTransactions")]
    public int DisposedTransactions { get; init; }

    [JsonPropertyName("acquiredDisposedRatio")]
    public decimal AcquiredDisposedRatio { get; init; }

    [JsonPropertyName("totalAcquired")]
    public long TotalAcquired { get; init; }

    [JsonPropertyName("totalDisposed")]
    public long TotalDisposed { get; init; }

    [JsonPropertyName("averageAcquired")]
    public decimal AverageAcquired { get; init; }

    [JsonPropertyName("averageDisposed")]
    public decimal AverageDisposed { get; init; }

    [JsonPropertyName("totalPurchases")]
    public int TotalPurchases { get; init; }

    [JsonPropertyName("totalSales")]
    public int TotalSales { get; init; }
}
