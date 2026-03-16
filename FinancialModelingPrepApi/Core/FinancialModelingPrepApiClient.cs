using FinancialModelingPrep.Abstractions;
using FinancialModelingPrep.Abstractions.AdvancedData;
using FinancialModelingPrep.Abstractions.Calendars;
using FinancialModelingPrep.Abstractions.CompanyValuation;
using FinancialModelingPrep.Abstractions.Crypto;
using FinancialModelingPrep.Abstractions.Economics;
using FinancialModelingPrep.Abstractions.Fund;
using FinancialModelingPrep.Abstractions.InstitutionalFund;
using FinancialModelingPrep.Abstractions.MarketIndexes;
using FinancialModelingPrep.Abstractions.StatementAnalysis;
using FinancialModelingPrep.Abstractions.Statistics;
using FinancialModelingPrep.Abstractions.StockMarket;
using FinancialModelingPrep.Abstractions.StockTimeSeries;

namespace FinancialModelingPrep.Core;

/// <inheritdoc/>
public class FinancialModelingPrepApiClient : IFinancialModelingPrepApiClient
{
    /// <inheritdoc/>
    public ICompanyValuationProvider CompanyValuation { get; }

    /// <inheritdoc/>
    public IMarketIndexesProvider MarketIndexes { get; }

    /// <inheritdoc/>
    public IAdvancedDataProvider AdvancedData { get; }

    /// <inheritdoc/>
    public ICalendarsProvider Calendars { get; }

    /// <inheritdoc/>
    public IInstitutionalFundProvider InstitutionalFund { get; }

    /// <inheritdoc/>
    public IStockTimeSeriesProvider StockTimeSeries { get; }

    /// <inheritdoc/>
    public IStockMarketProvider StockMarket { get; }

    /// <inheritdoc/>
    public IStockStatisticsProvider StockStatistics { get; }

    /// <inheritdoc/>
    public ICryptoMarketProvider Crypto { get; }

    /// <inheritdoc/>
    public IFundProvider Fund { get; }

    /// <inheritdoc/>
    public IEconomicsProvider Economics { get; }

    public IStatementAnalysisProvider StatementAnalysis { get; }

    /// <inheritdoc/>
    public FinancialModelingPrepApiClient(ICompanyValuationProvider companyValuation,
        IMarketIndexesProvider marketIndexes,
        IAdvancedDataProvider advancedData,
        ICalendarsProvider calendars,
        IInstitutionalFundProvider institutionalFund,
        IStockTimeSeriesProvider stockTimeSeries,
        IStockMarketProvider stockMarket,
        IStockStatisticsProvider stockStatistics,
        ICryptoMarketProvider cryptoMarket,
        IFundProvider fund,
        IEconomicsProvider economics,
        IStatementAnalysisProvider statementAnalysis)
    {
        CompanyValuation = companyValuation;
        MarketIndexes = marketIndexes;
        AdvancedData = advancedData;
        Calendars = calendars;
        InstitutionalFund = institutionalFund;
        StockTimeSeries = stockTimeSeries;
        StockMarket = stockMarket;
        StockStatistics = stockStatistics;
        Crypto = cryptoMarket;
        Fund = fund;
        Economics = economics;
        StatementAnalysis = statementAnalysis;
    }
}