using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Crypto;

namespace FinancialModelingPrep.Abstractions.Crypto;

public interface ICryptoMarketProvider
{
    public Task<ApiResponse<List<CryptoItem>>> GetAvailableCryptocurrencies();

    public Task<ApiResponse<List<CryptoHistoricalPricePeriodListing>>> GetHistoricalPrices(string symbol, HistoricalPricingPeriod period);

    public Task<ApiResponse<List<CryptoHistoricalPriceDailyItem>>> GetDailyPrices(string symbol);
}