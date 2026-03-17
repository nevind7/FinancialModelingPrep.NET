using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public record CashFlowResponse
{
    [JsonPropertyName("date")]
    public DateOnly Date { get; init; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("reportedCurrency")]
    public string ReportedCurrency { get; init; } = string.Empty;

    [JsonPropertyName("cik")]
    public string Cik { get; init; } = string.Empty;

    [JsonPropertyName("filingDate")]
    public DateOnly FilingDate { get; init; }

    [JsonPropertyName("acceptedDate")]
    public string AcceptedDate { get; init; }

    [JsonPropertyName("fiscalYear")]
    public string FiscalYear { get; init; } = string.Empty;

    [JsonPropertyName("period")]
    public string Period { get; init; } = string.Empty;

    [JsonPropertyName("netIncome")]
    public long NetIncome { get; init; }

    [JsonPropertyName("depreciationAndAmortization")]
    public long DepreciationAndAmortization { get; init; }

    [JsonPropertyName("deferredIncomeTax")]
    public long DeferredIncomeTax { get; init; }

    [JsonPropertyName("stockBasedCompensation")]
    public long StockBasedCompensation { get; init; }

    [JsonPropertyName("changeInWorkingCapital")]
    public long ChangeInWorkingCapital { get; init; }

    [JsonPropertyName("accountsReceivables")]
    public long AccountsReceivables { get; init; }

    [JsonPropertyName("inventory")]
    public long Inventory { get; init; }

    [JsonPropertyName("accountsPayables")]
    public long AccountsPayables { get; init; }

    [JsonPropertyName("otherWorkingCapital")]
    public long OtherWorkingCapital { get; init; }

    [JsonPropertyName("otherNonCashItems")]
    public long OtherNonCashItems { get; init; }

    [JsonPropertyName("netCashProvidedByOperatingActivities")]
    public long NetCashProvidedByOperatingActivities { get; init; }

    [JsonPropertyName("investmentsInPropertyPlantAndEquipment")]
    public long InvestmentsInPropertyPlantAndEquipment { get; init; }

    [JsonPropertyName("acquisitionsNet")]
    public long AcquisitionsNet { get; init; }

    [JsonPropertyName("purchasesOfInvestments")]
    public long PurchasesOfInvestments { get; init; }

    [JsonPropertyName("salesMaturitiesOfInvestments")]
    public long SalesMaturitiesOfInvestments { get; init; }

    [JsonPropertyName("otherInvestingActivities")]
    public long OtherInvestingActivities { get; init; }

    [JsonPropertyName("netCashProvidedByInvestingActivities")]
    public long NetCashProvidedByInvestingActivities { get; init; }

    [JsonPropertyName("netDebtIssuance")]
    public long NetDebtIssuance { get; init; }

    [JsonPropertyName("longTermNetDebtIssuance")]
    public long LongTermNetDebtIssuance { get; init; }

    [JsonPropertyName("shortTermNetDebtIssuance")]
    public long ShortTermNetDebtIssuance { get; init; }

    [JsonPropertyName("netStockIssuance")]
    public long NetStockIssuance { get; init; }

    [JsonPropertyName("netCommonStockIssuance")]
    public long NetCommonStockIssuance { get; init; }

    [JsonPropertyName("commonStockIssuance")]
    public long CommonStockIssuance { get; init; }

    [JsonPropertyName("commonStockRepurchased")]
    public long CommonStockRepurchased { get; init; }

    [JsonPropertyName("netPreferredStockIssuance")]
    public long NetPreferredStockIssuance { get; init; }

    [JsonPropertyName("netDividendsPaid")]
    public long NetDividendsPaid { get; init; }

    [JsonPropertyName("commonDividendsPaid")]
    public long CommonDividendsPaid { get; init; }

    [JsonPropertyName("preferredDividendsPaid")]
    public long PreferredDividendsPaid { get; init; }

    [JsonPropertyName("otherFinancingActivities")]
    public long OtherFinancingActivities { get; init; }

    [JsonPropertyName("netCashProvidedByFinancingActivities")]
    public long NetCashProvidedByFinancingActivities { get; init; }

    [JsonPropertyName("effectOfForexChangesOnCash")]
    public long EffectOfForexChangesOnCash { get; init; }

    [JsonPropertyName("netChangeInCash")]
    public long NetChangeInCash { get; init; }

    [JsonPropertyName("cashAtEndOfPeriod")]
    public long CashAtEndOfPeriod { get; init; }

    [JsonPropertyName("cashAtBeginningOfPeriod")]
    public long CashAtBeginningOfPeriod { get; init; }

    [JsonPropertyName("operatingCashFlow")]
    public long OperatingCashFlow { get; init; }

    [JsonPropertyName("capitalExpenditure")]
    public long CapitalExpenditure { get; init; }

    [JsonPropertyName("freeCashFlow")]
    public long FreeCashFlow { get; init; }

    [JsonPropertyName("incomeTaxesPaid")]
    public long IncomeTaxesPaid { get; init; }

    [JsonPropertyName("interestPaid")]
    public long InterestPaid { get; init; }
}