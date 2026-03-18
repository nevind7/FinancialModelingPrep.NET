using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.StatementAnalysis;

namespace FinancialModelingPrep.Abstractions.StatementAnalysis;

public interface IStatementAnalysisProvider
{
    public Task<ApiResponse<List<FinancialGrowthResponse>>> GetFinancialGrowthAsync(string symbol,
        Period period = Period.Annual, int? limit = 30);

    /// <summary>
    /// Revenue broken down by product/segment per fiscal period.
    /// The <c>Data</c> dictionary keys are segment names; values are revenue figures.
    /// </summary>
    public Task<ApiResponse<List<RevenueSegmentationItem>>> GetRevenueProductSegmentationAsync(
        string symbol, Period period = Period.Annual, RevenueSegmentationStructure? structure = null);
}