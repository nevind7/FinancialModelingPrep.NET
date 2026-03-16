using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Fund;

namespace FinancialModelingPrep.Abstractions.Fund
{
    public interface IFundProvider
    {
        public Task<ApiResponse<List<ETFStockExposureResponse>>> GetETFStockExposureAsync(string symbol);

    }
}
