using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.StatementAnalysis;

namespace FinancialModelingPrep.Abstractions.StatementAnalysis;

public interface IStatementAnalysisProvider
{
    public Task<ApiResponse<List<FinancialGrowthResponse>>> GetFinancialGrowthAsync(string symbol,
        Period period = Period.Annual, int? limit = 30);
}