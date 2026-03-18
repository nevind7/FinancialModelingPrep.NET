using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.TechnicalIndicators;

namespace FinancialModelingPrep.Abstractions.TechnicalIndicators;

public interface ITechnicalIndicatorsProvider
{
    /// <summary>
    /// Fetches a technical indicator time series for the given symbol.
    /// Only the property corresponding to <paramref name="indicator"/> will be populated
    /// on each <see cref="TechnicalIndicatorItem"/> in the response.
    /// </summary>
    Task<ApiResponse<List<TechnicalIndicatorItem>>> GetAsync(
        TechnicalIndicator indicator,
        string symbol,
        int periodLength,
        string timeframe,
        string? from = null,
        string? to = null);
}