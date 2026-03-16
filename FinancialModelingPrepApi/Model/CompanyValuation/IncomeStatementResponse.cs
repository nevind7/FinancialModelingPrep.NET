using System;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record IncomeStatementResponse
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
    public DateTime AcceptedDate { get; init; }

    [JsonPropertyName("fiscalYear")]
    public string FiscalYear { get; init; } = string.Empty;

    [JsonPropertyName("period")]
    public string Period { get; init; } = string.Empty;

    [JsonPropertyName("revenue")]
    public long Revenue { get; init; }

    [JsonPropertyName("costOfRevenue")]
    public long CostOfRevenue { get; init; }

    [JsonPropertyName("grossProfit")]
    public long GrossProfit { get; init; }

    [JsonPropertyName("researchAndDevelopmentExpenses")]
    public long ResearchAndDevelopmentExpenses { get; init; }

    [JsonPropertyName("generalAndAdministrativeExpenses")]
    public long GeneralAndAdministrativeExpenses { get; init; }

    [JsonPropertyName("sellingAndMarketingExpenses")]
    public long SellingAndMarketingExpenses { get; init; }

    [JsonPropertyName("sellingGeneralAndAdministrativeExpenses")]
    public long SellingGeneralAndAdministrativeExpenses { get; init; }

    [JsonPropertyName("otherExpenses")]
    public long OtherExpenses { get; init; }

    [JsonPropertyName("operatingExpenses")]
    public long OperatingExpenses { get; init; }

    [JsonPropertyName("costAndExpenses")]
    public long CostAndExpenses { get; init; }

    [JsonPropertyName("netInterestIncome")]
    public long NetInterestIncome { get; init; }

    [JsonPropertyName("interestIncome")]
    public long InterestIncome { get; init; }

    [JsonPropertyName("interestExpense")]
    public long InterestExpense { get; init; }

    [JsonPropertyName("depreciationAndAmortization")]
    public long DepreciationAndAmortization { get; init; }

    [JsonPropertyName("ebitda")]
    public long Ebitda { get; init; }

    [JsonPropertyName("ebit")]
    public long Ebit { get; init; }

    [JsonPropertyName("nonOperatingIncomeExcludingInterest")]
    public long NonOperatingIncomeExcludingInterest { get; init; }

    [JsonPropertyName("operatingIncome")]
    public long OperatingIncome { get; init; }

    [JsonPropertyName("totalOtherIncomeExpensesNet")]
    public long TotalOtherIncomeExpensesNet { get; init; }

    [JsonPropertyName("incomeBeforeTax")]
    public long IncomeBeforeTax { get; init; }

    [JsonPropertyName("incomeTaxExpense")]
    public long IncomeTaxExpense { get; init; }

    [JsonPropertyName("netIncomeFromContinuingOperations")]
    public long NetIncomeFromContinuingOperations { get; init; }

    [JsonPropertyName("netIncomeFromDiscontinuedOperations")]
    public long NetIncomeFromDiscontinuedOperations { get; init; }

    [JsonPropertyName("otherAdjustmentsToNetIncome")]
    public long OtherAdjustmentsToNetIncome { get; init; }

    [JsonPropertyName("netIncome")]
    public long NetIncome { get; init; }

    [JsonPropertyName("netIncomeDeductions")]
    public long NetIncomeDeductions { get; init; }

    [JsonPropertyName("bottomLineNetIncome")]
    public long BottomLineNetIncome { get; init; }

    [JsonPropertyName("eps")]
    public decimal Eps { get; init; }

    [JsonPropertyName("epsDiluted")]
    public decimal EpsDiluted { get; init; }

    [JsonPropertyName("weightedAverageShsOut")]
    public long WeightedAverageShsOut { get; init; }

    [JsonPropertyName("weightedAverageShsOutDil")]
    public long WeightedAverageShsOutDil { get; init; }
}