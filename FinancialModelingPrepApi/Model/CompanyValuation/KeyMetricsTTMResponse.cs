using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public record KeyMetricsTTMResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("marketCap")]
    public decimal MarketCap { get; init; }

    [JsonPropertyName("enterpriseValueTTM")]
    public long EnterpriseValueTTM { get; init; }

    [JsonPropertyName("evToSalesTTM")]
    public double EvToSalesTTM { get; init; }

    [JsonPropertyName("evToOperatingCashFlowTTM")]
    public double EvToOperatingCashFlowTTM { get; init; }

    [JsonPropertyName("evToFreeCashFlowTTM")]
    public double EvToFreeCashFlowTTM { get; init; }

    [JsonPropertyName("evToEBITDATTM")]
    public double EvToEBITDATTM { get; init; }

    [JsonPropertyName("netDebtToEBITDATTM")]
    public double NetDebtToEBITDATTM { get; init; }

    [JsonPropertyName("currentRatioTTM")]
    public double CurrentRatioTTM { get; init; }

    [JsonPropertyName("incomeQualityTTM")]
    public double IncomeQualityTTM { get; init; }

    [JsonPropertyName("grahamNumberTTM")]
    public double GrahamNumberTTM { get; init; }

    [JsonPropertyName("grahamNetNetTTM")]
    public double GrahamNetNetTTM { get; init; }

    [JsonPropertyName("taxBurdenTTM")]
    public double TaxBurdenTTM { get; init; }

    [JsonPropertyName("interestBurdenTTM")]
    public double InterestBurdenTTM { get; init; }

    [JsonPropertyName("workingCapitalTTM")]
    public long WorkingCapitalTTM { get; init; }

    [JsonPropertyName("investedCapitalTTM")]
    public long InvestedCapitalTTM { get; init; }

    [JsonPropertyName("returnOnAssetsTTM")]
    public double ReturnOnAssetsTTM { get; init; }

    [JsonPropertyName("operatingReturnOnAssetsTTM")]
    public double OperatingReturnOnAssetsTTM { get; init; }

    [JsonPropertyName("returnOnTangibleAssetsTTM")]
    public double ReturnOnTangibleAssetsTTM { get; init; }

    [JsonPropertyName("returnOnEquityTTM")]
    public double ReturnOnEquityTTM { get; init; }

    [JsonPropertyName("returnOnInvestedCapitalTTM")]
    public double ReturnOnInvestedCapitalTTM { get; init; }

    [JsonPropertyName("returnOnCapitalEmployedTTM")]
    public double ReturnOnCapitalEmployedTTM { get; init; }

    [JsonPropertyName("earningsYieldTTM")]
    public double EarningsYieldTTM { get; init; }

    [JsonPropertyName("freeCashFlowYieldTTM")]
    public double FreeCashFlowYieldTTM { get; init; }

    [JsonPropertyName("capexToOperatingCashFlowTTM")]
    public double CapexToOperatingCashFlowTTM { get; init; }

    [JsonPropertyName("capexToDepreciationTTM")]
    public double CapexToDepreciationTTM { get; init; }

    [JsonPropertyName("capexToRevenueTTM")]
    public double CapexToRevenueTTM { get; init; }

    [JsonPropertyName("salesGeneralAndAdministrativeToRevenueTTM")]
    public double SalesGeneralAndAdministrativeToRevenueTTM { get; init; }

    [JsonPropertyName("researchAndDevelopementToRevenueTTM")]
    public double ResearchAndDevelopementToRevenueTTM { get; init; }

    [JsonPropertyName("stockBasedCompensationToRevenueTTM")]
    public double StockBasedCompensationToRevenueTTM { get; init; }

    [JsonPropertyName("intangiblesToTotalAssetsTTM")]
    public double IntangiblesToTotalAssetsTTM { get; init; }

    [JsonPropertyName("averageReceivablesTTM")]
    public long AverageReceivablesTTM { get; init; }

    [JsonPropertyName("averagePayablesTTM")]
    public long AveragePayablesTTM { get; init; }

    [JsonPropertyName("averageInventoryTTM")]
    public long AverageInventoryTTM { get; init; }

    [JsonPropertyName("daysOfSalesOutstandingTTM")]
    public double DaysOfSalesOutstandingTTM { get; init; }

    [JsonPropertyName("daysOfPayablesOutstandingTTM")]
    public double DaysOfPayablesOutstandingTTM { get; init; }

    [JsonPropertyName("daysOfInventoryOutstandingTTM")]
    public double DaysOfInventoryOutstandingTTM { get; init; }

    [JsonPropertyName("operatingCycleTTM")]
    public double OperatingCycleTTM { get; init; }

    [JsonPropertyName("cashConversionCycleTTM")]
    public double CashConversionCycleTTM { get; init; }

    [JsonPropertyName("freeCashFlowToEquityTTM")]
    public long FreeCashFlowToEquityTTM { get; init; }

    [JsonPropertyName("freeCashFlowToFirmTTM")]
    public double FreeCashFlowToFirmTTM { get; init; }

    [JsonPropertyName("tangibleAssetValueTTM")]
    public long TangibleAssetValueTTM { get; init; }

    [JsonPropertyName("netCurrentAssetValueTTM")]
    public long NetCurrentAssetValueTTM { get; init; }
}