using System;
using FinancialModelingPrep.Abstractions;
using FinancialModelingPrep.Abstractions.AdvancedData;
using FinancialModelingPrep.Abstractions.Calendars;
using FinancialModelingPrep.Abstractions.CompanyValuation;
using FinancialModelingPrep.Abstractions.Crypto;
using FinancialModelingPrep.Abstractions.Economics;
using FinancialModelingPrep.Abstractions.Fund;
using FinancialModelingPrep.Abstractions.Http;
using FinancialModelingPrep.Abstractions.InstitutionalFund;
using FinancialModelingPrep.Abstractions.MarketIndexes;
using FinancialModelingPrep.Abstractions.StatementAnalysis;
using FinancialModelingPrep.Abstractions.Statistics;
using FinancialModelingPrep.Abstractions.StockMarket;
using FinancialModelingPrep.Abstractions.StockTimeSeries;
using FinancialModelingPrep.Core;
using FinancialModelingPrep.Core.AdvancedData;
using FinancialModelingPrep.Core.Calendars;
using FinancialModelingPrep.Core.CompanyValuation;
using FinancialModelingPrep.Core.Crypto;
using FinancialModelingPrep.Core.Economics;
using FinancialModelingPrep.Core.Fund;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Core.InstitutionalFund;
using FinancialModelingPrep.Core.MarketIndexes;
using FinancialModelingPrep.Core.StatementAnalysis;
using FinancialModelingPrep.Core.Statistics;
using FinancialModelingPrep.Core.StockMarket;
using FinancialModelingPrep.Core.StockTimeSeries;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FinancialModelingPrep
{
    public static class DependencyInjectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IFinancialModelingPrepApiClient"/> to the services.
        /// This package does not override any existing registrations. 
        /// </summary>
        /// <param name="services">DI Service Collection</param>
        /// <param name="options">FMP Options <see cref="FinancialModelingPrepOptions"/> if left as null it will use the default options and default API Key</param>
        public static void AddFinancialModelingPrepApiClient(this IServiceCollection services, FinancialModelingPrepOptions options = null)
        {
            services.TryAddSingleton(options ?? new FinancialModelingPrepOptions());

            services.AddLogging();

            services.AddHttpClient<FinancialModelingPrepHttpClient>(client 
                => client.BaseAddress = new Uri("https://financialmodelingprep.com/stable/"));

            services.TryAddSingleton<IFinancialModelingPrepApiClient, FinancialModelingPrepApiClient>();
            services.TryAddSingleton<IRequestRateLimiter, RequestRateLimiter>();
            services.TryAddTransient<ICompanyValuationProvider, CompanyValuationProvider>();
            services.TryAddTransient<IMarketIndexesProvider, MarketIndexesProvider>();
            services.TryAddTransient<IAdvancedDataProvider, AdvancedDataProvider>();
            services.TryAddTransient<ICalendarsProvider, CalendarsProvider>();
            services.TryAddTransient<IInstitutionalFundProvider, InstitutionalFundProvider>();
            services.TryAddTransient<IStockTimeSeriesProvider, StockTimeSeriesProvider>();
            services.TryAddTransient<IStockMarketProvider, StockMarketProvider>();
            services.TryAddTransient<ICryptoMarketProvider, CryptoMarketProvider>();
            services.TryAddTransient<IStockStatisticsProvider, StockStatisticsProvider>();
            services.TryAddTransient<IFundProvider, FundProvider>();
            services.TryAddTransient<IEconomicsProvider, EconomicsProvider>();
            services.TryAddTransient<IStatementAnalysisProvider, StatementAnalysisProvider>();
        }
    }
}
