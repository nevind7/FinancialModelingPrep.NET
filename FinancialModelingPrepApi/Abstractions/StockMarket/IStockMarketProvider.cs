using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.StockMarket;

namespace FinancialModelingPrep.Abstractions.StockMarket;

public interface IStockMarketProvider
{
    public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetMostActiveStocksAsync();
    public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestGainerStocksAsync();
    public Task<ApiResponse<List<StockMarketSymbolResponse>>> GetBiggestLoserStocksAsync();
    public Task<ApiResponse<List<StockScreenerItem>>> StockScreener(int? marketCapMoreThan = null, int? marketCapLowerThan = null, decimal? priceMoreThan = null, decimal? priceLowerThan = null, 
        decimal? betaMoreThan = null, decimal? betaLowerThan = null, int? volumeMoreThan = null, int? volumeLowerThan = null, bool? isEtf = null, bool? isActivelyTraded = null, 
        Sector? sector = null, Industry? industry = null, Country? country = null, Exchange? exchange = null, int? limit = 30);
}