using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Statistics;

namespace FinancialModelingPrep.Abstractions.Statistics;

/// <summary>
/// Stock related statistics
/// </summary>
public interface IStockStatisticsProvider
{
    /// <summary>
    /// Get analyst estimates
    /// </summary>
    /// <param name="symbol">Stock symbol</param>
    /// <param name="period">Period (Annual or Quarterly)</param>
    /// <param name="limit">Limts the amount of results</param>
    /// <returns></returns>
    public Task<ApiResponse<List<AnalystEstimateItem>>> GetAnalystEstimatesAsync(string symbol, Period period = Period.Annual, int? limit = 30);
}