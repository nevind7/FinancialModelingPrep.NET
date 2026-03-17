using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record RatiosTTMResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("grossProfitMarginTTM")]
    public double? GrossProfitMarginTTM { get; init; }

    [JsonPropertyName("ebitMarginTTM")]
    public double? EbitMarginTTM { get; init; }

    [JsonPropertyName("ebitdaMarginTTM")]
    public double? EbitdaMarginTTM { get; init; }

    [JsonPropertyName("operatingProfitMarginTTM")]
    public double? OperatingProfitMarginTTM { get; init; }

    [JsonPropertyName("pretaxProfitMarginTTM")]
    public double? PretaxProfitMarginTTM { get; init; }

    [JsonPropertyName("continuousOperationsProfitMarginTTM")]
    public double? ContinuousOperationsProfitMarginTTM { get; init; }

    [JsonPropertyName("netProfitMarginTTM")]
    public double? NetProfitMarginTTM { get; init; }

    [JsonPropertyName("bottomLineProfitMarginTTM")]
    public double? BottomLineProfitMarginTTM { get; init; }

    [JsonPropertyName("receivablesTurnoverTTM")]
    public double? ReceivablesTurnoverTTM { get; init; }

    [JsonPropertyName("payablesTurnoverTTM")]
    public double? PayablesTurnoverTTM { get; init; }

    [JsonPropertyName("inventoryTurnoverTTM")]
    public double? InventoryTurnoverTTM { get; init; }

    [JsonPropertyName("fixedAssetTurnoverTTM")]
    public double? FixedAssetTurnoverTTM { get; init; }

    [JsonPropertyName("assetTurnoverTTM")]
    public double? AssetTurnoverTTM { get; init; }

    [JsonPropertyName("currentRatioTTM")]
    public double? CurrentRatioTTM { get; init; }

    [JsonPropertyName("quickRatioTTM")]
    public double? QuickRatioTTM { get; init; }

    [JsonPropertyName("solvencyRatioTTM")]
    public double? SolvencyRatioTTM { get; init; }

    [JsonPropertyName("cashRatioTTM")]
    public double? CashRatioTTM { get; init; }

    [JsonPropertyName("priceToEarningsRatioTTM")]
    public double? PriceToEarningsRatioTTM { get; init; }

    [JsonPropertyName("priceToEarningsGrowthRatioTTM")]
    public double? PriceToEarningsGrowthRatioTTM { get; init; }

    [JsonPropertyName("forwardPriceToEarningsGrowthRatioTTM")]
    public double? ForwardPriceToEarningsGrowthRatioTTM { get; init; }

    [JsonPropertyName("priceToBookRatioTTM")]
    public double? PriceToBookRatioTTM { get; init; }

    [JsonPropertyName("priceToSalesRatioTTM")]
    public double? PriceToSalesRatioTTM { get; init; }

    [JsonPropertyName("priceToFreeCashFlowRatioTTM")]
    public double? PriceToFreeCashFlowRatioTTM { get; init; }

    [JsonPropertyName("priceToOperatingCashFlowRatioTTM")]
    public double? PriceToOperatingCashFlowRatioTTM { get; init; }

    [JsonPropertyName("debtToAssetsRatioTTM")]
    public double? DebtToAssetsRatioTTM { get; init; }

    [JsonPropertyName("debtToEquityRatioTTM")]
    public double? DebtToEquityRatioTTM { get; init; }

    [JsonPropertyName("debtToCapitalRatioTTM")]
    public double? DebtToCapitalRatioTTM { get; init; }

    [JsonPropertyName("longTermDebtToCapitalRatioTTM")]
    public double? LongTermDebtToCapitalRatioTTM { get; init; }

    [JsonPropertyName("financialLeverageRatioTTM")]
    public double? FinancialLeverageRatioTTM { get; init; }

    [JsonPropertyName("workingCapitalTurnoverRatioTTM")]
    public double? WorkingCapitalTurnoverRatioTTM { get; init; }

    [JsonPropertyName("operatingCashFlowRatioTTM")]
    public double? OperatingCashFlowRatioTTM { get; init; }

    [JsonPropertyName("operatingCashFlowSalesRatioTTM")]
    public double? OperatingCashFlowSalesRatioTTM { get; init; }

    [JsonPropertyName("freeCashFlowOperatingCashFlowRatioTTM")]
    public double? FreeCashFlowOperatingCashFlowRatioTTM { get; init; }

    [JsonPropertyName("debtServiceCoverageRatioTTM")]
    public double? DebtServiceCoverageRatioTTM { get; init; }

    [JsonPropertyName("interestCoverageRatioTTM")]
    public double? InterestCoverageRatioTTM { get; init; }

    [JsonPropertyName("shortTermOperatingCashFlowCoverageRatioTTM")]
    public double? ShortTermOperatingCashFlowCoverageRatioTTM { get; init; }

    [JsonPropertyName("operatingCashFlowCoverageRatioTTM")]
    public double? OperatingCashFlowCoverageRatioTTM { get; init; }

    [JsonPropertyName("capitalExpenditureCoverageRatioTTM")]
    public double? CapitalExpenditureCoverageRatioTTM { get; init; }

    [JsonPropertyName("dividendPaidAndCapexCoverageRatioTTM")]
    public double? DividendPaidAndCapexCoverageRatioTTM { get; init; }

    [JsonPropertyName("dividendPayoutRatioTTM")]
    public double? DividendPayoutRatioTTM { get; init; }

    [JsonPropertyName("dividendYieldTTM")]
    public double? DividendYieldTTM { get; init; }

    [JsonPropertyName("enterpriseValueTTM")]
    public double? EnterpriseValueTTM { get; init; }

    [JsonPropertyName("revenuePerShareTTM")]
    public double? RevenuePerShareTTM { get; init; }

    [JsonPropertyName("netIncomePerShareTTM")]
    public double? NetIncomePerShareTTM { get; init; }

    [JsonPropertyName("interestDebtPerShareTTM")]
    public double? InterestDebtPerShareTTM { get; init; }

    [JsonPropertyName("cashPerShareTTM")]
    public double? CashPerShareTTM { get; init; }

    [JsonPropertyName("bookValuePerShareTTM")]
    public double? BookValuePerShareTTM { get; init; }

    [JsonPropertyName("tangibleBookValuePerShareTTM")]
    public double? TangibleBookValuePerShareTTM { get; init; }

    [JsonPropertyName("shareholdersEquityPerShareTTM")]
    public double? ShareholdersEquityPerShareTTM { get; init; }

    [JsonPropertyName("operatingCashFlowPerShareTTM")]
    public double? OperatingCashFlowPerShareTTM { get; init; }

    [JsonPropertyName("capexPerShareTTM")]
    public double? CapexPerShareTTM { get; init; }

    [JsonPropertyName("freeCashFlowPerShareTTM")]
    public double? FreeCashFlowPerShareTTM { get; init; }

    [JsonPropertyName("netIncomePerEBTTTM")]
    public double? NetIncomePerEBTTTM { get; init; }

    [JsonPropertyName("ebtPerEbitTTM")]
    public double? EbtPerEbitTTM { get; init; }

    [JsonPropertyName("priceToFairValueTTM")]
    public double? PriceToFairValueTTM { get; init; }

    [JsonPropertyName("debtToMarketCapTTM")]
    public double? DebtToMarketCapTTM { get; init; }

    [JsonPropertyName("effectiveTaxRateTTM")]
    public double? EffectiveTaxRateTTM { get; init; }

    [JsonPropertyName("enterpriseValueMultipleTTM")]
    public double? EnterpriseValueMultipleTTM { get; init; }
}