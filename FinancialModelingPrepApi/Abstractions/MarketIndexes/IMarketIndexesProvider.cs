using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.MarketIndexes;

namespace FinancialModelingPrep.Abstractions.MarketIndexes
{
    public interface IMarketIndexesProvider
    {
        Task<ApiResponse<List<IndexConstituentResponse>>> GetSP500CompaniesAsync();
        Task<ApiResponse<List<IndexConstituentResponse>>> GetNasdaqCompaniesAsync();
        Task<ApiResponse<List<IndexConstituentResponse>>> GetDowJonesCompaniesAsync();
    }
}
