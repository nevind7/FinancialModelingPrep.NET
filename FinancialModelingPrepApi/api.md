# Financial Modeling Prep API Docs

This file is a cleaned Markdown export generated from the uploaded `api.md` source.

> Note: many endpoints in the source only included an endpoint URL and a `Parameters` heading. Where the source contained structured parameter rows and a sample response, they are preserved below.

## Company Search

### Stock Symbol Search API
Easily find the ticker symbol of any stock with the FMP Stock Symbol Search API. Search by symbol across multiple global markets.

#### Request
```http
GET https://financialmodelingprep.com/stable/search-symbol?query=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Name Search API
Search for ticker symbols, company names, and exchange details for equity securities and ETFs listed on various exchanges with the FMP Name Search API. This endpoint is useful for retrieving ticker symbols when you know the full or partial company or asset name but not the symbol identifier.

#### Request
```http
GET https://financialmodelingprep.com/stable/search-name?query=AA
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### CIK API
Easily retrieve the Central Index Key (CIK) for publicly traded companies with the FMP CIK API. Access unique identifiers needed for SEC filings and regulatory documents for a streamlined compliance and financial analysis process.

#### Request
```http
GET https://financialmodelingprep.com/stable/search-cik?cik=320193
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### CUSIP API
Easily search and retrieve financial securities information by CUSIP number using the FMP CUSIP API. Find key details such as company name, stock symbol, and market capitalization associated with the CUSIP.

#### Request
```http
GET https://financialmodelingprep.com/stable/search-cusip?cusip=037833100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ISIN API
Easily search and retrieve the International Securities Identification Number (ISIN) for financial securities using the FMP ISIN API. Find key details such as company name, stock symbol, and market capitalization associated with the ISIN.

#### Request
```http
GET https://financialmodelingprep.com/stable/search-isin?isin=US0378331005
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Screener API
Discover stocks that align with your investment strategy using the FMP Stock Screener API. Filter stocks based on market cap, price, volume, beta, sector, country, and more to identify the best opportunities.

#### Request
```http
GET https://financialmodelingprep.com/stable/company-screener
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Exchange Variants API
Search across multiple public exchanges to find where a given stock symbol is listed using the FMP Exchange Variants API. This allows users to quickly identify all the exchanges where a security is actively traded.

#### Request
```http
GET https://financialmodelingprep.com/stable/search-exchange-variants?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

## Stock Directory

### Company Symbols List API
Easily retrieve a comprehensive list of financial symbols with the FMP Company Symbols List API. Access a broad range of stock symbols and other tradable financial instruments from various global exchanges, helping you explore the full range of available securities.

#### Request
```http
GET https://financialmodelingprep.com/stable/stock-list
```

### Financial Statement Symbols List API
Access a comprehensive list of companies with available financial statements through the FMP Financial Statement Symbols List API. Find companies listed on major global exchanges and obtain up-to-date financial data including income statements, balance sheets, and cash flow statements, are provided.

#### Request
```http
GET https://financialmodelingprep.com/stable/financial-statement-symbol-list
```

### CIK List API
Access a comprehensive database of CIK (Central Index Key) numbers for SEC-registered entities with the FMP CIK List API. This endpoint is essential for businesses, financial professionals, and individuals who need quick access to CIK numbers for regulatory compliance, financial transactions, and investment research.

#### Request
```http
GET https://financialmodelingprep.com/stable/cik-list?page=0&limit=1000
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Symbol Changes List API
Stay informed about the latest stock symbol changes with the FMP Stock Symbol Changes API. Track changes due to mergers, acquisitions, stock splits, and name changes to ensure accurate trading and analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/symbol-change
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ETF Symbol Search API
Quickly find ticker symbols and company names for Exchange Traded Funds (ETFs) using the FMP ETF Symbol Search API. This tool simplifies identifying specific ETFs by their name or ticker.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf-list
```

### Actively Trading List API
List all actively trading companies and financial instruments with the FMP Actively Trading List API. This endpoint allows users to filter and display securities that are currently being traded on public exchanges, ensuring you access real-time market activity.

#### Request
```http
GET https://financialmodelingprep.com/stable/actively-trading-list
```

### Earnings Transcript List API
Access available earnings transcripts for companies with the FMP Earnings Transcript List API. Retrieve a list of companies with earnings transcripts, along with the total number of transcripts available for each company.

#### Request
```http
GET https://financialmodelingprep.com/stable/earnings-transcript-list
```

### Available Exchanges API
Access a complete list of supported stock exchanges using the FMP Available Exchanges API. This API provides a comprehensive overview of global stock exchanges, allowing users to identify where securities are traded and filter data by specific exchanges for further analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/available-exchanges
```

### Available Sectors API
Access a complete list of industry sectors using the FMP Available Sectors API. This API helps users categorize and filter companies based on their respective sectors, enabling deeper analysis and more focused queries across different industries.

#### Request
```http
GET https://financialmodelingprep.com/stable/available-sectors
```

### Available Industries API
Access a comprehensive list of industries where stock symbols are available using the FMP Available Industries API. This API helps users filter and categorize companies based on their industry for more focused research and analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/available-industries
```

### Available Countries API
Access a comprehensive list of countries where stock symbols are available with the FMP Available Countries API. This API enables users to filter and analyze stock symbols based on the country of origin or the primary market where the securities are traded.

#### Request
```http
GET https://financialmodelingprep.com/stable/available-countries
```

## Company Information

### Company Profile Data API
Access detailed company profile data with the FMP Company Profile Data API. This API provides key financial and operational information for a specific stock symbol, including the company's market capitalization, stock price, industry, and much more.

#### Request
```http
GET https://financialmodelingprep.com/stable/profile?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Profile by CIK API
Retrieve detailed company profile data by CIK (Central Index Key) with the FMP Company Profile by CIK API. This API allows users to search for companies using their unique CIK identifier and access a full range of company data, including stock price, market capitalization, industry, and much more.

#### Request
```http
GET https://financialmodelingprep.com/stable/profile-cik?cik=320193
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Notes API
Retrieve detailed information about company-issued notes with the FMP Company Notes API. Access essential data such as CIK number, stock symbol, note title, and the exchange where the notes are listed.

#### Request
```http
GET https://financialmodelingprep.com/stable/company-notes?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Peer Comparison API
Identify and compare companies within the same sector and market capitalization range using the FMP Stock Peer Comparison API. Gain insights into how a company stacks up against its peers on the same exchange.

#### Request
```http
GET https://financialmodelingprep.com/stable/stock-peers?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Delisted Companies API
Stay informed with the FMP Delisted Companies API. Access a comprehensive list of companies that have been delisted from US exchanges to avoid trading in risky stocks and identify potential financial troubles.

#### Request
```http
GET https://financialmodelingprep.com/stable/delisted-companies?page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Employee Count API
Retrieve detailed workforce information for companies, including employee count, reporting period, and filing date. The FMP Company Employee Count API also provides direct links to official SEC documents for further verification and in-depth research.

#### Request
```http
GET https://financialmodelingprep.com/stable/employee-count?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Historical Employee Count API
Access historical employee count data for a company based on specific reporting periods. The FMP Company Historical Employee Count API provides insights into how a company’s workforce has evolved over time, allowing users to analyze growth trends and operational changes.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-employee-count?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Market Cap API
Retrieve the market capitalization for a specific company on any given date using the FMP Company Market Capitalization API. This API provides essential data to assess the size and value of a company in the stock market, helping users gauge its overall market standing.

#### Request
```http
GET https://financialmodelingprep.com/stable/market-capitalization?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Batch Market Cap API
Retrieve market capitalization data for multiple companies in a single request with the FMP Batch Market Capitalization API. This API allows users to compare the market size of various companies simultaneously, streamlining the analysis of company valuations.

#### Request
```http
GET https://financialmodelingprep.com/stable/market-capitalization-batch?symbols=AAPL,AAPL,AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Market Cap API
Access historical market capitalization data for a company using the FMP Historical Market Capitalization API. This API helps track the changes in market value over time, enabling long-term assessments of a company's growth or decline.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-market-capitalization?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Share Float & Liquidity API
Understand the liquidity and volatility of a stock with the FMP Company Share Float and Liquidity API. Access the total number of publicly traded shares for any company to make informed investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/shares-float?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### All Shares Float API
Access comprehensive shares float data for all available companies with the FMP All Shares Float API. Retrieve critical information such as free float, float shares, and outstanding shares to analyze liquidity across a wide range of companies.

#### Request
```http
GET https://financialmodelingprep.com/stable/shares-float-all?page=0&limit=1000
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest Mergers & Acquisitions API
Access real-time data on the latest mergers and acquisitions with the FMP Latest Mergers and Acquisitions API. This API provides key information such as the transaction date, company names, and links to detailed filing information for further analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/mergers-acquisitions-latest?page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Search Mergers & Acquisitions API
Search for specific mergers and acquisitions data with the FMP Search Mergers and Acquisitions API. Retrieve detailed information on M&A activity, including acquiring and targeted companies, transaction dates, and links to official SEC filings.

#### Request
```http
GET https://financialmodelingprep.com/stable/mergers-acquisitions-search?name=Apple
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Executives API
Retrieve detailed information on company executives with the FMP Company Executives API. This API provides essential data about key executives, including their name, title, compensation, and other demographic details such as gender and year of birth.

#### Request
```http
GET https://financialmodelingprep.com/stable/key-executives?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Executive Compensation API
Retrieve comprehensive compensation data for company executives with the FMP Executive Compensation API. This API provides detailed information on salaries, stock awards, total compensation, and other relevant financial data, including filing details and links to official documents.

#### Request
```http
GET https://financialmodelingprep.com/stable/governance-executive-compensation?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Executive Compensation Benchmark API
Gain access to average executive compensation data across various industries with the FMP Executive Compensation Benchmark API. This API provides essential insights for comparing executive pay by industry, helping you understand compensation trends and benchmarks.

#### Request
```http
GET https://financialmodelingprep.com/stable/executive-compensation-benchmark
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

## Quote

### Stock Quote API
Access real-time stock quotes with the FMP Stock Quote API. Get up-to-the-minute prices, changes, and volume data for individual stocks.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Quote Short API
Get quick snapshots of real-time stock quotes with the FMP Stock Quote Short API. Access key stock data like current price, volume, and price changes for instant market insights.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote-short?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Aftermarket Trade API
Track real-time trading activity occurring after regular market hours with the FMP Aftermarket Trade API. Access key details such as trade prices, sizes, and timestamps for trades executed during the post-market session.

#### Request
```http
GET https://financialmodelingprep.com/stable/aftermarket-trade?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Aftermarket Quote API
Access real-time aftermarket quotes for stocks with the FMP Aftermarket Quote API. Track bid and ask prices, volume, and other relevant data outside of regular trading hours.

#### Request
```http
GET https://financialmodelingprep.com/stable/aftermarket-quote?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Price Change API
Track stock price fluctuations in real-time with the FMP Stock Price Change API. Monitor percentage and value changes over various time periods, including daily, weekly, monthly, and long-term.

#### Request
```http
GET https://financialmodelingprep.com/stable/stock-price-change?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Batch Quote API
Retrieve multiple real-time stock quotes in a single request with the FMP Stock Batch Quote API. Access current prices, volume, and detailed data for multiple companies at once, making it easier to track large portfolios or monitor multiple stocks simultaneously.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-quote?symbols=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Batch Quote Short API
Access real-time, short-form quotes for multiple stocks with the FMP Stock Batch Quote Short API. Get a quick snapshot of key stock data such as current price, change, and volume for several companies in one streamlined request.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-quote-short?symbols=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Batch Aftermarket Trade API
Retrieve real-time aftermarket trading data for multiple stocks with the FMP Batch Aftermarket Trade API. Track post-market trade prices, volumes, and timestamps across several companies simultaneously.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-aftermarket-trade?symbols=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Batch Aftermarket Quote API
Retrieve real-time aftermarket quotes for multiple stocks with the FMP Batch Aftermarket Quote API. Access bid and ask prices, volume, and other relevant data for several companies during post-market trading.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-aftermarket-quote?symbols=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Exchange Stock Quotes API
Retrieve real-time stock quotes for all listed stocks on a specific exchange with the FMP Exchange Stock Quotes API. Track price changes and trading activity across the entire exchange.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-exchange-quote?exchange=NASDAQ
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Mutual Fund Price Quotes API
Access real-time quotes for mutual funds with the FMP Mutual Fund Price Quotes API. Track current prices, performance changes, and key data for various mutual funds.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-mutualfund-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ETF Price Quotes API
Get real-time price quotes for exchange-traded funds (ETFs) with the FMP ETF Price Quotes API. Track current prices, performance changes, and key data for a wide variety of ETFs.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-etf-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Full Commodities Quotes API
Get up-to-the-minute quotes for commodities with the FMP Real-Time Commodities Quotes API. Track the latest prices, changes, and volumes for a wide range of commodities, including oil, gold, and agricultural products.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-commodity-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Full Cryptocurrency Quotes API
Access real-time cryptocurrency quotes with the FMP Full Cryptocurrency Quotes API. Track live prices, trading volumes, and price changes for a wide range of digital assets.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-crypto-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Full Forex Quote API
Retrieve real-time quotes for multiple forex currency pairs with the FMP Batch Forex Quote API. Get real-time price changes and updates for a variety of forex pairs in a single request.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-forex-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Full Index Quotes API
Track real-time movements of major stock market indexes with the FMP Stock Market Index Quotes API. Access live quotes for global indexes and monitor changes in their performance.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-index-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

## Statements

### Income Statement API
Access detailed income statement data for publicly traded companies with the Income Statements API. Track profitability, compare competitors, and identify business trends with up-to-date financial data.

#### Request
```http
GET https://financialmodelingprep.com/stable/income-statement?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"date": "2024-09-28",
"symbol": "AAPL",
"reportedCurrency": "USD",
"cik": "0000320193",
"filingDate": "2024-11-01",
"acceptedDate": "2024-11-01 06:01:36",
"fiscalYear": "2024",
"period": "FY",
"revenue": 391035000000,
"costOfRevenue": 210352000000,
"grossProfit": 180683000000,
"researchAndDevelopmentExpenses": 31370000000,
"generalAndAdministrativeExpenses": 0,
"sellingAndMarketingExpenses": 0,
"sellingGeneralAndAdministrativeExpenses": 26097000000,
"otherExpenses": 0,
"operatingExpenses": 57467000000,
"costAndExpenses": 267819000000,
"netInterestIncome": 0,
"interestIncome": 0,
"interestExpense": 0,
"depreciationAndAmortization": 11445000000,
"ebitda": 134661000000,
"ebit": 123216000000,
"nonOperatingIncomeExcludingInterest": 0,
"operatingIncome": 123216000000,
"totalOtherIncomeExpensesNet": 269000000,
"incomeBeforeTax": 123485000000,
"incomeTaxExpense": 29749000000,
"netIncomeFromContinuingOperations": 93736000000,
"netIncomeFromDiscontinuedOperations": 0,
"otherAdjustmentsToNetIncome": 0,
"netIncome": 93736000000,
"netIncomeDeductions": 0,
"bottomLineNetIncome": 93736000000,
"eps": 6.11,
"epsDiluted": 6.08,
"weightedAverageShsOut": 15343783000,
"weightedAverageShsOutDil": 15408095000
}
]
```

### Balance Sheet Statement API
Access detailed balance sheet statements for publicly traded companies with the Balance Sheet Data API. Analyze assets, liabilities, and shareholder equity to gain insights into a company's financial health.

#### Request
```http
GET https://financialmodelingprep.com/stable/balance-sheet-statement?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"date": "2024-09-28",
"symbol": "AAPL",
"reportedCurrency": "USD",
"cik": "0000320193",
"filingDate": "2024-11-01",
"acceptedDate": "2024-11-01 06:01:36",
"fiscalYear": "2024",
"period": "FY",
"cashAndCashEquivalents": 29943000000,
"shortTermInvestments": 35228000000,
"cashAndShortTermInvestments": 65171000000,
"netReceivables": 66243000000,
"accountsReceivables": 33410000000,
"otherReceivables": 32833000000,
"inventory": 7286000000,
"prepaids": 0,
"otherCurrentAssets": 14287000000,
"totalCurrentAssets": 152987000000,
"propertyPlantEquipmentNet": 45680000000,
"goodwill": 0,
"intangibleAssets": 0,
"goodwillAndIntangibleAssets": 0,
"longTermInvestments": 91479000000,
"taxAssets": 19499000000,
"otherNonCurrentAssets": 55335000000,
"totalNonCurrentAssets": 211993000000,
"otherAssets": 0,
"totalAssets": 364980000000,
"totalPayables": 95561000000,
"accountPayables": 68960000000,
"otherPayables": 26601000000,
"accruedExpenses": 0,
"shortTermDebt": 20879000000,
"capitalLeaseObligationsCurrent": 1632000000,
"taxPayables": 26601000000,
"deferredRevenue": 8249000000,
"otherCurrentLiabilities": 50071000000,
"totalCurrentLiabilities": 176392000000,
"longTermDebt": 85750000000,
"deferredRevenueNonCurrent": 10798000000,
"deferredTaxLiabilitiesNonCurrent": 0,
"otherNonCurrentLiabilities": 35090000000,
"totalNonCurrentLiabilities": 131638000000,
"otherLiabilities": 0,
"capitalLeaseObligations": 12430000000,
"totalLiabilities": 308030000000,
"treasuryStock": 0,
"preferredStock": 0,
"commonStock": 83276000000,
"retainedEarnings": -19154000000,
"additionalPaidInCapital": 0,
"accumulatedOtherComprehensiveIncomeLoss": -7172000000,
"otherTotalStockholdersEquity": 0,
"totalStockholdersEquity": 56950000000,
"totalEquity": 56950000000,
"minorityInterest": 0,
"totalLiabilitiesAndTotalEquity": 364980000000,
"totalInvestments": 126707000000,
"totalDebt": 106629000000,
"netDebt": 76686000000
}
]
```

### Cash Flow Statement API
Gain insights into a company's cash flow activities with the Cash Flow Statements API. Analyze cash generated and used from operations, investments, and financing activities to evaluate the financial health and sustainability of a business.

#### Request
```http
GET https://financialmodelingprep.com/stable/cash-flow-statement?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"date": "2024-09-28",
"symbol": "AAPL",
"reportedCurrency": "USD",
"cik": "0000320193",
"filingDate": "2024-11-01",
"acceptedDate": "2024-11-01 06:01:36",
"fiscalYear": "2024",
"period": "FY",
"netIncome": 93736000000,
"depreciationAndAmortization": 11445000000,
"deferredIncomeTax": 0,
"stockBasedCompensation": 11688000000,
"changeInWorkingCapital": 3651000000,
"accountsReceivables": -5144000000,
"inventory": -1046000000,
"accountsPayables": 6020000000,
"otherWorkingCapital": 3821000000,
"otherNonCashItems": -2266000000,
"netCashProvidedByOperatingActivities": 118254000000,
"investmentsInPropertyPlantAndEquipment": -9447000000,
"acquisitionsNet": 0,
"purchasesOfInvestments": -48656000000,
"salesMaturitiesOfInvestments": 62346000000,
"otherInvestingActivities": -1308000000,
"netCashProvidedByInvestingActivities": 2935000000,
"netDebtIssuance": -5998000000,
"longTermNetDebtIssuance": -9958000000,
"shortTermNetDebtIssuance": 3960000000,
"netStockIssuance": -94949000000,
"netCommonStockIssuance": -94949000000,
"commonStockIssuance": 0,
"commonStockRepurchased": -94949000000,
"netPreferredStockIssuance": 0,
"netDividendsPaid": -15234000000,
"commonDividendsPaid": -15234000000,
"preferredDividendsPaid": 0,
"otherFinancingActivities": -5802000000,
"netCashProvidedByFinancingActivities": -121983000000,
"effectOfForexChangesOnCash": 0,
"netChangeInCash": -794000000,
"cashAtEndOfPeriod": 29943000000,
"cashAtBeginningOfPeriod": 30737000000,
"operatingCashFlow": 118254000000,
"capitalExpenditure": -9447000000,
"freeCashFlow": 108807000000,
"incomeTaxesPaid": 26102000000,
"interestPaid": 0
}
]
```

### Latest Financial Statements API
#### Request
```http
GET https://financialmodelingprep.com/stable/latest-financial-statements?page=0&limit=250
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `page` | `number` | `0` |
| `limit` | `number` | `250` |

> (*) Required | Maximum 250 records per request | Page maxed at 100 | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "FGFI",
"calendarYear": 2024,
"period": "Q4",
"date": "2024-12-31",
"dateAdded": "2025-03-13 17:03:59"
}
]
```

### Income Statements TTM API
#### Request
```http
GET https://financialmodelingprep.com/stable/income-statement-ttm?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"date": "2024-12-28",
"symbol": "AAPL",
"reportedCurrency": "USD",
"cik": "0000320193",
"filingDate": "2025-01-31",
"acceptedDate": "2025-01-31 06:01:27",
"fiscalYear": "2025",
"period": "Q1",
"revenue": 395760000000,
"costOfRevenue": 211657000000,
"grossProfit": 184103000000,
"researchAndDevelopmentExpenses": 31942000000,
"generalAndAdministrativeExpenses": 0,
"sellingAndMarketingExpenses": 0,
"sellingGeneralAndAdministrativeExpenses": 26486000000,
"otherExpenses": 0,
"operatingExpenses": 58428000000,
"costAndExpenses": 270085000000,
"netInterestIncome": 0,
"interestIncome": 0,
"interestExpense": 0,
"depreciationAndAmortization": 11677000000,
"ebitda": 137352000000,
"ebit": 125675000000,
"nonOperatingIncomeExcludingInterest": 0,
"operatingIncome": 125675000000,
"totalOtherIncomeExpensesNet": 71000000,
"incomeBeforeTax": 125746000000,
"incomeTaxExpense": 29596000000,
"netIncomeFromContinuingOperations": 96150000000,
"netIncomeFromDiscontinuedOperations": 0,
"otherAdjustmentsToNetIncome": 0,
"netIncome": 96150000000,
"netIncomeDeductions": 0,
"bottomLineNetIncome": 96150000000,
"eps": 6.31,
"epsDiluted": 6.3,
"weightedAverageShsOut": 15081724000,
"weightedAverageShsOutDil": 15150865000
}
]
```

### Balance Sheet Statements TTM API
#### Request
```http
GET https://financialmodelingprep.com/stable/balance-sheet-statement-ttm?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"date": "2024-12-28",
"symbol": "AAPL",
"reportedCurrency": "USD",
"cik": "0000320193",
"filingDate": "2025-01-31",
"acceptedDate": "2025-01-31 06:01:27",
"fiscalYear": "2025",
"period": "Q1",
"cashAndCashEquivalents": 30299000000,
"shortTermInvestments": 23476000000,
"cashAndShortTermInvestments": 53775000000,
"netReceivables": 59306000000,
"accountsReceivables": 29639000000,
"otherReceivables": 29667000000,
"inventory": 6911000000,
"prepaids": 0,
"otherCurrentAssets": 13248000000,
"totalCurrentAssets": 133240000000,
"propertyPlantEquipmentNet": 46069000000,
"goodwill": 0,
"intangibleAssets": 0,
"goodwillAndIntangibleAssets": 0,
"longTermInvestments": 87593000000,
"taxAssets": 0,
"otherNonCurrentAssets": 77183000000,
"totalNonCurrentAssets": 210845000000,
"otherAssets": 0,
"totalAssets": 344085000000,
"totalPayables": 61910000000,
"accountPayables": 61910000000,
"otherPayables": 0,
"accruedExpenses": 0,
"shortTermDebt": 12843000000,
"capitalLeaseObligationsCurrent": 0,
"taxPayables": 0,
"deferredRevenue": 8461000000,
"otherCurrentLiabilities": 61151000000,
"totalCurrentLiabilities": 144365000000,
"longTermDebt": 83956000000,
"deferredRevenueNonCurrent": 0,
"deferredTaxLiabilitiesNonCurrent": 0,
"otherNonCurrentLiabilities": 49006000000,
"totalNonCurrentLiabilities": 132962000000,
"otherLiabilities": 0,
"capitalLeaseObligations": 0,
"totalLiabilities": 277327000000,
"treasuryStock": 0,
"preferredStock": 0,
"commonStock": 84768000000,
"retainedEarnings": -11221000000,
"additionalPaidInCapital": 0,
"accumulatedOtherComprehensiveIncomeLoss": -6789000000,
"otherTotalStockholdersEquity": 0,
"totalStockholdersEquity": 66758000000,
"totalEquity": 66758000000,
"minorityInterest": 0,
"totalLiabilitiesAndTotalEquity": 344085000000,
"totalInvestments": 111069000000,
"totalDebt": 96799000000,
"netDebt": 66500000000
}
]
```

### Cashflow Statements TTM API
#### Request
```http
GET https://financialmodelingprep.com/stable/cash-flow-statement-ttm?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"date": "2024-12-28",
"symbol": "AAPL",
"reportedCurrency": "USD",
"cik": "0000320193",
"filingDate": "2025-01-31",
"acceptedDate": "2025-01-31 06:01:27",
"fiscalYear": "2025",
"period": "Q1",
"netIncome": 96150000000,
"depreciationAndAmortization": 11677000000,
"deferredIncomeTax": 0,
"stockBasedCompensation": 11977000000,
"changeInWorkingCapital": -8224000000,
"accountsReceivables": -9505000000,
"inventory": -694000000,
"accountsPayables": 3891000000,
"otherWorkingCapital": -1916000000,
"otherNonCashItems": -3286000000,
"netCashProvidedByOperatingActivities": 108294000000,
"investmentsInPropertyPlantAndEquipment": -9995000000,
"acquisitionsNet": 0,
"purchasesOfInvestments": -45000000000,
"salesMaturitiesOfInvestments": 67422000000,
"otherInvestingActivities": -1627000000,
"netCashProvidedByInvestingActivities": 10800000000,
"netDebtIssuance": -10967000000,
"longTermNetDebtIssuance": -10967000000,
"shortTermNetDebtIssuance": 0,
"netStockIssuance": -98416000000,
"netCommonStockIssuance": -98416000000,
"commonStockIssuance": 0,
"commonStockRepurchased": -98416000000,
"netPreferredStockIssuance": 0,
"netDividendsPaid": -15265000000,
"commonDividendsPaid": -15265000000,
"preferredDividendsPaid": 0,
"otherFinancingActivities": -6121000000,
"netCashProvidedByFinancingActivities": -130769000000,
"effectOfForexChangesOnCash": 0,
"netChangeInCash": -11675000000,
"cashAtEndOfPeriod": 30299000000,
"cashAtBeginningOfPeriod": 41974000000,
"operatingCashFlow": 108294000000,
"capitalExpenditure": -9995000000,
"freeCashFlow": 98299000000,
"incomeTaxesPaid": 37498000000,
"interestPaid": 0
}
]
```

### Key Metrics API
Access essential financial metrics for a company with the FMP Financial Key Metrics API. Evaluate revenue, net income, P/E ratio, and more to assess performance and compare it to competitors.

#### Request
```http
GET https://financialmodelingprep.com/stable/key-metrics?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"fiscalYear": "2024",
"period": "FY",
"reportedCurrency": "USD",
"marketCap": 3495160329570,
"enterpriseValue": 3571846329570,
"evToSales": 9.134339201273542,
"evToOperatingCashFlow": 30.204866893043786,
"evToFreeCashFlow": 32.82735788662494,
"evToEBITDA": 26.524727497716487,
"netDebtToEBITDA": 0.5694744580836323,
"currentRatio": 0.8673125765340832,
"incomeQuality": 1.2615643936161134,
"grahamNumber": 22.587017267616833,
"grahamNetNet": -12.352478525015636,
"taxBurden": 0.7590881483581001,
"interestBurden": 1.0021831580314244,
"workingCapital": -23405000000,
"investedCapital": 22275000000,
"returnOnAssets": 0.25682503150857583,
"operatingReturnOnAssets": 0.3434290787011036,
"returnOnTangibleAssets": 0.25682503150857583,
"returnOnEquity": 1.6459350307287095,
"returnOnInvestedCapital": 0.4430708117427921,
"returnOnCapitalEmployed": 0.6533607652660827,
"earningsYield": 0.026818798327209237,
"freeCashFlowYield": 0.03113076074921754,
"capexToOperatingCashFlow": 0.07988736110406414,
"capexToDepreciation": 0.8254259501965924,
"capexToRevenue": 0.02415896275269477,
"salesGeneralAndAdministrativeToRevenue": 0,
"researchAndDevelopementToRevenue": 0.08022299794136074,
"stockBasedCompensationToRevenue": 0.02988990755303234,
"intangiblesToTotalAssets": 0,
"averageReceivables": 63614000000,
"averagePayables": 65785500000,
"averageInventory": 6808500000,
"daysOfSalesOutstanding": 61.83255974529134,
"daysOfPayablesOutstanding": 119.65847721913745,
"daysOfInventoryOutstanding": 12.642570548414087,
"operatingCycle": 74.47513029370543,
"cashConversionCycle": -45.18334692543202,
"freeCashFlowToEquity": 32121000000,
"freeCashFlowToFirm": 117192805288.09166,
"tangibleAssetValue": 56950000000,
"netCurrentAssetValue": -155043000000
}
]
```

### Financial Ratios API
Analyze a company's financial performance using the Financial Ratios API. This API provides detailed profitability, liquidity, and efficiency ratios, enabling users to assess a company's operational and financial health across various metrics.

#### Request
```http
GET https://financialmodelingprep.com/stable/ratios?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"fiscalYear": "2024",
"period": "FY",
"reportedCurrency": "USD",
"grossProfitMargin": 0.4620634981523393,
"ebitMargin": 0.31510222870075566,
"ebitdaMargin": 0.3443707085043538,
"operatingProfitMargin": 0.31510222870075566,
"pretaxProfitMargin": 0.3157901466620635,
"continuousOperationsProfitMargin": 0.23971255769943867,
"netProfitMargin": 0.23971255769943867,
"bottomLineProfitMargin": 0.23971255769943867,
"receivablesTurnover": 5.903038811648023,
"payablesTurnover": 3.0503480278422272,
"inventoryTurnover": 28.870710952511665,
"fixedAssetTurnover": 8.560310858143607,
"assetTurnover": 1.0713874732862074,
"currentRatio": 0.8673125765340832,
"quickRatio": 0.8260068483831466,
"solvencyRatio": 0.3414634938155374,
"cashRatio": 0.16975259648963673,
"priceToEarningsRatio": 37.287278415656736,
"priceToEarningsGrowthRatio": -45.93792700808932,
"forwardPriceToEarningsGrowthRatio": -45.93792700808932,
"priceToBookRatio": 61.37243774486391,
"priceToSalesRatio": 8.93822887866815,
"priceToFreeCashFlowRatio": 32.12256867269569,
"priceToOperatingCashFlowRatio": 29.55638142954995,
"debtToAssetsRatio": 0.29215025480848267,
"debtToEquityRatio": 1.872326602282704,
"debtToCapitalRatio": 0.6518501763673821,
"longTermDebtToCapitalRatio": 0.6009110021023125,
"financialLeverageRatio": 6.408779631255487,
"workingCapitalTurnoverRatio": -31.099932397502684,
"operatingCashFlowRatio": 0.6704045534944896,
"operatingCashFlowSalesRatio": 0.3024128274962599,
"freeCashFlowOperatingCashFlowRatio": 0.9201126388959359,
"debtServiceCoverageRatio": 5.024761722304708,
"interestCoverageRatio": 0,
"shortTermOperatingCashFlowCoverageRatio": 5.663777000814215,
"operatingCashFlowCoverageRatio": 1.109022873702276,
"capitalExpenditureCoverageRatio": 12.517624642743728,
"dividendPaidAndCapexCoverageRatio": 4.7912969490701345,
"dividendPayoutRatio": 0.16252026969360758,
"dividendYield": 0.0043585983369965175,
"dividendYieldPercentage": 0.43585983369965176,
"revenuePerShare": 25.484914639368924,
"netIncomePerShare": 6.109054070954992,
"interestDebtPerShare": 6.949329249507765,
"cashPerShare": 4.247388013764271,
"bookValuePerShare": 3.711600978715614,
"tangibleBookValuePerShare": 3.711600978715614,
"shareholdersEquityPerShare": 3.711600978715614,
"operatingCashFlowPerShare": 7.706965094592383,
"capexPerShare": 0.6156891035281195,
"freeCashFlowPerShare": 7.091275991064264,
"netIncomePerEBT": 0.7590881483581001,
"ebtPerEbit": 1.0021831580314244,
"priceToFairValue": 61.37243774486391,
"debtToMarketCap": 0.03050761336980449,
"effectiveTaxRate": 0.24091185164189982,
"enterpriseValueMultiple": 26.524727497716487
}
]
```

### Key Metrics TTM API
Retrieve a comprehensive set of trailing twelve-month (TTM) key performance metrics with the TTM Key Metrics API. Access data related to a company's profitability, capital efficiency, and liquidity, allowing for detailed analysis of its financial health over the past year.

#### Request
```http
GET https://financialmodelingprep.com/stable/key-metrics-ttm?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |

> (*) Required | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"marketCap": 3149833928000,
"enterpriseValueTTM": 3216333928000,
"evToSalesTTM": 8.126980816656559,
"evToOperatingCashFlowTTM": 29.70001965021146,
"evToFreeCashFlowTTM": 32.71990486169747,
"evToEBITDATTM": 23.41672438697653,
"netDebtToEBITDATTM": 0.48415749315627005,
"currentRatioTTM": 0.9229383853427077,
"incomeQualityTTM": 1.1263026521060842,
"grahamNumberTTM": 25.198029099282905,
"grahamNetNetTTM": -11.64435843011051,
"taxBurdenTTM": 0.7646366484818603,
"interestBurdenTTM": 1.0005649492739208,
"workingCapitalTTM": -11125000000,
"investedCapitalTTM": 34944000000,
"returnOnAssetsTTM": 0.27943676707790227,
"operatingReturnOnAssetsTTM": 0.35448090090471257,
"returnOnTangibleAssetsTTM": 0.27943676707790227,
"returnOnEquityTTM": 1.4534598087751787,
"returnOnInvestedCapitalTTM": 0.45208108089346594,
"returnOnCapitalEmployedTTM": 0.6292559583416784,
"earningsYieldTTM": 0.030404739849149914,
"freeCashFlowYieldTTM": 0.03120767705439485,
"capexToOperatingCashFlowTTM": 0.09229504866382256,
"capexToDepreciationTTM": 0.855956153121521,
"capexToRevenueTTM": 0.025255205174853447,
"salesGeneralAndAdministrativeToRevenueTTM": 0,
"researchAndDevelopementToRevenueTTM": 0.08071053163533455,
"stockBasedCompensationToRevenueTTM": 0.030263290883363655,
"intangiblesToTotalAssetsTTM": 0,
"averageReceivablesTTM": 62774500000,
"averagePayablesTTM": 65435000000,
"averageInventoryTTM": 7098500000,
"daysOfSalesOutstandingTTM": 54.69650798463715,
"daysOfPayablesOutstandingTTM": 106.76306476988712,
"daysOfInventoryOutstandingTTM": 11.917937984569374,
"operatingCycleTTM": 66.61444596920653,
"cashConversionCycleTTM": -40.148618800680595,
"freeCashFlowToEquityTTM": 31799000000,
"freeCashFlowToFirmTTM": 85497710797.9578,
"tangibleAssetValueTTM": 66758000000,
"netCurrentAssetValueTTM": -144087000000
}
]
```

### Financial Ratios TTM API
Gain access to trailing twelve-month (TTM) financial ratios with the TTM Ratios API. This API provides key performance metrics over the past year, including profitability, liquidity, and efficiency ratios.

#### Request
```http
GET https://financialmodelingprep.com/stable/ratios-ttm?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |

> (*) Required | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"grossProfitMarginTTM": 0.46518849807964424,
"ebitMarginTTM": 0.3175535678188801,
"ebitdaMarginTTM": 0.34705882352941175,
"operatingProfitMarginTTM": 0.3175535678188801,
"pretaxProfitMarginTTM": 0.31773296947645036,
"continuousOperationsProfitMarginTTM": 0.24295027289266222,
"netProfitMarginTTM": 0.24295027289266222,
"bottomLineProfitMarginTTM": 0.24295027289266222,
"receivablesTurnoverTTM": 6.673186524129093,
"payablesTurnoverTTM": 3.4187853335486995,
"inventoryTurnoverTTM": 30.626103313558097,
"fixedAssetTurnoverTTM": 8.590592372311098,
"assetTurnoverTTM": 1.1501809145995903,
"currentRatioTTM": 0.9229383853427077,
"quickRatioTTM": 0.8750666712845911,
"solvencyRatioTTM": 0.3888081578786054,
"cashRatioTTM": 0.20987774044955496,
"priceToEarningsRatioTTM": 32.889608822880916,
"priceToEarningsGrowthRatioTTM": 9.104441715061135,
"forwardPriceToEarningsGrowthRatioTTM": 9.104441715061135,
"priceToBookRatioTTM": 47.370141231313106,
"priceToSalesRatioTTM": 7.958949686678795,
"priceToFreeCashFlowRatioTTM": 32.04339747098139,
"priceToOperatingCashFlowRatioTTM": 29.201395167968677,
"debtToAssetsRatioTTM": 0.28132292892744526,
"debtToEquityRatioTTM": 1.4499985020521886,
"debtToCapitalRatioTTM": 0.5918364851397372,
"longTermDebtToCapitalRatioTTM": 0.557055084464615,
"financialLeverageRatioTTM": 5.154213727193745,
"workingCapitalTurnoverRatioTTM": -22.92267593397046,
"operatingCashFlowRatioTTM": 0.7501402694558931,
"operatingCashFlowSalesRatioTTM": 0.2736355366889024,
"freeCashFlowOperatingCashFlowRatioTTM": 0.9077049513361775,
"debtServiceCoverageRatioTTM": 8.390251498870981,
"interestCoverageRatioTTM": 0,
"shortTermOperatingCashFlowCoverageRatioTTM": 8.432142022891847,
"operatingCashFlowCoverageRatioTTM": 1.1187512267688715,
"capitalExpenditureCoverageRatioTTM": 10.834817408704351,
"dividendPaidAndCapexCoverageRatioTTM": 4.287173396674584,
"dividendPayoutRatioTTM": 0.15876235049401977,
"dividendYieldTTM": 0.0047691720717283476,
"enterpriseValueTTM": 3216333928000,
"revenuePerShareTTM": 26.24103186081379,
"netIncomePerShareTTM": 6.375265851569754,
"interestDebtPerShareTTM": 6.418298067250137,
"cashPerShareTTM": 3.565573803101025,
"bookValuePerShareTTM": 4.426417032959892,
"tangibleBookValuePerShareTTM": 4.426417032959892,
"shareholdersEquityPerShareTTM": 4.426417032959892,
"operatingCashFlowPerShareTTM": 7.180478836504368,
"capexPerShareTTM": 0.6627226436447186,
"freeCashFlowPerShareTTM": 6.5177561928596495,
"netIncomePerEBTTTM": 0.7646366484818603,
"ebtPerEbitTTM": 1.0005649492739208,
"priceToFairValueTTM": 47.370141231313106,
"debtToMarketCapTTM": 0.030731461471514124,
"effectiveTaxRateTTM": 0.23536335151813975,
"enterpriseValueMultipleTTM": 23.41672438697653
}
]
```

### Financial Scores API
Assess a company's financial strength using the Financial Health Scores API. This API provides key metrics such as the Altman Z-Score and Piotroski Score, giving users insights into a company’s overall financial health and stability.

#### Request
```http
GET https://financialmodelingprep.com/stable/financial-scores?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |

> (*) Required | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"reportedCurrency": "USD",
"altmanZScore": 9.322985825443649,
"piotroskiScore": 8,
"workingCapital": -11125000000,
"totalAssets": 344085000000,
"retainedEarnings": -11221000000,
"ebit": 125675000000,
"marketCap": 3259495258000,
"totalLiabilities": 277327000000,
"revenue": 395760000000
}
]
```

### Owner Earnings API
Retrieve a company's owner earnings with the Owner Earnings API, which provides a more accurate representation of cash available to shareholders by adjusting net income. This metric is crucial for evaluating a company’s profitability from the perspective of investors.

#### Request
```http
GET https://financialmodelingprep.com/stable/owner-earnings?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |

> (*) Required | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"reportedCurrency": "USD",
"fiscalYear": "2025",
"period": "Q1",
"date": "2024-12-28",
"averagePPE": 0.13969,
"maintenanceCapex": -2279964750,
"ownersEarnings": 27655035250,
"growthCapex": -660035250,
"ownersEarningsPerShare": 1.83
}
]
```

### Enterprise Values API
Access a company's enterprise value using the Enterprise Values API. This metric offers a comprehensive view of a company's total market value by combining both its equity (market capitalization) and debt, providing a better understanding of its worth.

#### Request
```http
GET https://financialmodelingprep.com/stable/enterprise-values?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"stockPrice": 227.79,
"numberOfShares": 15343783000,
"marketCapitalization": 3495160329570,
"minusCashAndCashEquivalents": 29943000000,
"addTotalDebt": 106629000000,
"enterpriseValue": 3571846329570
}
]
```

### Income Statement Growth API
Track key financial growth metrics with the Income Statement Growth API. Analyze how revenue, profits, and expenses have evolved over time, offering insights into a company’s financial health and operational efficiency.

#### Request
```http
GET https://financialmodelingprep.com/stable/income-statement-growth?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"fiscalYear": "2024",
"period": "FY",
"reportedCurrency": "USD",
"growthRevenue": 0.020219940775141214,
"growthCostOfRevenue": -0.017675600199872046,
"growthGrossProfit": 0.06819471705252206,
"growthGrossProfitRatio": 0.04776303446712012,
"growthResearchAndDevelopmentExpenses": 0.04863780712017383,
"growthGeneralAndAdministrativeExpenses": 0,
"growthSellingAndMarketingExpenses": 0,
"growthOtherExpenses": -1,
"growthOperatingExpenses": 0.04776924900176856,
"growthCostAndExpenses": -0.004331112631234571,
"growthInterestIncome": -1,
"growthInterestExpense": -1,
"growthDepreciationAndAmortization": -0.006424168764649709,
"growthEBITDA": 0.07026704816404387,
"growthOperatingIncome": 0.07799581805933456,
"growthIncomeBeforeTax": 0.08571604417246959,
"growthIncomeTaxExpense": 0.7770145152619318,
"growthNetIncome": -0.033599670086086914,
"growthEPS": -0.008116883116883088,
"growthEPSDiluted": -0.008156606851549727,
"growthWeightedAverageShsOut": -0.02543458616683152,
"growthWeightedAverageShsOutDil": -0.02557791606880283,
"growthEBIT": 0.0471407082579099,
"growthNonOperatingIncomeExcludingInterest": 1,
"growthNetInterestIncome": 1,
"growthTotalOtherIncomeExpensesNet": 1.4761061946902654,
"growthNetIncomeFromContinuingOperations": -0.033599670086086914,
"growthOtherAdjustmentsToNetIncome": 0,
"growthNetIncomeDeductions": 0
}
]
```

### Balance Sheet Statement Growth API
Analyze the growth of key balance sheet items over time with the Balance Sheet Statement Growth API. Track changes in assets, liabilities, and equity to understand the financial evolution of a company.

#### Request
```http
GET https://financialmodelingprep.com/stable/balance-sheet-statement-growth?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"fiscalYear": "2024",
"period": "FY",
"reportedCurrency": "USD",
"growthCashAndCashEquivalents": -0.0007341898882029034,
"growthShortTermInvestments": 0.11516302627413738,
"growthCashAndShortTermInvestments": 0.058744212492892536,
"growthNetReceivables": 0.08621792243994425,
"growthInventory": 0.15084504817564365,
"growthOtherCurrentAssets": -0.02776454576386526,
"growthTotalCurrentAssets": 0.06562138667929733,
"growthPropertyPlantEquipmentNet": -0.15992349565984992,
"growthGoodwill": 0,
"growthIntangibleAssets": 0,
"growthGoodwillAndIntangibleAssets": 0,
"growthLongTermInvestments": -0.09015953214513049,
"growthTaxAssets": 0.09225857046829487,
"growthOtherNonCurrentAssets": 0.5266933370120016,
"growthTotalNonCurrentAssets": 0.014238076328719674,
"growthOtherAssets": 0,
"growthTotalAssets": 0.035160515396374756,
"growthAccountPayables": 0.1014039066617687,
"growthShortTermDebt": 0.32087050041121024,
"growthTaxPayables": 2.01632838190271,
"growthDeferredRevenue": 0.023322168465450935,
"growthOtherCurrentLiabilities": -0.1254584832500786,
"growthTotalCurrentLiabilities": 0.21391802240757563,
"growthLongTermDebt": -0.10003043628845205,
"growthDeferredRevenueNonCurrent": 0,
"growthDeferredTaxLiabilitiesNonCurrent": 0,
"growthOtherNonCurrentLiabilities": -0.09048495373370312,
"growthTotalNonCurrentLiabilities": -0.09295867814151548,
"growthOtherLiabilities": 0,
"growthTotalLiabilities": 0.060574238130816666,
"growthPreferredStock": 0,
"growthCommonStock": 0.12821763398905328,
"growthRetainedEarnings": -88.50467289719626,
"growthAccumulatedOtherComprehensiveIncomeLoss": 0.3737338456164862,
"growthOthertotalStockholdersEquity": 0,
"growthTotalStockholdersEquity": -0.0836095645737457,
"growthMinorityInterest": 0,
"growthTotalEquity": -0.0836095645737457,
"growthTotalLiabilitiesAndStockholdersEquity": 0.035160515396374756,
"growthTotalInvestments": -0.04107194211936368,
"growthTotalDebt": -0.0401393489845888,
"growthNetDebt": -0.05469472282829777,
"growthAccountsReceivables": 0.13223532601328453,
"growthOtherReceivables": 0.04307907360930203,
"growthPrepaids": 0,
"growthTotalPayables": 0.5262653527335452,
"growthOtherPayables": 0,
"growthAccruedExpenses": 0,
"growthCapitalLeaseObligationsCurrent": 0.03619047619047619,
"growthAdditionalPaidInCapital": 0,
"growthTreasuryStock": 0
}
]
```

### Cashflow Statement Growth API
Measure the growth rate of a company’s cash flow with the FMP Cashflow Statement Growth API. Determine how quickly a company’s cash flow is increasing or decreasing over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/cash-flow-statement-growth?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"fiscalYear": "2024",
"period": "FY",
"reportedCurrency": "USD",
"growthNetIncome": -0.033599670086086914,
"growthDepreciationAndAmortization": -0.006424168764649709,
"growthDeferredIncomeTax": 0,
"growthStockBasedCompensation": 0.07892550540016616,
"growthChangeInWorkingCapital": 1.555116314429071,
"growthAccountsReceivables": -2.0473933649289098,
"growthInventory": 0.3535228677379481,
"growthAccountsPayables": 4.1868713605082055,
"growthOtherWorkingCapital": 2.4402563136072373,
"growthOtherNonCashItems": -0.017512348450830714,
"growthNetCashProvidedByOperatingActivites": 0.06975566069312394,
"growthInvestmentsInPropertyPlantAndEquipment": 0.13796879277306323,
"growthAcquisitionsNet": 0,
"growthPurchasesOfInvestments": -0.6486294175448107,
"growthSalesMaturitiesOfInvestments": 0.3698202750801951,
"growthOtherInvestingActivites": 0.02169035153328347,
"growthNetCashUsedForInvestingActivites": -0.2078272604588394,
"growthDebtRepayment": -0.012662502110417018,
"growthCommonStockIssued": 0,
"growthCommonStockRepurchased": -0.2243584784010316,
"growthDividendsPaid": -0.013910149750415973,
"growthOtherFinancingActivites": 0.03493013972055888,
"growthNetCashUsedProvidedByFinancingActivities": -0.12439163778482412,
"growthEffectOfForexChangesOnCash": 0,
"growthNetChangeInCash": -1.1378472222222222,
"growthCashAtEndOfPeriod": -0.02583205908188828,
"growthCashAtBeginningOfPeriod": 0.23061216319013492,
"growthOperatingCashFlow": 0.06975566069312394,
"growthCapitalExpenditure": 0.13796879277306323,
"growthFreeCashFlow": 0.092615279562982,
"growthNetDebtIssuance": 0.3942026057973942,
"growthLongTermNetDebtIssuance": -0.6812426135404356,
"growthShortTermNetDebtIssuance": 1.995475113122172,
"growthNetStockIssuance": -0.2243584784010316,
"growthPreferredDividendsPaid": -0.013910149750415973,
"growthIncomeTaxesPaid": 0.3973981476524439,
"growthInterestPaid": -1
}
]
```

### Financial Statement Growth API
Analyze the growth of key financial statement items across income, balance sheet, and cash flow statements with the Financial Statement Growth API. Track changes over time to understand trends in financial performance.

#### Request
```http
GET https://financialmodelingprep.com/stable/financial-growth?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `Q1,Q2,Q3,Q4,FY,annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"date": "2024-09-28",
"fiscalYear": "2024",
"period": "FY",
"reportedCurrency": "USD",
"revenueGrowth": 0.020219940775141214,
"grossProfitGrowth": 0.06819471705252206,
"ebitgrowth": 0.07799581805933456,
"operatingIncomeGrowth": 0.07799581805933456,
"netIncomeGrowth": -0.033599670086086914,
"epsgrowth": -0.008116883116883088,
"epsdilutedGrowth": -0.008156606851549727,
"weightedAverageSharesGrowth": -0.02543458616683152,
"weightedAverageSharesDilutedGrowth": -0.02557791606880283,
"dividendsPerShareGrowth": 0.040371570095532654,
"operatingCashFlowGrowth": 0.06975566069312394,
"receivablesGrowth": 0.08621792243994425,
"inventoryGrowth": 0.15084504817564365,
"assetGrowth": 0.035160515396374756,
"bookValueperShareGrowth": -0.059693251557224776,
"debtGrowth": -0.0401393489845888,
"rdexpenseGrowth": 0.04863780712017383,
"sgaexpensesGrowth": 0.04672709770575967,
"freeCashFlowGrowth": 0.092615279562982,
"tenYRevenueGrowthPerShare": 2.3937532854122625,
"fiveYRevenueGrowthPerShare": 0.8093292228858464,
"threeYRevenueGrowthPerShare": 0.163506592883552,
"tenYOperatingCFGrowthPerShare": 2.1417809176982403,
"fiveYOperatingCFGrowthPerShare": 1.051533221923415,
"threeYOperatingCFGrowthPerShare": 0.23720294833900227,
"tenYNetIncomeGrowthPerShare": 2.76381558093543,
"fiveYNetIncomeGrowthPerShare": 1.0421744314966246,
"threeYNetIncomeGrowthPerShare": 0.07761907162786884,
"tenYShareholdersEquityGrowthPerShare": -0.19003774225234785,
"fiveYShareholdersEquityGrowthPerShare": -0.24235004889283715,
"threeYShareholdersEquityGrowthPerShare": -0.017459858915902907,
"tenYDividendperShareGrowthPerShare": 1.1722201809466772,
"fiveYDividendperShareGrowthPerShare": 0.29890046876764864,
"threeYDividendperShareGrowthPerShare": 0.14617932692103452,
"ebitdaGrowth": null,
"growthCapitalExpenditure": null,
"tenYBottomLineNetIncomeGrowthPerShare": null,
"fiveYBottomLineNetIncomeGrowthPerShare": null,
"threeYBottomLineNetIncomeGrowthPerShare": null
}
]
```

### Financial Reports Dates API
#### Request
```http
GET https://financialmodelingprep.com/stable/financial-reports-dates?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |

> (*) Required

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2025,
"period": "Q1",
"linkXlsx": "https://financialmodelingprep.com/stable/financial-reports-json?symbol=AAPL&year=2025&period=Q1&apikey=YOUR_API_KEY",
"linkJson": "https://financialmodelingprep.com/stable/financial-reports-xlsx?symbol=AAPL&year=2025&period=Q1&apikey=YOUR_API_KEY"
}
]
```

### Financial Reports Form 10-K JSON API
Access comprehensive annual reports with the FMP Annual Reports on Form 10-K API. Obtain detailed information about a company’s financial performance, business operations, and risk factors as reported to the SEC.

#### Request
```http
GET https://financialmodelingprep.com/stable/financial-reports-json?symbol=AAPL&year=2022&period=FY
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `year*` | `number` | `2022` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
```json
[
{
"symbol": "AAPL",
"period": "FY",
"year": "2022",
"Cover Page": [
{
"Cover Page - USD ($) shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Oct. 14, 2022",
"Mar. 25, 2022"
]
},
{
"Entity Information [Line Items]": [
" ",
" ",
" "
]
}
],
"Auditor Information": [
{
"Auditor Information": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Auditor Information [Abstract]": [
" "
]
}
],
"CONSOLIDATED STATEMENTS OF OPER": [
{
"CONSOLIDATED STATEMENTS OF OPERATIONS - USD ($) shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Net sales": [
394328,
365817,
274515
]
}
],
"CONSOLIDATED STATEMENTS OF COMP": [
{
"CONSOLIDATED STATEMENTS OF COMPREHENSIVE INCOME - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Statement of Comprehensive Income [Abstract]": [
" ",
" ",
" "
]
}
],
"CONSOLIDATED BALANCE SHEETS": [
{
"CONSOLIDATED BALANCE SHEETS - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Current assets:": [
" ",
" "
]
},
{
"Cash and cash equivalents": [
23646,
34940
]
}
],
"CONSOLIDATED BALANCE SHEETS (Pa": [
{
"CONSOLIDATED BALANCE SHEETS (Parenthetical) - $ / shares": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Statement of Financial Position [Abstract]": [
" ",
" "
]
},
{
"Common stock, par value (in dollars per share)": [
0.00001,
0.00001
]
}
],
"CONSOLIDATED STATEMENTS OF SHAR": [
{
"CONSOLIDATED STATEMENTS OF SHAREHOLDERS' EQUITY - USD ($) $ in Millions": [
"Total",
"Common stock and additional paid-in capital",
"Retained earnings/(Accumulated deficit)",
"Retained earnings/(Accumulated deficit) Cumulative effect of change in accounting principle",
"Accumulated other comprehensive income/(loss)",
"Accumulated other comprehensive income/(loss) Cumulative effect of change in accounting principle"
]
},
{
"Beginning balances at Sep. 28, 2019": [
90488,
45174,
45898,
-136,
-584,
136
]
},
{
"Increase (Decrease) in Stockholders' Equity [Roll Forward]": [
" ",
" ",
" ",
" ",
" ",
" "
]
}
],
"CONSOLIDATED STATEMENTS OF CASH": [
{
"CONSOLIDATED STATEMENTS OF CASH FLOWS - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Statement of Cash Flows [Abstract]": [
" ",
" ",
" "
]
}
],
"Summary of Significant Accounti": [
{
"Summary of Significant Accounting Policies": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Accounting Policies [Abstract]": [
" "
]
}
],
"Revenue": [
{
"Revenue": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Revenue from Contract with Customer [Abstract]": [
" "
]
}
],
"Financial Instruments": [
{
"Financial Instruments": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Investments, All Other Investments [Abstract]": [
" "
]
}
],
"Consolidated Financial Statemen": [
{
"Consolidated Financial Statement Details": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" "
]
}
],
"Income Taxes": [
{
"Income Taxes": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Income Tax Disclosure [Abstract]": [
" "
]
}
],
"Leases": [
{
"Leases": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Leases [Abstract]": [
" "
]
}
],
"Debt": [
{
"Debt": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Debt Disclosure [Abstract]": [
" "
]
}
],
"Shareholders' Equity": [
{
"Shareholders' Equity": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Equity [Abstract]": [
" "
]
}
],
"Benefit Plans": [
{
"Benefit Plans": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Share-Based Payment Arrangement [Abstract]": [
" "
]
}
],
"Commitments and Contingencies": [
{
"Commitments and Contingencies": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Commitments and Contingencies Disclosure [Abstract]": [
" "
]
}
],
"Segment Information and Geograp": [
{
"Segment Information and Geographic Data": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Segment Reporting [Abstract]": [
" "
]
}
],
"Summary of Significant Accoun_2": [
{
"Summary of Significant Accounting Policies (Policies)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Accounting Policies [Abstract]": [
" "
]
}
],
"Summary of Significant Accoun_3": [
{
"Summary of Significant Accounting Policies (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Accounting Policies [Abstract]": [
" "
]
}
],
"Revenue (Tables)": [
{
"Revenue (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Revenue from Contract with Customer [Abstract]": [
" "
]
}
],
"Financial Instruments (Tables)": [
{
"Financial Instruments (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Investments, All Other Investments [Abstract]": [
" "
]
}
],
"Consolidated Financial Statem_2": [
{
"Consolidated Financial Statement Details (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" "
]
}
],
"Income Taxes (Tables)": [
{
"Income Taxes (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Income Tax Disclosure [Abstract]": [
" "
]
}
],
"Leases (Tables)": [
{
"Leases (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Leases [Abstract]": [
" "
]
}
],
"Debt (Tables)": [
{
"Debt (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Debt Disclosure [Abstract]": [
" "
]
}
],
"Shareholders' Equity (Tables)": [
{
"Shareholders' Equity (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Equity [Abstract]": [
" "
]
}
],
"Benefit Plans (Tables)": [
{
"Benefit Plans (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Share-Based Payment Arrangement [Abstract]": [
" "
]
}
],
"Commitments and Contingencies (": [
{
"Commitments and Contingencies (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Commitments and Contingencies Disclosure [Abstract]": [
" "
]
}
],
"Segment Information and Geogr_2": [
{
"Segment Information and Geographic Data (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Segment Reporting [Abstract]": [
" "
]
}
],
"Summary of Significant Accoun_4": [
{
"Summary of Significant Accounting Policies - Additional Information (Details) $ in Billions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) performanceObligation",
"Sep. 25, 2021 USD ($)",
"Sep. 26, 2020 USD ($)"
]
},
{
"Significant Accounting Policies [Line Items]": [
" ",
" ",
" "
]
}
],
"Summary of Significant Accoun_5": [
{
"Summary of Significant Accounting Policies - Computation of Basic and Diluted Earnings Per Share (Details) - USD ($) $ / shares in Units, shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Numerator:": [
" ",
" ",
" "
]
}
],
"Revenue - Net Sales Disaggregat": [
{
"Revenue - Net Sales Disaggregated by Significant Products and Services (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Disaggregation of Revenue [Line Items]": [
" ",
" ",
" "
]
}
],
"Revenue - Additional Informatio": [
{
"Revenue - Additional Information (Details) - USD ($) $ in Billions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Revenue from Contract with Customer [Abstract]": [
" ",
" "
]
},
{
"Total deferred revenue": [
12.4,
11.9
]
}
],
"Revenue - Deferred Revenue, Exp": [
{
"Revenue - Deferred Revenue, Expected Timing of Realization (Details)": [
"Sep. 24, 2022"
]
},
{
"Revenue, Remaining Performance Obligation, Expected Timing of Satisfaction, Start Date [Axis]: 2022-09-25": [
" "
]
},
{
"Revenue, Remaining Performance Obligation, Expected Timing of Satisfaction [Line Items]": [
" "
]
}
],
"Financial Instruments - Cash, C": [
{
"Financial Instruments - Cash, Cash Equivalents and Marketable Securities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Debt Securities, Available-for-sale [Line Items]": [
" ",
" "
]
},
{
"Cash, Cash Equivalents and Marketable Securities, Adjusted Cost": [
183061,
189961
]
}
],
"Financial Instruments - Non-Cur": [
{
"Financial Instruments - Non-Current Marketable Debt Securities by Contractual Maturity (Details) $ in Millions": [
"Sep. 24, 2022 USD ($)"
]
},
{
"Fair value of non-current marketable debt securities by contractual maturity": [
" "
]
},
{
"Due after 1 year through 5 years": [
87031
]
}
],
"Financial Instruments - Additio": [
{
"Financial Instruments - Additional Information (Details) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) Customer Vendor",
"Sep. 25, 2021 Vendor"
]
},
{
"Financial Instruments [Line Items]": [
" ",
" "
]
}
],
"Financial Instruments - Notiona": [
{
"Financial Instruments - Notional Amounts Associated with Derivative Instruments (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Derivatives designated as accounting hedges | Foreign exchange contracts": [
" ",
" "
]
},
{
"Derivative [Line Items]": [
" ",
" "
]
}
],
"Financial Instruments - Gross F": [
{
"Financial Instruments - Gross Fair Values of Derivative Assets and Liabilities (Details) - Level 2 $ in Millions": [
"Sep. 24, 2022 USD ($)"
]
},
{
"Other current assets and other non-current assets | Foreign exchange contracts": [
" "
]
},
{
"Derivative assets:": [
" "
]
}
],
"Financial Instruments - Derivat": [
{
"Financial Instruments - Derivative Instruments Designated as Fair Value Hedges and Related Hedged Items (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Current and non-current marketable securities": [
" ",
" "
]
},
{
"Derivatives, Fair Value [Line Items]": [
" ",
" "
]
}
],
"Consolidated Financial Statem_3": [
{
"Consolidated Financial Statement Details - Property, Plant and Equipment, Net (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Property, Plant and Equipment [Line Items]": [
" ",
" "
]
},
{
"Gross property, plant and equipment": [
114457,
109723
]
}
],
"Consolidated Financial Statem_4": [
{
"Consolidated Financial Statement Details - Other Non-Current Liabilities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" ",
" "
]
},
{
"Long-term taxes payable": [
16657,
24689
]
}
],
"Consolidated Financial Statem_5": [
{
"Consolidated Financial Statement Details - Other Income/(Expense), Net (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" ",
" ",
" "
]
}
],
"Income Taxes - Provision for In": [
{
"Income Taxes - Provision for Income Taxes (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Federal:": [
" ",
" ",
" "
]
}
],
"Income Taxes - Additional Infor": [
{
"Income Taxes - Additional Information (Details) $ in Millions, € in Billions": [
null,
"12 Months Ended"
]
},
{
"items": [
"Aug. 30, 2016 EUR (€) Subsidiary",
"Sep. 24, 2022 USD ($)",
"Sep. 25, 2021 USD ($)",
"Sep. 26, 2020 USD ($)",
"Sep. 24, 2022 EUR (€)",
"Sep. 28, 2019 USD ($)"
]
},
{
"Income Tax Contingency [Line Items]": [
" ",
" ",
" ",
" ",
" ",
" "
]
}
],
"Income Taxes - Reconciliation o": [
{
"Income Taxes - Reconciliation of Provision for Income Taxes to Amount Computed by Applying the Statutory Federal Income Tax Rate to Income Before Provision for Income Taxes (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Income Tax Disclosure [Abstract]": [
" ",
" ",
" "
]
}
],
"Income Taxes - Significant Comp": [
{
"Income Taxes - Significant Components of Deferred Tax Assets and Liabilities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Deferred tax assets:": [
" ",
" "
]
},
{
"Amortization and depreciation": [
1496,
5575
]
}
],
"Income Taxes - Aggregate Change": [
{
"Income Taxes - Aggregate Changes in Gross Unrecognized Tax Benefits (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Reconciliation of Unrecognized Tax Benefits, Excluding Amounts Pertaining to Examined Tax Returns [Roll Forward]": [
" ",
" ",
" "
]
}
],
"Leases - Additional Information": [
{
"Leases - Additional Information (Details) - USD ($) $ in Billions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Lessee, Lease, Description [Line Items]": [
" ",
" ",
" "
]
}
],
"Leases - ROU Assets and Lease L": [
{
"Leases - ROU Assets and Lease Liabilities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Lease-Related Assets and Liabilities": [
" ",
" "
]
},
{
"Operating lease right-of-use assets": [
10417,
10087
]
}
],
"Leases - Lease Liability Maturi": [
{
"Leases - Lease Liability Maturities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Operating Leases": [
" ",
" "
]
},
{
"2023": [
1758,
" "
]
}
],
"Debt - Additional Information (": [
{
"Debt - Additional Information (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Debt Instrument [Line Items]": [
" ",
" ",
" "
]
}
],
"Debt - Summary of Cash Flows As": [
{
"Debt - Summary of Cash Flows Associated with Commercial Paper (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Maturities 90 days or less:": [
" ",
" ",
" "
]
}
],
"Debt - Summary of Term Debt (De": [
{
"Debt - Summary of Term Debt (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Debt Instrument [Line Items]": [
" ",
" "
]
}
],
"Debt - Future Principal Payment": [
{
"Debt - Future Principal Payments for Term Debt (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Debt Disclosure [Abstract]": [
" ",
" "
]
},
{
"2023": [
11139,
" "
]
}
],
"Shareholders' Equity - Addition": [
{
"Shareholders' Equity - Additional Information (Details) shares in Millions, $ in Billions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) shares"
]
},
{
"Stockholders' Equity Note [Abstract]": [
" "
]
}
],
"Shareholders' Equity - Shares o": [
{
"Shareholders' Equity - Shares of Common Stock (Details) - shares shares in Thousands": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Increase (Decrease) in Shares of Common Stock Outstanding [Roll Forward]": [
" ",
" ",
" "
]
}
],
"Benefit Plans - Additional Info": [
{
"Benefit Plans - Additional Information (Details) shares in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) shares",
"Sep. 25, 2021 USD ($) shares",
"Sep. 26, 2020 USD ($) shares",
"Mar. 04, 2022 shares",
"Nov. 09, 2021 shares",
"Mar. 10, 2015 shares"
]
},
{
"Share-based Compensation Arrangement by Share-based Payment Award [Line Items]": [
" ",
" ",
" ",
" ",
" ",
" "
]
}
],
"Benefit Plans - Restricted Stoc": [
{
"Benefit Plans - Restricted Stock Units Activity and Related Information (Details) - Restricted stock units - USD ($) $ / shares in Units, shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Number of Restricted Stock Units": [
" ",
" ",
" "
]
}
],
"Benefit Plans - Summary of Shar": [
{
"Benefit Plans - Summary of Share-Based Compensation Expense and the Related Income Tax Benefit (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Share-Based Payment Arrangement [Abstract]": [
" ",
" ",
" "
]
}
],
"Commitments and Contingencies -": [
{
"Commitments and Contingencies - Future Payments Under Unconditional Purchase Obligations (Details) $ in Millions": [
"Sep. 24, 2022 USD ($)"
]
},
{
"Unconditional Purchase Obligation, Fiscal Year Maturity [Abstract]": [
" "
]
},
{
"2023": [
13488
]
}
],
"Segment Information and Geogr_3": [
{
"Segment Information and Geographic Data - Information by Reportable Segment (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Segment Reporting Information [Line Items]": [
" ",
" ",
" "
]
}
],
"Segment Information and Geogr_4": [
{
"Segment Information and Geographic Data - Reconciliation of Segment Operating Income to the Consolidated Statements of Operations (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Segment Reporting, Reconciling Item for Operating Profit (Loss) from Segment to Consolidated [Line Items]": [
" ",
" ",
" "
]
}
],
"Segment Information and Geogr_5": [
{
"Segment Information and Geographic Data - Net Sales (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Revenues from External Customers and Long-Lived Assets [Line Items]": [
" ",
" ",
" "
]
}
],
"Segment Information and Geogr_6": [
{
"Segment Information and Geographic Data - Long-Lived Assets (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Revenues from External Customers and Long-Lived Assets [Line Items]": [
" ",
" "
]
},
{
"Long-lived assets": [
42117,
39440
]
}
]
}
]
```

### Financial Reports Form 10-K XLSX API
Download detailed 10-K reports in XLSX format with the Financial Reports Form 10-K XLSX API. Effortlessly access and analyze annual financial data for companies in a spreadsheet-friendly format.

#### Request
```http
GET https://financialmodelingprep.com/stable/financial-reports-xlsx?symbol=AAPL&year=2022&period=FY
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `year*` | `number` | `2022` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
```json
[
{
"symbol": "AAPL",
"period": "FY",
"year": "2022",
"Cover Page": [
{
"Cover Page - USD ($) shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Oct. 14, 2022",
"Mar. 25, 2022"
]
},
{
"Entity Information [Line Items]": [
" ",
" ",
" "
]
}
],
"Auditor Information": [
{
"Auditor Information": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Auditor Information [Abstract]": [
" "
]
}
],
"CONSOLIDATED STATEMENTS OF OPER": [
{
"CONSOLIDATED STATEMENTS OF OPERATIONS - USD ($) shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Net sales": [
394328,
365817,
274515
]
}
],
"CONSOLIDATED STATEMENTS OF COMP": [
{
"CONSOLIDATED STATEMENTS OF COMPREHENSIVE INCOME - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Statement of Comprehensive Income [Abstract]": [
" ",
" ",
" "
]
}
],
"CONSOLIDATED BALANCE SHEETS": [
{
"CONSOLIDATED BALANCE SHEETS - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Current assets:": [
" ",
" "
]
},
{
"Cash and cash equivalents": [
23646,
34940
]
}
],
"CONSOLIDATED BALANCE SHEETS (Pa": [
{
"CONSOLIDATED BALANCE SHEETS (Parenthetical) - $ / shares": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Statement of Financial Position [Abstract]": [
" ",
" "
]
},
{
"Common stock, par value (in dollars per share)": [
0.00001,
0.00001
]
}
],
"CONSOLIDATED STATEMENTS OF SHAR": [
{
"CONSOLIDATED STATEMENTS OF SHAREHOLDERS' EQUITY - USD ($) $ in Millions": [
"Total",
"Common stock and additional paid-in capital",
"Retained earnings/(Accumulated deficit)",
"Retained earnings/(Accumulated deficit) Cumulative effect of change in accounting principle",
"Accumulated other comprehensive income/(loss)",
"Accumulated other comprehensive income/(loss) Cumulative effect of change in accounting principle"
]
},
{
"Beginning balances at Sep. 28, 2019": [
90488,
45174,
45898,
-136,
-584,
136
]
},
{
"Increase (Decrease) in Stockholders' Equity [Roll Forward]": [
" ",
" ",
" ",
" ",
" ",
" "
]
}
],
"CONSOLIDATED STATEMENTS OF CASH": [
{
"CONSOLIDATED STATEMENTS OF CASH FLOWS - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Statement of Cash Flows [Abstract]": [
" ",
" ",
" "
]
}
],
"Summary of Significant Accounti": [
{
"Summary of Significant Accounting Policies": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Accounting Policies [Abstract]": [
" "
]
}
],
"Revenue": [
{
"Revenue": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Revenue from Contract with Customer [Abstract]": [
" "
]
}
],
"Financial Instruments": [
{
"Financial Instruments": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Investments, All Other Investments [Abstract]": [
" "
]
}
],
"Consolidated Financial Statemen": [
{
"Consolidated Financial Statement Details": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" "
]
}
],
"Income Taxes": [
{
"Income Taxes": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Income Tax Disclosure [Abstract]": [
" "
]
}
],
"Leases": [
{
"Leases": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Leases [Abstract]": [
" "
]
}
],
"Debt": [
{
"Debt": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Debt Disclosure [Abstract]": [
" "
]
}
],
"Shareholders' Equity": [
{
"Shareholders' Equity": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Equity [Abstract]": [
" "
]
}
],
"Benefit Plans": [
{
"Benefit Plans": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Share-Based Payment Arrangement [Abstract]": [
" "
]
}
],
"Commitments and Contingencies": [
{
"Commitments and Contingencies": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Commitments and Contingencies Disclosure [Abstract]": [
" "
]
}
],
"Segment Information and Geograp": [
{
"Segment Information and Geographic Data": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Segment Reporting [Abstract]": [
" "
]
}
],
"Summary of Significant Accoun_2": [
{
"Summary of Significant Accounting Policies (Policies)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Accounting Policies [Abstract]": [
" "
]
}
],
"Summary of Significant Accoun_3": [
{
"Summary of Significant Accounting Policies (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Accounting Policies [Abstract]": [
" "
]
}
],
"Revenue (Tables)": [
{
"Revenue (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Revenue from Contract with Customer [Abstract]": [
" "
]
}
],
"Financial Instruments (Tables)": [
{
"Financial Instruments (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Investments, All Other Investments [Abstract]": [
" "
]
}
],
"Consolidated Financial Statem_2": [
{
"Consolidated Financial Statement Details (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" "
]
}
],
"Income Taxes (Tables)": [
{
"Income Taxes (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Income Tax Disclosure [Abstract]": [
" "
]
}
],
"Leases (Tables)": [
{
"Leases (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Leases [Abstract]": [
" "
]
}
],
"Debt (Tables)": [
{
"Debt (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Debt Disclosure [Abstract]": [
" "
]
}
],
"Shareholders' Equity (Tables)": [
{
"Shareholders' Equity (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Equity [Abstract]": [
" "
]
}
],
"Benefit Plans (Tables)": [
{
"Benefit Plans (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Share-Based Payment Arrangement [Abstract]": [
" "
]
}
],
"Commitments and Contingencies (": [
{
"Commitments and Contingencies (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Commitments and Contingencies Disclosure [Abstract]": [
" "
]
}
],
"Segment Information and Geogr_2": [
{
"Segment Information and Geographic Data (Tables)": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022"
]
},
{
"Segment Reporting [Abstract]": [
" "
]
}
],
"Summary of Significant Accoun_4": [
{
"Summary of Significant Accounting Policies - Additional Information (Details) $ in Billions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) performanceObligation",
"Sep. 25, 2021 USD ($)",
"Sep. 26, 2020 USD ($)"
]
},
{
"Significant Accounting Policies [Line Items]": [
" ",
" ",
" "
]
}
],
"Summary of Significant Accoun_5": [
{
"Summary of Significant Accounting Policies - Computation of Basic and Diluted Earnings Per Share (Details) - USD ($) $ / shares in Units, shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Numerator:": [
" ",
" ",
" "
]
}
],
"Revenue - Net Sales Disaggregat": [
{
"Revenue - Net Sales Disaggregated by Significant Products and Services (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Disaggregation of Revenue [Line Items]": [
" ",
" ",
" "
]
}
],
"Revenue - Additional Informatio": [
{
"Revenue - Additional Information (Details) - USD ($) $ in Billions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Revenue from Contract with Customer [Abstract]": [
" ",
" "
]
},
{
"Total deferred revenue": [
12.4,
11.9
]
}
],
"Revenue - Deferred Revenue, Exp": [
{
"Revenue - Deferred Revenue, Expected Timing of Realization (Details)": [
"Sep. 24, 2022"
]
},
{
"Revenue, Remaining Performance Obligation, Expected Timing of Satisfaction, Start Date [Axis]: 2022-09-25": [
" "
]
},
{
"Revenue, Remaining Performance Obligation, Expected Timing of Satisfaction [Line Items]": [
" "
]
}
],
"Financial Instruments - Cash, C": [
{
"Financial Instruments - Cash, Cash Equivalents and Marketable Securities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Debt Securities, Available-for-sale [Line Items]": [
" ",
" "
]
},
{
"Cash, Cash Equivalents and Marketable Securities, Adjusted Cost": [
183061,
189961
]
}
],
"Financial Instruments - Non-Cur": [
{
"Financial Instruments - Non-Current Marketable Debt Securities by Contractual Maturity (Details) $ in Millions": [
"Sep. 24, 2022 USD ($)"
]
},
{
"Fair value of non-current marketable debt securities by contractual maturity": [
" "
]
},
{
"Due after 1 year through 5 years": [
87031
]
}
],
"Financial Instruments - Additio": [
{
"Financial Instruments - Additional Information (Details) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) Customer Vendor",
"Sep. 25, 2021 Vendor"
]
},
{
"Financial Instruments [Line Items]": [
" ",
" "
]
}
],
"Financial Instruments - Notiona": [
{
"Financial Instruments - Notional Amounts Associated with Derivative Instruments (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Derivatives designated as accounting hedges | Foreign exchange contracts": [
" ",
" "
]
},
{
"Derivative [Line Items]": [
" ",
" "
]
}
],
"Financial Instruments - Gross F": [
{
"Financial Instruments - Gross Fair Values of Derivative Assets and Liabilities (Details) - Level 2 $ in Millions": [
"Sep. 24, 2022 USD ($)"
]
},
{
"Other current assets and other non-current assets | Foreign exchange contracts": [
" "
]
},
{
"Derivative assets:": [
" "
]
}
],
"Financial Instruments - Derivat": [
{
"Financial Instruments - Derivative Instruments Designated as Fair Value Hedges and Related Hedged Items (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Current and non-current marketable securities": [
" ",
" "
]
},
{
"Derivatives, Fair Value [Line Items]": [
" ",
" "
]
}
],
"Consolidated Financial Statem_3": [
{
"Consolidated Financial Statement Details - Property, Plant and Equipment, Net (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Property, Plant and Equipment [Line Items]": [
" ",
" "
]
},
{
"Gross property, plant and equipment": [
114457,
109723
]
}
],
"Consolidated Financial Statem_4": [
{
"Consolidated Financial Statement Details - Other Non-Current Liabilities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" ",
" "
]
},
{
"Long-term taxes payable": [
16657,
24689
]
}
],
"Consolidated Financial Statem_5": [
{
"Consolidated Financial Statement Details - Other Income/(Expense), Net (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Organization, Consolidation and Presentation of Financial Statements [Abstract]": [
" ",
" ",
" "
]
}
],
"Income Taxes - Provision for In": [
{
"Income Taxes - Provision for Income Taxes (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Federal:": [
" ",
" ",
" "
]
}
],
"Income Taxes - Additional Infor": [
{
"Income Taxes - Additional Information (Details) $ in Millions, € in Billions": [
null,
"12 Months Ended"
]
},
{
"items": [
"Aug. 30, 2016 EUR (€) Subsidiary",
"Sep. 24, 2022 USD ($)",
"Sep. 25, 2021 USD ($)",
"Sep. 26, 2020 USD ($)",
"Sep. 24, 2022 EUR (€)",
"Sep. 28, 2019 USD ($)"
]
},
{
"Income Tax Contingency [Line Items]": [
" ",
" ",
" ",
" ",
" ",
" "
]
}
],
"Income Taxes - Reconciliation o": [
{
"Income Taxes - Reconciliation of Provision for Income Taxes to Amount Computed by Applying the Statutory Federal Income Tax Rate to Income Before Provision for Income Taxes (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Income Tax Disclosure [Abstract]": [
" ",
" ",
" "
]
}
],
"Income Taxes - Significant Comp": [
{
"Income Taxes - Significant Components of Deferred Tax Assets and Liabilities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Deferred tax assets:": [
" ",
" "
]
},
{
"Amortization and depreciation": [
1496,
5575
]
}
],
"Income Taxes - Aggregate Change": [
{
"Income Taxes - Aggregate Changes in Gross Unrecognized Tax Benefits (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Reconciliation of Unrecognized Tax Benefits, Excluding Amounts Pertaining to Examined Tax Returns [Roll Forward]": [
" ",
" ",
" "
]
}
],
"Leases - Additional Information": [
{
"Leases - Additional Information (Details) - USD ($) $ in Billions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Lessee, Lease, Description [Line Items]": [
" ",
" ",
" "
]
}
],
"Leases - ROU Assets and Lease L": [
{
"Leases - ROU Assets and Lease Liabilities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Lease-Related Assets and Liabilities": [
" ",
" "
]
},
{
"Operating lease right-of-use assets": [
10417,
10087
]
}
],
"Leases - Lease Liability Maturi": [
{
"Leases - Lease Liability Maturities (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Operating Leases": [
" ",
" "
]
},
{
"2023": [
1758,
" "
]
}
],
"Debt - Additional Information (": [
{
"Debt - Additional Information (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Debt Instrument [Line Items]": [
" ",
" ",
" "
]
}
],
"Debt - Summary of Cash Flows As": [
{
"Debt - Summary of Cash Flows Associated with Commercial Paper (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Maturities 90 days or less:": [
" ",
" ",
" "
]
}
],
"Debt - Summary of Term Debt (De": [
{
"Debt - Summary of Term Debt (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Debt Instrument [Line Items]": [
" ",
" "
]
}
],
"Debt - Future Principal Payment": [
{
"Debt - Future Principal Payments for Term Debt (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Debt Disclosure [Abstract]": [
" ",
" "
]
},
{
"2023": [
11139,
" "
]
}
],
"Shareholders' Equity - Addition": [
{
"Shareholders' Equity - Additional Information (Details) shares in Millions, $ in Billions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) shares"
]
},
{
"Stockholders' Equity Note [Abstract]": [
" "
]
}
],
"Shareholders' Equity - Shares o": [
{
"Shareholders' Equity - Shares of Common Stock (Details) - shares shares in Thousands": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Increase (Decrease) in Shares of Common Stock Outstanding [Roll Forward]": [
" ",
" ",
" "
]
}
],
"Benefit Plans - Additional Info": [
{
"Benefit Plans - Additional Information (Details) shares in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022 USD ($) shares",
"Sep. 25, 2021 USD ($) shares",
"Sep. 26, 2020 USD ($) shares",
"Mar. 04, 2022 shares",
"Nov. 09, 2021 shares",
"Mar. 10, 2015 shares"
]
},
{
"Share-based Compensation Arrangement by Share-based Payment Award [Line Items]": [
" ",
" ",
" ",
" ",
" ",
" "
]
}
],
"Benefit Plans - Restricted Stoc": [
{
"Benefit Plans - Restricted Stock Units Activity and Related Information (Details) - Restricted stock units - USD ($) $ / shares in Units, shares in Thousands, $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Number of Restricted Stock Units": [
" ",
" ",
" "
]
}
],
"Benefit Plans - Summary of Shar": [
{
"Benefit Plans - Summary of Share-Based Compensation Expense and the Related Income Tax Benefit (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Share-Based Payment Arrangement [Abstract]": [
" ",
" ",
" "
]
}
],
"Commitments and Contingencies -": [
{
"Commitments and Contingencies - Future Payments Under Unconditional Purchase Obligations (Details) $ in Millions": [
"Sep. 24, 2022 USD ($)"
]
},
{
"Unconditional Purchase Obligation, Fiscal Year Maturity [Abstract]": [
" "
]
},
{
"2023": [
13488
]
}
],
"Segment Information and Geogr_3": [
{
"Segment Information and Geographic Data - Information by Reportable Segment (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Segment Reporting Information [Line Items]": [
" ",
" ",
" "
]
}
],
"Segment Information and Geogr_4": [
{
"Segment Information and Geographic Data - Reconciliation of Segment Operating Income to the Consolidated Statements of Operations (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Segment Reporting, Reconciling Item for Operating Profit (Loss) from Segment to Consolidated [Line Items]": [
" ",
" ",
" "
]
}
],
"Segment Information and Geogr_5": [
{
"Segment Information and Geographic Data - Net Sales (Details) - USD ($) $ in Millions": [
"12 Months Ended"
]
},
{
"items": [
"Sep. 24, 2022",
"Sep. 25, 2021",
"Sep. 26, 2020"
]
},
{
"Revenues from External Customers and Long-Lived Assets [Line Items]": [
" ",
" ",
" "
]
}
],
"Segment Information and Geogr_6": [
{
"Segment Information and Geographic Data - Long-Lived Assets (Details) - USD ($) $ in Millions": [
"Sep. 24, 2022",
"Sep. 25, 2021"
]
},
{
"Revenues from External Customers and Long-Lived Assets [Line Items]": [
" ",
" "
]
},
{
"Long-lived assets": [
42117,
39440
]
}
]
}
]
```

### Revenue Product Segmentation API
Access detailed revenue breakdowns by product line with the Revenue Product Segmentation API. Understand which products drive a company's earnings and get insights into the performance of individual product segments.

#### Request
```http
GET https://financialmodelingprep.com/stable/revenue-product-segmentation?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `period` | `string` | `annual,quarter` |
| `structure` | `string` | `flat` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2024,
"period": "FY",
"reportedCurrency": null,
"date": "2024-09-28",
"data": {
"Mac": 29984000000,
"Service": 96169000000,
"Wearables, Home and Accessories": 37005000000,
"iPad": 26694000000,
"iPhone": 201183000000
}
}
]
```

### Revenue Geographic Segments API
Access detailed revenue breakdowns by geographic region with the Revenue Geographic Segments API. Analyze how different regions contribute to a company’s total revenue and identify key markets for growth.

#### Request
```http
GET https://financialmodelingprep.com/stable/revenue-geographic-segmentation?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `period` | `string` | `annual,quarter` |
| `structure` | `string` | `flat` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2024,
"period": "FY",
"reportedCurrency": null,
"date": "2024-09-28",
"data": {
"Americas Segment": 167045000000,
"Europe Segment": 101328000000,
"Greater China Segment": 66952000000,
"Japan Segment": 25052000000,
"Rest of Asia Pacific": 30658000000
}
}
]
```

### As Reported Income Statements API
Retrieve income statements as they were reported by the company with the As Reported Income Statements API. Access raw financial data directly from official company filings, including revenue, expenses, and net income.

#### Request
```http
GET https://financialmodelingprep.com/stable/income-statement-as-reported?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2024,
"period": "FY",
"reportedCurrency": null,
"date": "2024-09-27",
"data": {
"revenuefromcontractwithcustomerexcludingassessedtax": 391035000000,
"costofgoodsandservicessold": 210352000000,
"grossprofit": 180683000000,
"researchanddevelopmentexpense": 31370000000,
"sellinggeneralandadministrativeexpense": 26097000000,
"operatingexpenses": 57467000000,
"operatingincomeloss": 123216000000,
"nonoperatingincomeexpense": 269000000,
"incomelossfromcontinuingoperationsbeforeincometaxesextraordinaryitemsnoncontrollinginterest": 123485000000,
"incometaxexpensebenefit": 29749000000,
"netincomeloss": 93736000000,
"earningspersharebasic": 6.11,
"earningspersharediluted": 6.08,
"weightedaveragenumberofsharesoutstandingbasic": 15343783000,
"weightedaveragenumberofdilutedsharesoutstanding": 15408095000,
"othercomprehensiveincomelossforeigncurrencytransactionandtranslationadjustmentnetoftax": 395000000,
"othercomprehensiveincomelossderivativeinstrumentgainlossbeforereclassificationaftertax": -832000000,
"othercomprehensiveincomelossderivativeinstrumentgainlossreclassificationaftertax": 1337000000,
"othercomprehensiveincomelossderivativeinstrumentgainlossafterreclassificationandtax": -2169000000,
"othercomprehensiveincomeunrealizedholdinggainlossonsecuritiesarisingduringperiodnetoftax": 5850000000,
"othercomprehensiveincomelossreclassificationadjustmentfromaociforsaleofsecuritiesnetoftax": -204000000,
"othercomprehensiveincomelossavailableforsalesecuritiesadjustmentnetoftax": 6054000000,
"othercomprehensiveincomelossnetoftaxportionattributabletoparent": 4280000000,
"comprehensiveincomenetoftax": 98016000000
}
}
]
```

### As Reported Balance Statements API
Access balance sheets as reported by the company with the As Reported Balance Statements API. View detailed financial data on assets, liabilities, and equity directly from official filings.

#### Request
```http
GET https://financialmodelingprep.com/stable/balance-sheet-statement-as-reported?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2024,
"period": "FY",
"reportedCurrency": null,
"date": "2024-09-27",
"data": {
"cashandcashequivalentsatcarryingvalue": 29943000000,
"marketablesecuritiescurrent": 35228000000,
"accountsreceivablenetcurrent": 33410000000,
"nontradereceivablescurrent": 32833000000,
"inventorynet": 7286000000,
"otherassetscurrent": 14287000000,
"assetscurrent": 152987000000,
"marketablesecuritiesnoncurrent": 91479000000,
"propertyplantandequipmentnet": 45680000000,
"otherassetsnoncurrent": 74834000000,
"assetsnoncurrent": 211993000000,
"assets": 364980000000,
"accountspayablecurrent": 68960000000,
"otherliabilitiescurrent": 78304000000,
"contractwithcustomerliabilitycurrent": 8249000000,
"commercialpaper": 10000000000,
"longtermdebtcurrent": 10912000000,
"liabilitiescurrent": 176392000000,
"longtermdebtnoncurrent": 85750000000,
"otherliabilitiesnoncurrent": 45888000000,
"liabilitiesnoncurrent": 131638000000,
"liabilities": 308030000000,
"commonstocksharesoutstanding": 15116786000,
"commonstocksharesissued": 15116786000,
"commonstocksincludingadditionalpaidincapital": 83276000000,
"retainedearningsaccumulateddeficit": -19154000000,
"accumulatedothercomprehensiveincomelossnetoftax": -7172000000,
"stockholdersequity": 56950000000,
"liabilitiesandstockholdersequity": 364980000000,
"commonstockparorstatedvaluepershare": 0.00001,
"commonstocksharesauthorized": 50400000000
}
}
]
```

### As Reported Cashflow Statements API
View cash flow statements as reported by the company with the As Reported Cash Flow Statements API. Analyze a company's cash flows related to operations, investments, and financing directly from official reports.

#### Request
```http
GET https://financialmodelingprep.com/stable/cash-flow-statement-as-reported?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2024,
"period": "FY",
"reportedCurrency": null,
"date": "2024-09-27",
"data": {
"cashcashequivalentsrestrictedcashandrestrictedcashequivalents": 29943000000,
"netincomeloss": 93736000000,
"depreciationdepletionandamortization": 11445000000,
"sharebasedcompensation": 11688000000,
"othernoncashincomeexpense": 2266000000,
"increasedecreaseinaccountsreceivable": 3788000000,
"increasedecreaseinotherreceivables": 1356000000,
"increasedecreaseininventories": 1046000000,
"increasedecreaseinotheroperatingassets": 11731000000,
"increasedecreaseinaccountspayable": 6020000000,
"increasedecreaseinotheroperatingliabilities": 15552000000,
"netcashprovidedbyusedinoperatingactivities": 118254000000,
"paymentstoacquireavailableforsalesecuritiesdebt": 48656000000,
"proceedsfrommaturitiesprepaymentsandcallsofavailableforsalesecurities": 51211000000,
"proceedsfromsaleofavailableforsalesecuritiesdebt": 11135000000,
"paymentstoacquirepropertyplantandequipment": 9447000000,
"paymentsforproceedsfromotherinvestingactivities": 1308000000,
"netcashprovidedbyusedininvestingactivities": 2935000000,
"paymentsrelatedtotaxwithholdingforsharebasedcompensation": 5600000000,
"paymentsofdividends": 15234000000,
"paymentsforrepurchaseofcommonstock": 94949000000,
"repaymentsoflongtermdebt": 9958000000,
"proceedsfromrepaymentsofcommercialpaper": 3960000000,
"proceedsfrompaymentsforotherfinancingactivities": -361000000,
"netcashprovidedbyusedinfinancingactivities": -121983000000,
"cashcashequivalentsrestrictedcashandrestrictedcashequivalentsperiodincreasedecreaseincludingexchangerateeffect": -794000000,
"incometaxespaidnet": 26102000000
}
}
]
```

### As Reported Financial Statements API
Retrieve comprehensive financial statements as reported by companies with FMP As Reported Financial Statements API. Access complete data across income, balance sheet, and cash flow statements in their original form for detailed analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/financial-statement-full-as-reported?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `5` |
| `period` | `string` | `annual,quarter` |

> (*) Required | Maximum 1000 records per request | Currency is as Reported in Financials

### Sample response
```json
[
{
"symbol": "AAPL",
"fiscalYear": 2024,
"period": "FY",
"reportedCurrency": null,
"date": "2024-09-27",
"data": {
"documenttype": "10-K",
"documentannualreport": "true",
"currentfiscalyearenddate": "--09-28",
"documentperiodenddate": "2024-09-28",
"documenttransitionreport": "false",
"entityfilenumber": "001-36743",
"entityregistrantname": "Apple Inc.",
"entityincorporationstatecountrycode": "CA",
"entitytaxidentificationnumber": "94-2404110",
"entityaddressaddressline1": "One Apple Park Way",
"entityaddresscityortown": "Cupertino",
"entityaddressstateorprovince": "CA",
"entityaddresspostalzipcode": 95014,
"cityareacode": 408,
"localphonenumber": "996-1010",
"security12btitle": "3.600% Notes due 2042",
"tradingsymbol": "AAPL",
"notradingsymbolflag": "true",
"securityexchangename": "NASDAQ",
"entitywellknownseasonedissuer": "Yes",
"entityvoluntaryfilers": "No",
"entitycurrentreportingstatus": "Yes",
"entityinteractivedatacurrent": "Yes",
"entityfilercategory": "Large Accelerated Filer",
"entitysmallbusiness": "false",
"entityemerginggrowthcompany": "false",
"icfrauditorattestationflag": "true",
"documentfinstmterrorcorrectionflag": "false",
"entityshellcompany": "false",
"amendmentflag": "false",
"documentfiscalyearfocus": 2024,
"documentfiscalperiodfocus": "FY",
"entitycentralindexkey": 320193,
"auditorname": "Ernst & Young LLP",
"auditorlocation": "San Jose, California",
"auditorfirmid": 42,
"revenuefromcontractwithcustomerexcludingassessedtax": 391035000000,
"costofgoodsandservicessold": 210352000000,
"grossprofit": 180683000000,
"researchanddevelopmentexpense": 31370000000,
"sellinggeneralandadministrativeexpense": 26097000000,
"operatingexpenses": 57467000000,
"operatingincomeloss": 123216000000,
"nonoperatingincomeexpense": 269000000,
"incomelossfromcontinuingoperationsbeforeincometaxesextraordinaryitemsnoncontrollinginterest": 123485000000,
"incometaxexpensebenefit": 29749000000,
"netincomeloss": 93736000000,
"earningspersharebasic": 6.11,
"earningspersharediluted": 6.08,
"weightedaveragenumberofsharesoutstandingbasic": 15343783000,
"weightedaveragenumberofdilutedsharesoutstanding": 15408095000,
"othercomprehensiveincomelossforeigncurrencytransactionandtranslationadjustmentnetoftax": 395000000,
"othercomprehensiveincomelossderivativeinstrumentgainlossbeforereclassificationaftertax": -832000000,
"othercomprehensiveincomelossderivativeinstrumentgainlossreclassificationaftertax": 1337000000,
"othercomprehensiveincomelossderivativeinstrumentgainlossafterreclassificationandtax": -2169000000,
"othercomprehensiveincomeunrealizedholdinggainlossonsecuritiesarisingduringperiodnetoftax": 5850000000,
"othercomprehensiveincomelossreclassificationadjustmentfromaociforsaleofsecuritiesnetoftax": -204000000,
"othercomprehensiveincomelossavailableforsalesecuritiesadjustmentnetoftax": 6054000000,
"othercomprehensiveincomelossnetoftaxportionattributabletoparent": 4280000000,
"comprehensiveincomenetoftax": 98016000000,
"cashandcashequivalentsatcarryingvalue": 29943000000,
"marketablesecuritiescurrent": 35228000000,
"accountsreceivablenetcurrent": 33410000000,
"nontradereceivablescurrent": 32833000000,
"inventorynet": 7286000000,
"otherassetscurrent": 14287000000,
"assetscurrent": 152987000000,
"marketablesecuritiesnoncurrent": 91479000000,
"propertyplantandequipmentnet": 45680000000,
"otherassetsnoncurrent": 74834000000,
"assetsnoncurrent": 211993000000,
"assets": 364980000000,
"accountspayablecurrent": 68960000000,
"otherliabilitiescurrent": 78304000000,
"contractwithcustomerliabilitycurrent": 8249000000,
"commercialpaper": 10000000000,
"longtermdebtcurrent": 10912000000,
"liabilitiescurrent": 176392000000,
"longtermdebtnoncurrent": 85750000000,
"otherliabilitiesnoncurrent": 45888000000,
"liabilitiesnoncurrent": 131638000000,
"liabilities": 308030000000,
"commonstocksharesoutstanding": 15116786000,
"commonstocksharesissued": 15116786000,
"commonstocksincludingadditionalpaidincapital": 83276000000,
"retainedearningsaccumulateddeficit": -19154000000,
"accumulatedothercomprehensiveincomelossnetoftax": -7172000000,
"stockholdersequity": 56950000000,
"liabilitiesandstockholdersequity": 364980000000,
"commonstockparorstatedvaluepershare": 0.00001,
"commonstocksharesauthorized": 50400000000,
"stockissuedduringperiodvaluenewissues": 1423000000,
"adjustmentsrelatedtotaxwithholdingforsharebasedcompensation": 1612000000,
"adjustmentstoadditionalpaidincapitalsharebasedcompensationrequisiteserviceperiodrecognitionvalue": 12034000000,
"dividends": 15218000000,
"stockrepurchasedandretiredduringperiodvalue": 95000000000,
"commonstockdividendspersharedeclared": 0.98,
"cashcashequivalentsrestrictedcashandrestrictedcashequivalents": 29943000000,
"depreciationdepletionandamortization": 11445000000,
"sharebasedcompensation": 11688000000,
"othernoncashincomeexpense": 2266000000,
"increasedecreaseinaccountsreceivable": 3788000000,
"increasedecreaseinotherreceivables": 1356000000,
"increasedecreaseininventories": 1046000000,
"increasedecreaseinotheroperatingassets": 11731000000,
"increasedecreaseinaccountspayable": 6020000000,
"increasedecreaseinotheroperatingliabilities": 15552000000,
"netcashprovidedbyusedinoperatingactivities": 118254000000,
"paymentstoacquireavailableforsalesecuritiesdebt": 48656000000,
"proceedsfrommaturitiesprepaymentsandcallsofavailableforsalesecurities": 51211000000,
"proceedsfromsaleofavailableforsalesecuritiesdebt": 11135000000,
"paymentstoacquirepropertyplantandequipment": 9447000000,
"paymentsforproceedsfromotherinvestingactivities": 1308000000,
"netcashprovidedbyusedininvestingactivities": 2935000000,
"paymentsrelatedtotaxwithholdingforsharebasedcompensation": 5600000000,
"paymentsofdividends": 15234000000,
"paymentsforrepurchaseofcommonstock": 94949000000,
"repaymentsoflongtermdebt": 9958000000,
"proceedsfromrepaymentsofcommercialpaper": 3960000000,
"proceedsfrompaymentsforotherfinancingactivities": -361000000,
"netcashprovidedbyusedinfinancingactivities": -121983000000,
"cashcashequivalentsrestrictedcashandrestrictedcashequivalentsperiodincreasedecreaseincludingexchangerateeffect": -794000000,
"incometaxespaidnet": 26102000000,
"commercialpapercashflowsummarytabletextblock": "The following table provides a summary of cash flows associated with the issuance and maturities of commercial paper for 2024, 2023 and 2022 (in millions):",
"contractwithcustomerliabilityrevenuerecognized": 7700000000,
"contractwithcustomerliability": 12800000000,
"revenueremainingperformanceobligationpercentage": 0.02,
"revenueremainingperformanceobligationexpectedtimingofsatisfactionperiod1": "P1Y",
"incrementalcommonsharesattributabletosharebasedpaymentarrangements": 64312000,
"cash": 27199000000,
"equitysecuritiesfvnicost": 1293000000,
"equitysecuritiesfvniaccumulatedgrossunrealizedgainbeforetax": 105000000,
"equitysecuritiesfvniaccumulatedgrossunrealizedlossbeforetax": 3000000,
"equitysecuritiesfvnicurrentandnoncurrent": 1395000000,
"availableforsaledebtsecuritiesamortizedcostbasis": 132108000000,
"availableforsaledebtsecuritiesaccumulatedgrossunrealizedgainbeforetax": 583000000,
"availableforsaledebtsecuritiesaccumulatedgrossunrealizedlossbeforetax": 4635000000,
"availableforsalesecuritiesdebtsecurities": 128056000000,
"cashcashequivalentsandmarketablesecuritiescost": 160600000000,
"cashequivalentsandmarketablesecuritiesaccumulatedgrossunrealizedgainbeforetax": 688000000,
"cashequivalentsandmarketablesecuritiesaccumulatedgrossunrealizedlossbeforetax": 4638000000,
"cashcashequivalentsandmarketablesecurities": 156650000000,
"restrictedcashandcashequivalents": 2600000000,
"debtsecuritiesavailableforsalerestricted": 13200000000,
"debtsecuritiesavailableforsalematurityallocatedandsinglematuritydaterollingafteronethroughfiveyearspercentage": 0.14,
"debtsecuritiesavailableforsalematurityallocatedandsinglematuritydaterollingafterfivethroughtenyearspercentage": 0.09,
"debtsecuritiesavailableforsalematurityallocatedandsinglematuritydaterollingaftertenyearspercentage": 0.77,
"maximumlengthoftimeforeigncurrencycashflowhedge": "P18Y",
"concentrationriskpercentage1": 0.23,
"numberofsignificantvendors": 2,
"derivativenotionalamount": 91493000000,
"hedgedassetstatementoffinancialpositionextensibleenumeration": "http://fasb.org/us-gaap/2024#MarketableSecuritiesCurrent http://fasb.org/us-gaap/2024#MarketableSecuritiesNoncurrent",
"hedgedliabilityfairvaluehedge": 13505000000,
"hedgedliabilitystatementoffinancialpositionextensibleenumeration": "http://fasb.org/us-gaap/2024#LongTermDebtCurrent http://fasb.org/us-gaap/2024#LongTermDebtNoncurrent",
"propertyplantandequipmentgross": 119128000000,
"accumulateddepreciationdepletionandamortizationpropertyplantandequipment": 73448000000,
"depreciation": 8200000000,
"deferredincometaxassetsnet": 19499000000,
"otherassetsmiscellaneousnoncurrent": 55335000000,
"accruedincometaxescurrent": 1200000000,
"otheraccruedliabilitiescurrent": 51703000000,
"accruedincometaxesnoncurrent": 9254000000,
"otheraccruedliabilitiesnoncurrent": 36634000000,
"totalrestrictedcashcashequivalentsandavailableforsaledebtsecurities": 15800000000,
"currentforeigntaxexpensebenefit": 25483000000,
"currentfederaltaxexpensebenefit": 5571000000,
"unrecognizedtaxbenefitsdecreasesresultingfromsettlementswithtaxingauthorities": 1070000000,
"incomelossfromcontinuingoperationsbeforeincometaxesforeign": 77300000000,
"effectiveincometaxratereconciliationatfederalstatutoryincometaxrate": 0.21,
"deferredtaxassetstaxcreditcarryforwardsforeign": 5100000000,
"deferredtaxassetstaxcreditcarryforwardsresearch": 3600000000,
"unrecognizedtaxbenefits": 22038000000,
"unrecognizedtaxbenefitsthatwouldimpacteffectivetaxrate": 10800000000,
"decreaseinunrecognizedtaxbenefitsisreasonablypossible": 13000000000,
"deferredfederalincometaxexpensebenefit": -3080000000,
"federalincometaxexpensebenefitcontinuingoperations": 2491000000,
"currentstateandlocaltaxexpensebenefit": 1726000000,
"deferredstateandlocalincometaxexpensebenefit": -298000000,
"stateandlocalincometaxexpensebenefitcontinuingoperations": 1428000000,
"deferredforeignincometaxexpensebenefit": 347000000,
"foreignincometaxexpensebenefitcontinuingoperations": 25830000000,
"incometaxreconciliationincometaxexpensebenefitatfederalstatutoryincometaxrate": 25932000000,
"incometaxreconciliationstateandlocalincometaxes": 1162000000,
"effectiveincometaxratereconciliationimpactofthestateaiddecisionamount": 10246000000,
"incometaxreconciliationforeignincometaxratedifferential": -5311000000,
"incometaxreconciliationtaxcreditsresearch": 1397000000,
"effectiveincometaxratereconciliationsharebasedcompensationexcesstaxbenefitamount": -893000000,
"incometaxreconciliationotheradjustments": 10000000,
"effectiveincometaxratecontinuingoperations": 0.241,
"deferredtaxassetscapitalizedresearchanddevelopment": 10739000000,
"deferredtaxassetstaxcreditcarryforwards": 8856000000,
"deferredtaxassetstaxdeferredexpensereservesandaccruals": 6114000000,
"deferredtaxassetsdeferredincome": 3413000000,
"deferredtaxassetsleaseliabilities": 2410000000,
"deferredtaxassetsothercomprehensiveloss": 1173000000,
"deferredtaxassetsother": 2168000000,
"deferredtaxassetsgross": 34873000000,
"deferredtaxassetsvaluationallowance": 8866000000,
"deferredtaxassetsnet": 26007000000,
"deferredtaxliabilitiespropertyplantandequipment": 2551000000,
"deferredtaxliabilitiesleasingarrangements": 2125000000,
"deferredtaxliabilitiesminimumtaxonforeignearnings": 1674000000,
"deferredtaxliabilitiesother": 455000000,
"deferredincometaxliabilities": 6805000000,
"deferredtaxassetsliabilitiesnet": 19202000000,
"unrecognizedtaxbenefitsincreasesresultingfrompriorperiodtaxpositions": 1727000000,
"unrecognizedtaxbenefitsdecreasesresultingfrompriorperiodtaxpositions": 386000000,
"unrecognizedtaxbenefitsincreasesresultingfromcurrentperiodtaxpositions": 2542000000,
"unrecognizedtaxbenefitsreductionsresultingfromlapseofapplicablestatuteoflimitations": 229000000,
"lesseeoperatingandfinanceleasetermofcontract": "P10Y",
"operatingleasecost": 2000000000,
"variableleasecost": 13800000000,
"operatingleasepayments": 1900000000,
"rightofuseassetsobtainedinexchangeforoperatingandfinanceleaseliabilities": 1000000000,
"operatingandfinanceleaseweightedaverageremainingleaseterm": "P10Y3M18D",
"operatingandfinanceleaseweightedaveragediscountratepercent": 0.031,
"unrecordedunconditionalpurchaseobligationbalancesheetamount": 11226000000,
"lesseeoperatingandfinanceleaseleasenotyetcommencedtermofcontract": "P21Y",
"operatingleaserightofuseasset": 10234000000,
"operatingleaserightofuseassetstatementoffinancialpositionextensiblelist": "http://fasb.org/us-gaap/2024#OtherAssetsNoncurrent",
"financeleaserightofuseasset": 1069000000,
"financeleaserightofuseassetstatementoffinancialpositionextensiblelist": "http://fasb.org/us-gaap/2024#PropertyPlantAndEquipmentNet",
"operatingandfinanceleaserightofuseasset": 11303000000,
"operatingleaseliabilitycurrent": 1488000000,
"operatingleaseliabilitycurrentstatementoffinancialpositionextensiblelist": "http://fasb.org/us-gaap/2024#OtherLiabilitiesCurrent",
"operatingleaseliabilitynoncurrent": 10046000000,
"operatingleaseliabilitynoncurrentstatementoffinancialpositionextensiblelist": "http://fasb.org/us-gaap/2024#OtherLiabilitiesNoncurrent",
"financeleaseliabilitycurrent": 144000000,
"financeleaseliabilitycurrentstatementoffinancialpositionextensiblelist": "http://fasb.org/us-gaap/2024#OtherLiabilitiesCurrent",
"financeleaseliabilitynoncurrent": 752000000,
"financeleaseliabilitynoncurrentstatementoffinancialpositionextensiblelist": "http://fasb.org/us-gaap/2024#OtherLiabilitiesNoncurrent",
"operatingandfinanceleaseliability": 12430000000,
"lesseeoperatingleaseliabilitypaymentsduenexttwelvemonths": 1820000000,
"lesseeoperatingleaseliabilitypaymentsdueyeartwo": 1914000000,
"lesseeoperatingleaseliabilitypaymentsdueyearthree": 1674000000,
"lesseeoperatingleaseliabilitypaymentsdueyearfour": 1360000000,
"lesseeoperatingleaseliabilitypaymentsdueyearfive": 1187000000,
"lesseeoperatingleaseliabilitypaymentsdueafteryearfive": 5563000000,
"lesseeoperatingleaseliabilitypaymentsdue": 13518000000,
"lesseeoperatingleaseliabilityundiscountedexcessamount": 1984000000,
"operatingleaseliability": 11534000000,
"financeleaseliabilitypaymentsduenexttwelvemonths": 171000000,
"financeleaseliabilitypaymentsdueyeartwo": 131000000,
"financeleaseliabilitypaymentsdueyearthree": 59000000,
"financeleaseliabilitypaymentsdueyearfour": 38000000,
"financeleaseliabilitypaymentsdueyearfive": 36000000,
"financeleaseliabilitypaymentsdueafteryearfive": 837000000,
"financeleaseliabilitypaymentsdue": 1272000000,
"financeleaseliabilityundiscountedexcessamount": 376000000,
"financeleaseliability": 896000000,
"lesseeoperatingandfinanceleaseliabilitytobepaidyearone": 1991000000,
"lesseeoperatingandfinanceleaseliabilitytobepaidyeartwo": 2045000000,
"lesseeoperatingandfinanceleaseliabilitytobepaidyearthree": 1733000000,
"lesseeoperatingandfinanceleaseliabilitytobepaidyearfour": 1398000000,
"lesseeoperatingandfinanceleaseliabilitytobepaidyearfive": 1223000000,
"lesseeoperatingandfinanceleaseliabilitytobepaidafteryearfive": 6400000000,
"lesseeoperatingandfinanceleaseliabilitytobepaid": 14790000000,
"lesseeoperatingandfinanceleaseliabilityundiscountedexcessamount": 2360000000,
"debtinstrumentterm": "P9M",
"shorttermdebtweightedaverageinterestrate": 0.05,
"longtermdebtfairvalue": 88400000000,
"proceedsfromrepaymentsofshorttermdebtmaturinginthreemonthsorless": 3960000000,
"debtinstrumentcarryingamount": 97341000000,
"debtinstrumentunamortizeddiscountpremiumanddebtissuancecostsnet": 321000000,
"hedgeaccountingadjustmentsrelatedtolongtermdebt": 358000000,
"longtermdebt": 96662000000,
"debtinstrumentmaturityyearrangestart": 2024,
"debtinstrumentmaturityyearrangeend": 2062,
"debtinstrumentinterestratestatedpercentage": 0.0485,
"debtinstrumentinterestrateeffectivepercentage": 0.0665,
"longtermdebtmaturitiesrepaymentsofprincipalinnexttwelvemonths": 10930000000,
"longtermdebtmaturitiesrepaymentsofprincipalinyeartwo": 12342000000,
"longtermdebtmaturitiesrepaymentsofprincipalinyearthree": 9936000000,
"longtermdebtmaturitiesrepaymentsofprincipalinyearfour": 7800000000,
"longtermdebtmaturitiesrepaymentsofprincipalinyearfive": 5153000000,
"longtermdebtmaturitiesrepaymentsofprincipalafteryearfive": 51180000000,
"stockrepurchasedandretiredduringperiodshares": 499372000,
"stockissuedduringperiodsharessharebasedpaymentarrangementnetofshareswithheldfortaxes": 66097000,
"sharebasedcompensationarrangementbysharebasedpaymentawardawardvestingperiod1": "P4Y",
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsnumberofsharesofcommonstockissuedperunituponvesting": 1,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsvestedinperiodtotalfairvalue": 15800000000,
"sharespaidfortaxwithholdingforsharebasedcompensation": 31000000,
"employeeservicesharebasedcompensationnonvestedawardstotalcompensationcostnotyetrecognized": 19400000000,
"employeeservicesharebasedcompensationnonvestedawardstotalcompensationcostnotyetrecognizedperiodforrecognition1": "P2Y4M24D",
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsnonvestednumber": 163326000,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsgrantsinperiod": 80456000,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsvestedinperiod": 87633000,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsforfeitedinperiod": 9744000,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsnonvestedweightedaveragegrantdatefairvalue": 158.73,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsgrantsinperiodweightedaveragegrantdatefairvalue": 173.78,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsvestedinperiodweightedaveragegrantdatefairvalue": 127.59,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsforfeituresweightedaveragegrantdatefairvalue": 140.8,
"sharebasedcompensationarrangementbysharebasedpaymentawardequityinstrumentsotherthanoptionsaggregateintrinsicvaluenonvested": 37204000000,
"allocatedsharebasedcompensationexpense": 11688000000,
"employeeservicesharebasedcompensationtaxbenefitfromcompensationexpense": 3350000000,
"unrecordedunconditionalpurchaseobligationbalanceonfirstanniversary": 3206000000,
"unrecordedunconditionalpurchaseobligationbalanceonsecondanniversary": 2440000000,
"unrecordedunconditionalpurchaseobligationbalanceonthirdanniversary": 1156000000,
"unrecordedunconditionalpurchaseobligationbalanceonfourthanniversary": 3121000000,
"unrecordedunconditionalpurchaseobligationbalanceonfifthanniversary": 633000000,
"unrecordedunconditionalpurchaseobligationdueafterfiveyears": 670000000,
"othergeneralandadministrativeexpense": 7458000000,
"noncurrentassets": 45680000000,
"trdarrsecuritiesaggavailamt": 100000,
"insidertrdpoliciesprocadoptedflag": "true"
}
}
]
```

### Stock Chart Light API
Access simplified stock chart data using the FMP Basic Stock Chart API. This API provides essential charting information, including date, price, and trading volume, making it ideal for tracking stock performance with minimal data and creating basic price and volume charts.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/light?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Price and Volume Data API
Access full price and volume data for any stock symbol using the FMP Comprehensive Stock Price and Volume Data API. Get detailed insights, including open, high, low, close prices, trading volume, price changes, percentage changes, and volume-weighted average price (VWAP).

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/full?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Unadjusted Stock Price API
Access stock price and volume data without adjustments for stock splits with the FMP Unadjusted Stock Price Chart API. Get accurate insights into stock performance, including open, high, low, and close prices, along with trading volume, without split-related changes.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/non-split-adjusted?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Dividend Adjusted Price Chart API
Analyze stock performance with dividend adjustments using the FMP Dividend-Adjusted Price Chart API. Access end-of-day price and volume data that accounts for dividend payouts, offering a more comprehensive view of stock trends over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/dividend-adjusted?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 1 Min Interval Stock Chart API
Access precise intraday stock price and volume data with the FMP 1-Minute Interval Stock Chart API. Retrieve real-time or historical stock data in 1-minute intervals, including key information such as open, high, low, and close prices, and trading volume for each minute.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 5 Min Interval Stock Chart API
Access stock price and volume data with the FMP 5-Minute Interval Stock Chart API. Retrieve detailed stock data in 5-minute intervals, including open, high, low, and close prices, along with trading volume for each 5-minute period. This API is perfect for short-term trading analysis and building intraday charts.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/5min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 15 Min Interval Stock Chart API
Access stock price and volume data with the FMP 15-Minute Interval Stock Chart API. Retrieve detailed stock data in 15-minute intervals, including open, high, low, close prices, and trading volume. This API is ideal for creating intraday charts and analyzing medium-term price trends during the trading day.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/15min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 30 Min Interval Stock Chart API
Access stock price and volume data with the FMP 30-Minute Interval Stock Chart API. Retrieve essential stock data in 30-minute intervals, including open, high, low, close prices, and trading volume. This API is perfect for creating intraday charts and tracking medium-term price movements for more strategic trading decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/30min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 1 Hour Interval Stock Chart API
Track stock price movements over hourly intervals with the FMP 1-Hour Interval Stock Chart API. Access essential stock price and volume data, including open, high, low, and close prices for each hour, to analyze broader intraday trends with precision.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1hour?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 4 Hour Interval Stock Chart API
Analyze stock price movements over extended intraday periods with the FMP 4-Hour Interval Stock Chart API. Access key stock price and volume data in 4-hour intervals, perfect for tracking longer intraday trends and understanding broader market movements.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/4hour?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Treasury Rates API
Access latest and historical Treasury rates for all maturities with the FMP Treasury Rates API. Track key benchmarks for interest rates across the economy.

#### Request
```http
GET https://financialmodelingprep.com/stable/treasury-rates
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Max 90-day date range

### Sample response
```json
[
{
"date": "2024-02-29",
"month1": 5.53,
"month2": 5.5,
"month3": 5.45,
"month6": 5.3,
"year1": 5.01,
"year2": 4.64,
"year3": 4.43,
"year5": 4.26,
"year7": 4.28,
"year10": 4.25,
"year20": 4.51,
"year30": 4.38
}
]
```

### Economics Indicators API
Access real-time and historical economic data for key indicators like GDP, unemployment, and inflation with the FMP Economic Indicators API. Use this data to measure economic performance and identify growth trends.

#### Request
```http
GET https://financialmodelingprep.com/stable/economic-indicators?name=GDP
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `name*` | `string` | `GDP,realGDP,nominalPotentialGDP,realGDPPerCapita,federalFunds,CPI,inflationRate,inflation,retailSales,consumerSentiment,durableGoods,unemploymentRate,totalNonfarmPayroll,initialClaims,industrialProductionTotalIndex,newPrivatelyOwnedHousingUnitsStartedTotalUnits,totalVehicleSales,retailMoneyFunds,smoothedUSRecessionProbabilities,3MonthOr90DayRatesAndYieldsCertificatesOfDeposit,commercialBankInterestRateOnCreditCardPlansAllAccounts,30YearFixedRateMortgageAverage,15YearFixedRateMortgageAverage,tradeBalanceGoodsAndServices` |
| `from` | `date` | `2024-12-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Max 90-day date range

### Sample response
```json
[
{
"name": "GDP",
"date": "2024-01-01",
"value": 28624.069
}
]
```

### Economic Data Releases Calendar API
Stay informed with the FMP Economic Data Releases Calendar API. Access a comprehensive calendar of upcoming economic data releases to prepare for market impacts and make informed investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/economic-calendar
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Max 90-day date range

### Sample response
```json
[
{
"date": "2024-03-01 03:35:00",
"country": "JP",
"event": "3-Month Bill Auction",
"currency": "JPY",
"previous": -0.112,
"estimate": null,
"actual": -0.096,
"change": 0.016,
"impact": "Low",
"changePercentage": 14.286
}
]
```

### Market Risk Premium API
Access the market risk premium for specific dates with the FMP Market Risk Premium API. Use this key financial metric to assess the additional return expected from investing in the stock market over a risk-free investment.

#### Request
```http
GET https://financialmodelingprep.com/stable/market-risk-premium
```

### Sample response
```json
[
{
"country": "Zimbabwe",
"continent": "Africa",
"countryRiskPremium": 13.17,
"totalEquityRiskPremium": 17.77
}
]
```

### Dividends Company API
Stay informed about upcoming dividend payments with the FMP Dividends Company API. This API provides essential dividend data for individual stock symbols, including record dates, payment dates, declaration dates, and more.

#### Request
```http
GET https://financialmodelingprep.com/stable/dividends?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Dividends Calendar API
Stay informed on upcoming dividend events with the Dividend Events Calendar API. Access a comprehensive schedule of dividend-related dates for all stocks, including record dates, payment dates, declaration dates, and dividend yields.

#### Request
```http
GET https://financialmodelingprep.com/stable/dividends-calendar
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Earnings Report API
Retrieve in-depth earnings information with the FMP Earnings Report API. Gain access to key financial data for a specific stock symbol, including earnings report dates, EPS estimates, and revenue projections to help you stay on top of company performance.

#### Request
```http
GET https://financialmodelingprep.com/stable/earnings?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Earnings Calendar API
Stay informed on upcoming and past earnings announcements with the FMP Earnings Calendar API. Access key data, including announcement dates, estimated earnings per share (EPS), and actual EPS for publicly traded companies.

#### Request
```http
GET https://financialmodelingprep.com/stable/earnings-calendar
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### IPOs Calendar API
Access a comprehensive list of all upcoming initial public offerings (IPOs) with the FMP IPO Calendar API. Stay up to date on the latest companies entering the public market, with essential details on IPO dates, company names, expected pricing, and exchange listings.

#### Request
```http
GET https://financialmodelingprep.com/stable/ipos-calendar
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### IPOs Disclosure API
Access a comprehensive list of disclosure filings for upcoming initial public offerings (IPOs) with the FMP IPO Disclosures API. Stay updated on regulatory filings, including filing dates, effectiveness dates, CIK numbers, and form types, with direct links to official SEC documents.

#### Request
```http
GET https://financialmodelingprep.com/stable/ipos-disclosure
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### IPOs Prospectus API
Access comprehensive information on IPO prospectuses with the FMP IPO Prospectus API. Get key financial details, such as public offering prices, discounts, commissions, proceeds before expenses, and more. This API also provides links to official SEC prospectuses, helping investors stay informed on companies entering the public market.

#### Request
```http
GET https://financialmodelingprep.com/stable/ipos-prospectus
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Split Details API
Access detailed information on stock splits for a specific company using the FMP Stock Split Details API. This API provides essential data, including the split date and the split ratio, helping users understand changes in a company's share structure after a stock split.

#### Request
```http
GET https://financialmodelingprep.com/stable/splits?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Splits Calendar API
Stay informed about upcoming stock splits with the FMP Stock Splits Calendar API. This API provides essential data on upcoming stock splits across multiple companies, including the split date and ratio, helping you track changes in share structures before they occur.

#### Request
```http
GET https://financialmodelingprep.com/stable/splits-calendar
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest Earning Transcripts API
Access available earnings transcripts for companies with the FMP Latest Earning Transcripts API. Retrieve a list of companies with earnings transcripts, along with the total number of transcripts available for each company.

#### Request
```http
GET https://financialmodelingprep.com/stable/earning-call-transcript-latest
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Earnings Transcript API
Access the full transcript of a company’s earnings call with the FMP Earnings Transcript API. Stay informed about a company’s financial performance, future plans, and overall strategy by analyzing management's communication.

#### Request
```http
GET https://financialmodelingprep.com/stable/earning-call-transcript?symbol=AAPL&year=2020&quarter=3
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Transcripts Dates By Symbol API
Access earnings call transcript dates for specific companies with the FMP Transcripts Dates By Symbol API. Get a comprehensive overview of earnings call schedules based on fiscal year and quarter.

#### Request
```http
GET https://financialmodelingprep.com/stable/earning-call-transcript-dates?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Available Transcript Symbols API
Access a complete list of stock symbols with available earnings call transcripts using the FMP Available Earnings Transcript Symbols API. Retrieve information on which companies have earnings transcripts and how many are accessible for detailed financial analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/earnings-transcript-list
```

### FMP Articles API
Access the latest articles from Financial Modeling Prep with the FMP Articles API. Get comprehensive updates including headlines, snippets, and publication URLs.

#### Request
```http
GET https://financialmodelingprep.com/stable/fmp-articles?page=0&limit=20
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### General News API
Access the latest general news articles from a variety of sources with the FMP General News API. Obtain headlines, snippets, and publication URLs for comprehensive news coverage.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/general-latest?page=0&limit=20
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Press Releases API
Access official company press releases with the FMP Press Releases API. Get real-time updates on corporate announcements, earnings reports, mergers, and more.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/press-releases-latest?page=0&limit=20
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock News API
Stay informed with the latest stock market news using the FMP Stock News Feed API. Access headlines, snippets, publication URLs, and ticker symbols for the most recent articles from a variety of sources.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/stock-latest?page=0&limit=20
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Crypto News API
Stay informed with the latest cryptocurrency news using the FMP Crypto News API. Access a curated list of articles from various sources, including headlines, snippets, and publication URLs.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/crypto-latest?page=0&limit=20
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Forex News API
Stay updated with the latest forex news articles from various sources using the FMP Forex News API. Access headlines, snippets, and publication URLs for comprehensive market insights.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/forex-latest?page=0&limit=20
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Search Press Releases API
Search for company press releases with the FMP Search Press Releases API. Find specific corporate announcements and updates by entering a stock symbol or company name.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/press-releases?symbols=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Search Stock News API
Search for stock-related news using the FMP Search Stock News API. Find specific stock news by entering a ticker symbol or company name to track the latest developments.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/stock?symbols=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Search Crypto News API
Search for cryptocurrency news using the FMP Search Crypto News API. Retrieve news related to specific coins or tokens by entering their name or symbol.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/crypto?symbols=BTCUSD
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Search Forex News API
Search for foreign exchange news using the FMP Search Forex News API. Find targeted news on specific currency pairs by entering their symbols for focused updates.

#### Request
```http
GET https://financialmodelingprep.com/stable/news/forex?symbols=EURUSD
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Institutional Ownership Filings API
Stay up to date with the most recent SEC filings related to institutional ownership using the Institutional Ownership Filings API. This tool allows you to track the latest reports and disclosures from institutional investors, giving you a real-time view of major holdings and regulatory submissions.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/latest?page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Filings Extract API
The SEC Filings Extract API allows users to extract detailed data directly from official SEC filings. This API provides access to key information such as company shares, security details, and filing links, making it easier to analyze corporate disclosures.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/extract?cik=0001388838&year=2023&quarter=3
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Form 13F Filings Dates API
The Form 13F Filings Dates API allows you to retrieve dates associated with Form 13F filings by institutional investors. This is crucial for tracking stock holdings of institutional investors at specific points in time, providing valuable insights into their investment strategies.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/dates?cik=0001067983
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Filings Extract With Analytics By Holder API
The Filings Extract With Analytics By Holder API provides an analytical breakdown of institutional filings. This API offers insight into stock movements, strategies, and portfolio changes by major institutional holders, helping you understand their investment behavior and track significant changes in stock ownership.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/extract-analytics/holder?symbol=AAPL&year=2023&quarter=3&page=0&limit=10
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Holder Performance Summary API
The Holder Performance Summary API provides insights into the performance of institutional investors based on their stock holdings. This data helps track how well institutional holders are performing, their portfolio changes, and how their performance compares to benchmarks like the S&P 500.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/holder-performance-summary?cik=0001067983&page=0
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Holders Industry Breakdown API
The Holders Industry Breakdown API provides an overview of the sectors and industries that institutional holders are investing in. This API helps analyze how institutional investors distribute their holdings across different industries and track changes in their investment strategies over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/holder-industry-breakdown?cik=0001067983&year=2023&quarter=3
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Positions Summary API
The Positions Summary API provides a comprehensive snapshot of institutional holdings for a specific stock symbol. It tracks key metrics like the number of investors holding the stock, changes in the number of shares, total investment value, and ownership percentages over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/symbol-positions-summary?symbol=AAPL&year=2023&quarter=3
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Industry Performance Summary API
The Industry Performance Summary API provides an overview of how various industries are performing financially. By analyzing the value of industries over a specific period, this API helps investors and analysts understand the health of entire sectors and make informed decisions about sector-based investments.

#### Request
```http
GET https://financialmodelingprep.com/stable/institutional-ownership/industry-summary?year=2023&quarter=3
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Financial Estimates API
Retrieve analyst financial estimates for stock symbols with the FMP Financial Estimates API. Access projected figures like revenue, earnings per share (EPS), and other key financial metrics as forecasted by industry analysts to inform your investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/analyst-estimates?symbol=AAPL&period=annual&page=0&limit=10
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Ratings Snapshot API
Quickly assess the financial health and performance of companies with the FMP Ratings Snapshot API. This API provides a comprehensive snapshot of financial ratings for stock symbols in our database, based on various key financial ratios.

#### Request
```http
GET https://financialmodelingprep.com/stable/ratings-snapshot?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Ratings API
Track changes in financial performance over time with the FMP Historical Ratings API. This API provides access to historical financial ratings for stock symbols in our database, allowing users to view ratings and key financial metric scores for specific dates.

#### Request
```http
GET https://financialmodelingprep.com/stable/ratings-historical?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Price Target Summary API
Gain insights into analysts' expectations for stock prices with the FMP Price Target Summary API. This API provides access to average price targets from analysts across various timeframes, helping investors assess future stock performance based on expert opinions.

#### Request
```http
GET https://financialmodelingprep.com/stable/price-target-summary?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Price Target Consensus API
Access analysts' consensus price targets with the FMP Price Target Consensus API. This API provides high, low, median, and consensus price targets for stocks, offering investors a comprehensive view of market expectations for future stock prices.

#### Request
```http
GET https://financialmodelingprep.com/stable/price-target-consensus?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Grades API
Access the latest stock grades from top analysts and financial institutions with the FMP Grades API. Track grading actions, such as upgrades, downgrades, or maintained ratings, for specific stock symbols, providing valuable insight into how experts evaluate companies over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/grades?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Stock Grades API
Access a comprehensive record of analyst grades with the FMP Historical Grades API. This tool allows you to track historical changes in analyst ratings for specific stock symbol

#### Request
```http
GET https://financialmodelingprep.com/stable/grades-historical?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Stock Grades Summary API
Quickly access an overall view of analyst ratings with the FMP Grades Summary API. This API provides a consolidated summary of market sentiment for individual stock symbols, including the total number of strong buy, buy, hold, sell, and strong sell ratings. Understand the overall consensus on a stock’s outlook with just a few data points.

#### Request
```http
GET https://financialmodelingprep.com/stable/grades-consensus?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Market Sector Performance Snapshot API
Get a snapshot of sector performance using the Market Sector Performance Snapshot API. Analyze how different industries are performing in the market based on average changes across sectors.

#### Request
```http
GET https://financialmodelingprep.com/stable/sector-performance-snapshot?date=2024-02-01
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Industry Performance Snapshot API
Access detailed performance data by industry using the Industry Performance Snapshot API. Analyze trends, movements, and daily performance metrics for specific industries across various stock exchanges.

#### Request
```http
GET https://financialmodelingprep.com/stable/industry-performance-snapshot?date=2024-02-01
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Market Sector Performance API
Access historical sector performance data using the Historical Market Sector Performance API. Review how different sectors have performed over time across various stock exchanges.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-sector-performance?sector=Energy
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Industry Performance API
Access historical performance data for industries using the Historical Industry Performance API. Track long-term trends and analyze how different industries have evolved over time across various stock exchanges.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-industry-performance?industry=Biotechnology
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Sector PE Snapshot API
Retrieve the price-to-earnings (P/E) ratios for various sectors using the Sector P/E Snapshot API. Compare valuation levels across sectors to better understand market valuations.

#### Request
```http
GET https://financialmodelingprep.com/stable/sector-pe-snapshot?date=2024-02-01
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Industry PE Snapshot API
View price-to-earnings (P/E) ratios for different industries using the Industry P/E Snapshot API. Analyze valuation levels across various industries to understand how each is priced relative to its earnings.

#### Request
```http
GET https://financialmodelingprep.com/stable/industry-pe-snapshot?date=2024-02-01
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Sector PE API
Access historical price-to-earnings (P/E) ratios for various sectors using the Historical Sector P/E API. Analyze how sector valuations have evolved over time to understand long-term trends and market shifts.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-sector-pe?sector=Energy
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Industry PE API
Access historical price-to-earnings (P/E) ratios by industry using the Historical Industry P/E API. Track valuation trends across various industries to understand how market sentiment and valuations have evolved over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-industry-pe?industry=Biotechnology
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Biggest Stock Gainers API
Track the stocks with the largest price increases using the Top Stock Gainers API. Identify the companies that are leading the market with significant price surges, offering potential growth opportunities.

#### Request
```http
GET https://financialmodelingprep.com/stable/biggest-gainers
```

### Biggest Stock Losers API
Access data on the stocks with the largest price drops using the Biggest Stock Losers API. Identify companies experiencing significant declines and track the stocks that are falling the fastest in the market.

#### Request
```http
GET https://financialmodelingprep.com/stable/biggest-losers
```

### Top Traded Stocks API
View the most actively traded stocks using the Top Traded Stocks API. Identify the companies experiencing the highest trading volumes in the market and track where the most trading activity is happening.

#### Request
```http
GET https://financialmodelingprep.com/stable/most-actives
```

### Simple Moving Average API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/sma?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"sma": 231.215
}
]
```

### Exponential Moving Average API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/ema?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"ema": 232.8406611792779
}
]
```

### Weighted Moving Average API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/wma?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"wma": 233.04745454545454
}
]
```

### Double Exponential Moving Average API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/dema?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"dema": 232.10592058582725
}
]
```

### Triple Exponential Moving Average API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/tema?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"tema": 233.66383715917516
}
]
```

### Relative Strength Index API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/rsi?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"rsi": 47.64507340768903
}
]
```

### Standard Deviation API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/standarddeviation?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"standardDeviation": 6.139182763202282
}
]
```

### Williams API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/williams?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"williams": -52.51824817518242
}
]
```

### Average Directional Index API
#### Request
```http
GET https://financialmodelingprep.com/stable/technical-indicators/adx?symbol=AAPL&periodLength=10&timeframe=1day
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `periodLength*` | `number` | `10` |
| `timeframe*` | `string` | `1min,5min,15min,30min,1hour,4hour,1day` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-02-04 00:00:00",
"open": 227.2,
"high": 233.13,
"low": 226.65,
"close": 232.8,
"volume": 44489128,
"adx": 26.414065772772613
}
]
```

### ETF & Fund Holdings API
Get a detailed breakdown of the assets held within ETFs and mutual funds using the FMP ETF & Fund Holdings API. Access real-time data on the specific securities and their weights in the portfolio, providing insights into asset composition and fund strategies.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf/holdings?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ETF & Mutual Fund Information API
Access comprehensive data on ETFs and mutual funds with the FMP ETF & Mutual Fund Information API. Retrieve essential details such as ticker symbol, fund name, expense ratio, assets under management, and more.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf/info?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ETF & Fund Country Allocation API
Gain insight into how ETFs and mutual funds distribute assets across different countries with the FMP ETF & Fund Country Allocation API. This tool provides detailed information on the percentage of assets allocated to various regions, helping you make informed investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf/country-weightings?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ETF Asset Exposure API
Discover which ETFs hold specific stocks with the FMP ETF Asset Exposure API. Access detailed information on market value, share numbers, and weight percentages for assets within ETFs.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf/asset-exposure?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ETF Sector Weighting API
The FMP ETF Sector Weighting API provides a breakdown of the percentage of an ETF's assets that are invested in each sector. For example, an investor may want to invest in an ETF that has a high exposure to the technology sector if they believe that the technology sector is poised for growth.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf/sector-weightings?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Mutual Fund & ETF Disclosure API
Access the latest disclosures from mutual funds and ETFs with the FMP Mutual Fund & ETF Disclosure API. This API provides updates on filings, changes in holdings, and other critical disclosure data for mutual funds and ETFs.

#### Request
```http
GET https://financialmodelingprep.com/stable/funds/disclosure-holders-latest?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Mutual Fund Disclosures API
Access comprehensive disclosure data for mutual funds with the FMP Mutual Fund Disclosures API. Analyze recent filings, balance sheets, and financial reports to gain insights into mutual fund portfolios.

#### Request
```http
GET https://financialmodelingprep.com/stable/funds/disclosure?symbol=AAPL&year=2023&quarter=4
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Mutual Fund & ETF Disclosure Name Search API
Easily search for mutual fund and ETF disclosures by name using the Mutual Fund & ETF Disclosure Name Search API. This API allows you to find specific reports and filings based on the fund or ETF name, providing essential details like CIK number, entity information, and reporting file number.

#### Request
```http
GET https://financialmodelingprep.com/stable/funds/disclosure-holders-search?name=Federated Hermes Government Income Securities, Inc.
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Fund & ETF Disclosures by Date API
Retrieve detailed disclosures for mutual funds and ETFs based on filing dates with the FMP Fund & ETF Disclosures by Date API. Stay current with the latest filings and track regulatory updates effectively.

#### Request
```http
GET https://financialmodelingprep.com/stable/funds/disclosure-dates?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest 8-K SEC Filings API
Stay up-to-date with the most recent 8-K filings from publicly traded companies using the FMP Latest 8-K SEC Filings API. Get real-time access to significant company events such as mergers, acquisitions, leadership changes, and other material events that may impact the market.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-8k?from=2024-01-01&to=2024-03-01&page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest SEC Filings API
Stay updated with the most recent SEC filings from publicly traded companies using the FMP Latest SEC Filings API. Access essential regulatory documents, including financial statements, annual reports, 8-K, 10-K, and 10-Q forms.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-financials?from=2024-01-01&to=2024-03-01&page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Filings By Form Type API
Search for specific SEC filings by form type with the FMP SEC Filings By Form Type API. Retrieve filings such as 10-K, 10-Q, 8-K, and others, filtered by the exact type of document you're looking for.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-search/form-type?formType=8-K&from=2024-01-01&to=2024-03-01&page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Filings By Symbol API
Search and retrieve SEC filings by company symbol using the FMP SEC Filings By Symbol API. Gain direct access to regulatory filings such as 8-K, 10-K, and 10-Q reports for publicly traded companies.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-search/symbol?symbol=AAPL&from=2024-01-01&to=2024-03-01&page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Filings By CIK API
Search for SEC filings using the FMP SEC Filings By CIK API. Access detailed regulatory filings by Central Index Key (CIK) number, enabling you to track all filings related to a specific company or entity.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-search/cik?cik=0000320193&from=2024-01-01&to=2024-03-01&page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Filings By Name API
Search for SEC filings by company or entity name using the FMP SEC Filings By Name API. Quickly retrieve official filings for any organization based on its name.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-company-search/name?company=Berkshire
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Filings Company Search By Symbol API
Find company information and regulatory filings using a stock symbol with the FMP SEC Filings Company Search By Symbol API. Quickly access essential company details based on stock ticker symbols.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-company-search/symbol?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Filings Company Search By CIK API
Easily find company information using a CIK (Central Index Key) with the FMP SEC Filings Company Search By CIK API. Access essential company details and filings linked to a specific CIK number.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-filings-company-search/cik?cik=0000320193
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### SEC Company Full Profile API
Retrieve detailed company profiles, including business descriptions, executive details, contact information, and financial data with the FMP SEC Company Full Profile API.

#### Request
```http
GET https://financialmodelingprep.com/stable/sec-profile?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Industry Classification List API
Retrieve a comprehensive list of industry classifications, including Standard Industrial Classification (SIC) codes and industry titles with the FMP Industry Classification List API.

#### Request
```http
GET https://financialmodelingprep.com/stable/standard-industrial-classification-list
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Industry Classification Search API
Search and retrieve industry classification details for companies, including SIC codes, industry titles, and business information, with the FMP Industry Classification Search API.

#### Request
```http
GET https://financialmodelingprep.com/stable/industry-classification-search
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### All Industry Classification API
Access comprehensive industry classification data for companies across all sectors with the FMP All Industry Classification API. Retrieve key details such as SIC codes, industry titles, and business contact information.

#### Request
```http
GET https://financialmodelingprep.com/stable/all-industry-classification
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest Insider Trading API
Access the latest insider trading activity using the Latest Insider Trading API. Track which company insiders are buying or selling stocks and analyze their transactions.

#### Request
```http
GET https://financialmodelingprep.com/stable/insider-trading/latest?page=0&limit=100
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `date` | `date` | `2025-09-09` |
| `page` | `number` | `0` |
| `limit` | `number` | `100` |

> (*) Required | Maximum 1000 records per request | Page maxed at 100

### Sample response
```json
[
{
"symbol": "APA",
"filingDate": "2025-02-04",
"transactionDate": "2025-02-01",
"reportingCik": "0001380034",
"companyCik": "0001841666",
"transactionType": "M-Exempt",
"securitiesOwned": 104398,
"reportingName": "Hoyt Rebecca A",
"typeOfOwner": "officer: Sr. VP, Chief Acct Officer",
"acquisitionOrDisposition": "A",
"directOrIndirect": "D",
"formType": "4",
"securitiesTransacted": 3450,
"price": 0,
"securityName": "Common Stock",
"url": "https://www.sec.gov/Archives/edgar/data/1841666/000194906025000035/0001949060-25-000035-index.htm"
}
]
```

### Search Insider Trades API
Search insider trading activity by company or symbol using the Search Insider Trades API. Find specific trades made by corporate insiders, including executives and directors.

#### Request
```http
GET https://financialmodelingprep.com/stable/insider-trading/search?page=0&limit=100
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol` | `string` | `AAPL` |
| `page` | `number` | `0` |
| `limit` | `number` | `100` |
| `reportingCik` | `string` | `0001496686` |
| `companyCik` | `string` | `0000320193` |
| `transactionType` | `string` | `S-Sale` |

> (*) Required | Maximum 1000 records per request | Page maxed at 100

### Sample response
```json
[
{
"symbol": "AAPL",
"filingDate": "2025-02-04",
"transactionDate": "2025-02-03",
"reportingCik": "0001214128",
"companyCik": "0000320193",
"transactionType": "S-Sale",
"securitiesOwned": 4159576,
"reportingName": "LEVINSON ARTHUR D",
"typeOfOwner": "director",
"acquisitionOrDisposition": "D",
"directOrIndirect": "D",
"formType": "4",
"securitiesTransacted": 1516,
"price": 226.3501,
"securityName": "Common Stock",
"url": "https://www.sec.gov/Archives/edgar/data/320193/000032019325000019/0000320193-25-000019-index.htm"
}
]
```

### Search Insider Trades by Reporting Name API
Search for insider trading activity by reporting name using the Search Insider Trades by Reporting Name API. Track trading activities of specific individuals or groups involved in corporate insider transactions.

#### Request
```http
GET https://financialmodelingprep.com/stable/insider-trading/reporting-name?name=Zuckerberg
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `name*` | `string` | `Zuckerberg` |

> (*) Required

### Sample response
```json
[
{
"reportingCik": "0001548760",
"reportingName": "Zuckerberg Mark"
}
]
```

### All Insider Transaction Types API
Access a comprehensive list of insider transaction types with the All Insider Transaction Types API. This API provides details on various transaction actions, including purchases, sales, and other corporate actions involving insider trading.

#### Request
```http
GET https://financialmodelingprep.com/stable/insider-trading-transaction-type
```

### Sample response
```json
[
{
"transactionType": "A-Award"
}
]
```

### Insider Trade Statistics API
Analyze insider trading activity with the Insider Trade Statistics API. This API provides key statistics on insider transactions, including total purchases, sales, and trends for specific companies or stock symbols.

#### Request
```http
GET https://financialmodelingprep.com/stable/insider-trading/statistics?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |

> (*) Required

### Sample response
```json
[
{
"symbol": "AAPL",
"cik": "0000320193",
"year": 2024,
"quarter": 4,
"acquiredTransactions": 6,
"disposedTransactions": 38,
"acquiredDisposedRatio": 0.1579,
"totalAcquired": 994544,
"totalDisposed": 2297088,
"averageAcquired": 165757.3333,
"averageDisposed": 60449.6842,
"totalPurchases": 0,
"totalSales": 22
}
]
```

### Acquisition Ownership API
Track changes in stock ownership during acquisitions using the Acquisition Ownership API. This API provides detailed information on how mergers, takeovers, or beneficial ownership changes impact the stock ownership structure of a company.

#### Request
```http
GET https://financialmodelingprep.com/stable/acquisition-of-beneficial-ownership?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `AAPL` |
| `limit` | `number` | `2000` |

> (*) Required

### Sample response
```json
[
{
"cik": "0000320193",
"symbol": "AAPL",
"filingDate": "2024-02-14",
"acceptedDate": "2024-02-14",
"cusip": "037833100",
"nameOfReportingPerson": "National Indemnity Company",
"citizenshipOrPlaceOfOrganization": "State of Nebraska",
"soleVotingPower": "0",
"sharedVotingPower": "755059877",
"soleDispositivePower": "0",
"sharedDispositivePower": "755059877",
"amountBeneficiallyOwned": "755059877",
"percentOfClass": "4.8",
"typeOfReportingPerson": "IC, EP, IN, CO",
"url": "https://www.sec.gov/Archives/edgar/data/320193/000119312524036431/d751537dsc13ga.htm"
}
]
```

### Stock Market Indexes List API
Retrieve a comprehensive list of stock market indexes across global exchanges using the FMP Stock Market Indexes List API. This API provides essential information such as the symbol, name, exchange, and currency for each index, helping analysts and investors keep track of various market benchmarks.

#### Request
```http
GET https://financialmodelingprep.com/stable/index-list
```

### Sample response
```json
[
{
"symbol": "^TTIN",
"name": "S&P/TSX Capped Industrials Index",
"exchange": "TSX",
"currency": "CAD"
}
]
```

### Index Quote API
Access real-time stock index quotes with the Stock Index Quote API. Stay updated with the latest price changes, daily highs and lows, volume, and other key metrics for major stock indices around the world.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |

> (*) Required

### Sample response
```json
[
{
"symbol": "^GSPC",
"name": "S&P 500",
"price": 6366.13,
"changePercentage": 0.11354,
"change": 7.22,
"volume": 1498664000,
"dayLow": 6360.57,
"dayHigh": 6379.54,
"yearHigh": 6379.54,
"yearLow": 4835.04,
"marketCap": 0,
"priceAvg50": 6068.663,
"priceAvg200": 5880.0864,
"exchange": "INDEX",
"open": 6368.6,
"previousClose": 6358.91,
"timestamp": 1753374601
}
]
```

### Index Short Quote API
Access concise stock index quotes with the Stock Index Short Quote API. This API provides a snapshot of the current price, change, and volume for stock indexes, making it ideal for users who need a quick overview of market movements.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote-short?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |

> (*) Required

### Sample response
```json
[
{
"symbol": "^GSPC",
"price": 6366.13,
"change": 7.22,
"volume": 1498664000
}
]
```

### All Index Quotes API
The All Index Quotes API provides real-time quotes for a wide range of stock indexes, from major market benchmarks to niche indexes. This API allows users to track market performance across multiple indexes in a single request, giving them a broad view of the financial markets.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-index-quotes
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `short` | `boolean` | `true` |

> (*) Required

### Sample response
```json
[
{
"symbol": "^DJBGIE",
"price": 4155.76,
"change": 1.09,
"volume": 0
}
]
```

### Historical Index Light Chart API
Retrieve end-of-day historical prices for stock indexes using the Historical Price Data API. This API provides essential data such as date, price, and volume, enabling detailed analysis of price movements over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/light?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Maximum 5000 records per request

### Sample response
```json
[
{
"symbol": "^GSPC",
"date": "2025-07-24",
"price": 6365.77,
"volume": 1499302000
}
]
```

### Historical Index Full Chart API
Access full historical end-of-day prices for stock indexes using the Detailed Historical Price Data API. This API provides comprehensive information, including open, high, low, close prices, volume, and additional metrics for detailed financial analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/full?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Maximum 5000 records per request

### Sample response
```json
[
{
"symbol": "^GSPC",
"date": "2025-07-24",
"open": 6368.6,
"high": 6379.54,
"low": 6360.57,
"close": 6365.77,
"volume": 1499302000,
"change": -2.83,
"changePercent": -0.04443677,
"vwap": 6368.63
}
]
```

### 1-Minute Interval Index Price API
Retrieve 1-minute interval intraday data for stock indexes using the Intraday 1-Minute Price Data API. This API provides granular price information, helping users track short-term price movements and trading volume within each minute.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1min?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |
| `from` | `date` | `2024-01-01` |
| `to` | `date` | `2024-03-01` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-07-24 12:29:00",
"open": 6365.34,
"low": 6365.34,
"high": 6366.09,
"close": 6366.09,
"volume": 4428000
}
]
```

### 5-Minute Interval Index Price API
Retrieve 5-minute interval intraday price data for stock indexes using the Intraday 5-Minute Price Data API. This API provides crucial insights into price movements and trading volume within 5-minute windows, ideal for traders who require short-term data.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/5min?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |
| `from` | `date` | `2024-01-01` |
| `to` | `date` | `2024-03-01` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-07-24 12:30:00",
"open": 6366.18,
"low": 6365.57,
"high": 6366.18,
"close": 6365.69,
"volume": 1574690
}
]
```

### 1-Hour Interval Index Price API
Access 1-hour interval intraday data for stock indexes using the Intraday 1-Hour Price Data API. This API provides detailed price movements and volume within hourly intervals, making it ideal for tracking medium-term market trends during the trading day.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1hour?symbol=^GSPC
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `^GSPC` |
| `from` | `date` | `2024-01-01` |
| `to` | `date` | `2024-03-01` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-07-24 12:30:00",
"open": 6366.18,
"low": 6365.57,
"high": 6366.18,
"close": 6365.69,
"volume": 1574690
}
]
```

### S&P 500 Index API
Access detailed data on the S&P 500 index using the S&P 500 Index API. Track the performance and key information of the companies that make up this major stock market index.

#### Request
```http
GET https://financialmodelingprep.com/stable/sp500-constituent
```

### Sample response
```json
[
{
"symbol": "DDOG",
"name": "Datadog",
"sector": "Technology",
"subSector": "Software - Application",
"headQuarter": "New York City, New York",
"dateFirstAdded": "2025-07-09",
"cik": "0001561550",
"founded": "2010"
}
]
```

### Nasdaq Index API
Access comprehensive data for the Nasdaq index with the Nasdaq Index API. Monitor real-time movements and track the historical performance of companies listed on this prominent stock exchange.

#### Request
```http
GET https://financialmodelingprep.com/stable/nasdaq-constituent
```

### Sample response
```json
[
{
"symbol": "ADBE",
"name": "Adobe Inc.",
"sector": "Technology",
"subSector": "Software - Infrastructure",
"headQuarter": "San Jose, CA",
"dateFirstAdded": null,
"cik": "0000796343",
"founded": "1982-12-01"
}
]
```

### Dow Jones API
Access data on the Dow Jones Industrial Average using the Dow Jones API. Track current values, analyze trends, and get detailed information about the companies that make up this important stock index.

#### Request
```http
GET https://financialmodelingprep.com/stable/dowjones-constituent
```

### Sample response
```json
[
{
"symbol": "NVDA",
"name": "Nvidia",
"sector": "Technology",
"subSector": "Semiconductors",
"headQuarter": "Santa Clara, CA",
"dateFirstAdded": "2024-11-08",
"cik": "0001045810",
"founded": "1993-04-05"
}
]
```

### Historical S&P 500 API
Retrieve historical data for the S&P 500 index using the Historical S&P 500 API. Analyze past changes in the index, including additions and removals of companies, to understand trends and performance over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-sp500-constituent
```

### Sample response
```json
[
{
"dateAdded": "July 9, 2025",
"addedSecurity": "Datadog",
"removedTicker": "JNPR",
"removedSecurity": "Juniper Networks",
"date": "2025-07-08",
"symbol": "DDOG",
"reason": "S&P 500 constituent Hewlett Packard Enterprise Co. acquired Juniper Networks."
}
]
```

### Historical Nasdaq API
Access historical data for the Nasdaq index using the Historical Nasdaq API. Analyze changes in the index composition and view how it has evolved over time, including company additions and removals.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-nasdaq-constituent
```

### Sample response
```json
[
{
"dateAdded": "May 19, 2025",
"addedSecurity": "Shopify",
"removedTicker": "MDB",
"removedSecurity": "MongoDB",
"date": "2025-05-18",
"symbol": "SHOP",
"reason": "MongoDB did not meet the minimum monthly weight requirements."
}
]
```

### Historical Dow Jones API
Access historical data for the Dow Jones Industrial Average using the Historical Dow Jones API. Analyze changes in the index’s composition and study its performance across different periods.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-dowjones-constituent
```

### Sample response
```json
[
{
"dateAdded": "November 8, 2024",
"addedSecurity": "Nvidia",
"removedTicker": "INTC",
"removedSecurity": "Intel Corporation",
"date": "2024-11-07",
"symbol": "NVDA",
"reason": "Market capitalization change"
}
]
```

### Global Exchange Market Hours API
Retrieve trading hours for specific stock exchanges using the Global Exchange Market Hours API. Find out the opening and closing times of global exchanges to plan your trading strategies effectively.

#### Request
```http
GET https://financialmodelingprep.com/stable/exchange-market-hours?exchange=NASDAQ
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Holidays By Exchange API
#### Request
```http
GET https://financialmodelingprep.com/stable/holidays-by-exchange?exchange=NASDAQ
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### All Exchange Market Hours API
View the market hours for all exchanges. Check when different markets are active.

#### Request
```http
GET https://financialmodelingprep.com/stable/all-exchange-market-hours
```

### Commodities List API
Access an extensive list of tracked commodities across various sectors, including energy, metals, and agricultural products. The FMP Commodities List API provides essential data on tradable commodities, giving investors the ability to explore market options in real-time.

#### Request
```http
GET https://financialmodelingprep.com/stable/commodities-list
```

### Sample response
```json
[
{
"symbol": "HEUSX",
"name": "Lean Hogs Futures",
"exchange": null,
"tradeMonth": "Dec",
"currency": "USX"
}
]
```

### Commodities Quote API
Access real-time price quotes for all commodities traded worldwide with the FMP Global Commodities Quotes API. Track market movements and identify investment opportunities with comprehensive price data.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |

> (*) Required

### Sample response
```json
[
{
"symbol": "GCUSD",
"name": "Gold Futures",
"price": 3375.3,
"changePercentage": -0.65635,
"change": -22.3,
"volume": 170936,
"dayLow": 3355.2,
"dayHigh": 3401.1,
"yearHigh": 3509.9,
"yearLow": 2354.6,
"marketCap": null,
"priceAvg50": 3358.706,
"priceAvg200": 3054.501,
"exchange": "COMMODITY",
"open": 3398.6,
"previousClose": 3397.6,
"timestamp": 1753372205
}
]
```

### Commodities Quote Short API
Get fast and accurate quotes for commodities with the FMP Commodities Quick Quote API. Instantly access the current price, recent changes, and trading volume for various commodities in real-time.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote-short?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |

> (*) Required

### Sample response
```json
[
{
"symbol": "GCUSD",
"price": 3375.3,
"change": -22.3,
"volume": 170936
}
]
```

### All Commodities Quotes API
Access real-time quotes for multiple commodities at once with the FMP Real-Time Batch Commodities Quotes API. Instantly track price changes, volume, and other key metrics for a broad range of commodities.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-commodity-quotes
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `short` | `boolean` | `true` |

> (*) Required

### Sample response
```json
[
{
"symbol": "DCUSD",
"price": 17.18,
"change": -0.21,
"volume": 284
}
]
```

### Light Chart API
Access historical end-of-day prices for various commodities with the FMP Historical Commodities Price API. Analyze past price movements, trading volume, and trends to support informed decision-making.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/light?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Maximum 5000 records per request

### Sample response
```json
[
{
"symbol": "GCUSD",
"date": "2025-07-24",
"price": 3373.8,
"volume": 174758
}
]
```

### Full Chart API
Access full historical end-of-day price data for commodities with the FMP Comprehensive Commodities Price API. This API enables users to analyze long-term price trends, patterns, and market movements in great detail.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/full?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |
| `from` | `date` | `2025-09-09` |
| `to` | `date` | `2025-12-09` |

> (*) Required | Maximum 5000 records per request

### Sample response
```json
[
{
"symbol": "GCUSD",
"date": "2025-07-24",
"open": 3398.6,
"high": 3401.1,
"low": 3355.2,
"close": 3373.8,
"volume": 174758,
"change": -24.8,
"changePercent": -0.72971223,
"vwap": 3376.7
}
]
```

### 1-Minute Interval Commodities Chart API
Track real-time, short-term price movements for commodities with the FMP 1-Minute Interval Commodities Chart API. This API provides detailed 1-minute interval data, enabling precise monitoring of intraday market changes.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1min?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |
| `from` | `date` | `2024-01-01` |
| `to` | `date` | `2024-03-01` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-07-24 12:18:00",
"open": 3374.5,
"low": 3373.7,
"high": 3374.5,
"close": 3374,
"volume": 123
}
]
```

### 5-Minute Interval Commodities Chart API
Monitor short-term price movements with the FMP 5-Minute Interval Commodities Chart API. This API provides detailed 5-minute interval data, enabling users to track near-term price trends for more strategic trading and investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/5min?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |
| `from` | `date` | `2024-01-01` |
| `to` | `date` | `2024-03-01` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-07-24 12:15:00",
"open": 3374,
"low": 3374,
"high": 3374.8,
"close": 3374.4,
"volume": 193
}
]
```

### 1-Hour Interval Commodities Chart API
Monitor hourly price movements and trends with the FMP 1-Hour Interval Commodities Chart API. This API provides hourly data, offering a detailed look at price fluctuations throughout the trading day to support mid-term trading strategies and market analysis.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1hour?symbol=AAPL
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `symbol*` | `string` | `GCUSD` |
| `from` | `date` | `2024-01-01` |
| `to` | `date` | `2024-03-01` |

> (*) Required

### Sample response
```json
[
{
"date": "2025-07-24 11:30:00",
"open": 3378.4,
"low": 3373.1,
"high": 3378.8,
"close": 3374.4,
"volume": 7108
}
]
```

### DCF Valuation API
Estimate the intrinsic value of a company with the FMP Discounted Cash Flow Valuation API. Calculate the DCF valuation based on expected future cash flows and discount rates.

#### Request
```http
GET https://financialmodelingprep.com/stable/discounted-cash-flow?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Levered DCF API
Analyze a company’s value with the FMP Levered Discounted Cash Flow (DCF) API, which incorporates the impact of debt. This API provides post-debt company valuation, offering investors a more accurate measure of a company's true worth by accounting for its debt obligations.

#### Request
```http
GET https://financialmodelingprep.com/stable/levered-discounted-cash-flow?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Custom DCF Advanced API
Run a tailored Discounted Cash Flow (DCF) analysis using the FMP Custom DCF Advanced API. With detailed inputs, this API allows users to fine-tune their assumptions and variables, offering a more personalized and precise valuation for a company.

#### Request
```http
GET https://financialmodelingprep.com/stable/custom-discounted-cash-flow?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Custom DCF Levered API
Run a tailored Discounted Cash Flow (DCF) analysis using the FMP Custom DCF Advanced API. With detailed inputs, this API allows users to fine-tune their assumptions and variables, offering a more personalized and precise valuation for a company.

#### Request
```http
GET https://financialmodelingprep.com/stable/custom-levered-discounted-cash-flow?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Forex Currency Pairs API
Access a comprehensive list of all currency pairs traded on the forex market with the FMP Forex Currency Pairs API. Analyze and track the performance of currency pairs to make informed investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/forex-list
```

### Forex Quote API
Access real-time forex quotes for currency pairs with the Forex Quote API. Retrieve up-to-date information on exchange rates and price changes to help monitor market movements.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Forex Short Quote API
Quickly access concise forex pair quotes with the Forex Quote Snapshot API. Get a fast look at live currency exchange rates, price changes, and volume in real time.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote-short?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Batch Forex Quotes API
Easily access real-time quotes for multiple forex pairs simultaneously with the Batch Forex Quotes API. Stay updated on global currency exchange rates and monitor price changes across different markets.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-forex-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Forex Light Chart API
Access historical end-of-day forex prices with the Historical Forex Light Chart API. Track long-term price trends across different currency pairs to enhance your trading and analysis strategies.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/light?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Forex Full Chart API
Access comprehensive historical end-of-day forex price data with the Full Historical Forex Chart API. Gain detailed insights into currency pair movements, including open, high, low, close (OHLC) prices, volume, and percentage changes.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/full?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 1-Minute Interval Forex Chart API
Access real-time 1-minute intraday forex data with the 1-Minute Forex Interval Chart API. Track short-term price movements for precise, up-to-the-minute insights on currency pair fluctuations.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 5-Minute Interval Forex Chart API
Track short-term forex trends with the 5-Minute Forex Interval Chart API. Access detailed 5-minute intraday data to monitor currency pair price movements and market conditions in near real-time.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/5min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 1-Hour Interval Forex Chart API
Track forex price movements over the trading day with the 1-Hour Forex Interval Chart API. This tool provides hourly intraday data for currency pairs, giving a detailed view of trends and market shifts.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1hour?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Cryptocurrency List API
Access a comprehensive list of all cryptocurrencies traded on exchanges worldwide with the FMP Cryptocurrencies Overview API. Get detailed information on each cryptocurrency to inform your investment strategies.

#### Request
```http
GET https://financialmodelingprep.com/stable/cryptocurrency-list
```

### Full Cryptocurrency Quote API
Access real-time quotes for all cryptocurrencies with the FMP Full Cryptocurrency Quote API. Obtain comprehensive price data including current, high, low, and open prices.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Cryptocurrency Quote Short API
Access real-time cryptocurrency quotes with the FMP Cryptocurrency Quick Quote API. Get a concise overview of current crypto prices, changes, and trading volume for a wide range of digital assets.

#### Request
```http
GET https://financialmodelingprep.com/stable/quote-short?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### All Cryptocurrencies Quotes API
Access live price data for a wide range of cryptocurrencies with the FMP Real-Time Cryptocurrency Batch Quotes API. Get real-time updates on prices, market changes, and trading volumes for digital assets in a single request.

#### Request
```http
GET https://financialmodelingprep.com/stable/batch-crypto-quotes
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Cryptocurrency Light Chart API
Access historical end-of-day prices for a variety of cryptocurrencies with the Historical Cryptocurrency Price Snapshot API. Track trends in price and trading volume over time to better understand market behavior.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/light?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Historical Cryptocurrency Full Chart API
Access comprehensive end-of-day (EOD) price data for cryptocurrencies with the Full Historical Cryptocurrency Data API. Analyze long-term price trends, market movements, and trading volumes to inform strategic decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-price-eod/full?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 1-Minute Interval Cryptocurrency Data API
Get real-time, 1-minute interval price data for cryptocurrencies with the 1-Minute Cryptocurrency Intraday Data API. Monitor short-term price fluctuations and trading volume to stay updated on market movements.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 5-Minute Interval Cryptocurrency Data API
Analyze short-term price trends with the 5-Minute Interval Cryptocurrency Data API. Access real-time, intraday price data for cryptocurrencies to monitor rapid market movements and optimize trading strategies.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/5min?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### 1-Hour Interval Cryptocurrency Data API
Access detailed 1-hour intraday price data for cryptocurrencies with the 1-Hour Interval Cryptocurrency Data API. Track hourly price movements to gain insights into market trends and make informed trading decisions throughout the day.

#### Request
```http
GET https://financialmodelingprep.com/stable/historical-chart/1hour?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest Senate Financial Disclosures API
Access the latest financial disclosures from U.S. Senate members with the FMP Latest Senate Financial Disclosures API. Track recent trades, asset ownership, and transaction details for enhanced transparency in government financial activities.

#### Request
```http
GET https://financialmodelingprep.com/stable/senate-latest?page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Latest House Financial Disclosures API
Access real-time financial disclosures from U.S. House members with the FMP Latest House Financial Disclosures API. Track recent trades, asset ownership, and financial holdings for enhanced visibility into political figures' financial activities.

#### Request
```http
GET https://financialmodelingprep.com/stable/house-latest?page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Senate Trading Activity API
Monitor the trading activity of US Senators with the FMP Senate Trading Activity API. Access detailed information on trades made by Senators, including trade dates, assets, amounts, and potential conflicts of interest.

#### Request
```http
GET https://financialmodelingprep.com/stable/senate-trades?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Senate Trades By Name API
#### Request
```http
GET https://financialmodelingprep.com/stable/senate-trades-by-name?name=Jerry
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### U.S. House Trades API
Track the financial trades made by U.S. House members and their families with the FMP U.S. House Trades API. Access real-time information on stock sales, purchases, and other investment activities to gain insight into their financial decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/house-trades?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### House Trades By Name API
#### Request
```http
GET https://financialmodelingprep.com/stable/house-trades-by-name?name=James
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ESG Investment Search API
Align your investments with your values using the FMP ESG Investment Search API. Discover companies and funds based on Environmental, Social, and Governance (ESG) scores, performance, controversies, and business involvement criteria.

#### Request
```http
GET https://financialmodelingprep.com/stable/esg-disclosures?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ESG Ratings API
Access comprehensive ESG ratings for companies and funds with the FMP ESG Ratings API. Make informed investment decisions based on environmental, social, and governance (ESG) performance data.

#### Request
```http
GET https://financialmodelingprep.com/stable/esg-ratings?symbol=AAPL
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### ESG Benchmark Comparison API
Evaluate the ESG performance of companies and funds with the FMP ESG Benchmark Comparison API. Compare ESG leaders and laggards within industries to make informed and responsible investment decisions.

#### Request
```http
GET https://financialmodelingprep.com/stable/esg-benchmark
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### COT Report API
Access comprehensive Commitment of Traders (COT) reports with the FMP COT Report API. This API provides detailed information about long and short positions across various sectors, helping you assess market sentiment and track positions in commodities, indices, and financial instruments.

#### Request
```http
GET https://financialmodelingprep.com/stable/commitment-of-traders-report
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### COT Analysis By Dates API
Gain in-depth insights into market sentiment with the FMP COT Report Analysis API. Analyze the Commitment of Traders (COT) reports for a specific date range to evaluate market dynamics, sentiment, and potential reversals across various sectors.

#### Request
```http
GET https://financialmodelingprep.com/stable/commitment-of-traders-analysis
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### COT Report List API
Access a comprehensive list of available Commitment of Traders (COT) reports by commodity or futures contract using the FMP COT Report List API. This API provides an overview of different market segments, allowing users to retrieve and explore COT reports for a wide variety of commodities and financial instruments.

#### Request
```http
GET https://financialmodelingprep.com/stable/commitment-of-traders-list
```

### Latest Crowdfunding Campaigns API
Discover the most recent crowdfunding campaigns with the FMP Latest Crowdfunding Campaigns API. Stay informed on which companies and projects are actively raising funds, their financial details, and offering terms.

#### Request
```http
GET https://financialmodelingprep.com/stable/crowdfunding-offerings-latest?page=0&limit=100
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Crowdfunding Campaign Search API
Search for crowdfunding campaigns by company name, campaign name, or platform with the FMP Crowdfunding Campaign Search API. Access detailed information to track and analyze crowdfunding activities.

#### Request
```http
GET https://financialmodelingprep.com/stable/crowdfunding-offerings-search?name=enotap
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Crowdfunding By CIK API
Access detailed information on all crowdfunding campaigns launched by a specific company with the FMP Crowdfunding By CIK API.

#### Request
```http
GET https://financialmodelingprep.com/stable/crowdfunding-offerings?cik=0001916078
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Equity Offering Updates API
Stay informed about the latest equity offerings with the FMP Equity Offering Updates API. Track new shares being issued by companies and get insights into exempt offerings and amendments.

#### Request
```http
GET https://financialmodelingprep.com/stable/fundraising-latest?page=0&limit=10
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Equity Offering Search API
Easily search for equity offerings by company name or stock symbol with the FMP Equity Offering Search API. Access detailed information about recent share issuances to stay informed on company fundraising activities.

#### Request
```http
GET https://financialmodelingprep.com/stable/fundraising-search?name=NJOY
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Equity Offering By CIK API
Access detailed information on equity offerings announced by specific companies with the FMP Company Equity Offerings by CIK API. Track offering activity and identify potential investment opportunities.

#### Request
```http
GET https://financialmodelingprep.com/stable/fundraising?cik=0001547416
```

### Parameters
_Parameter heading present, but no parameter rows were captured in the source text for this endpoint._

### Company Profile Bulk API
The FMP Profile Bulk API allows users to retrieve comprehensive company profile data in bulk. Access essential information, such as company details, stock price, market cap, sector, industry, and more for multiple companies in a single request.

#### Request
```http
GET https://financialmodelingprep.com/stable/profile-bulk?part=0
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `part*` | `string` | `0` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Stock Rating Bulk API
The FMP Rating Bulk API provides users with comprehensive rating data for multiple stocks in a single request. Retrieve key financial ratings and recommendations such as overall ratings, DCF recommendations, and more for multiple companies at once.

#### Request
```http
GET https://financialmodelingprep.com/stable/rating-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### DCF Valuations Bulk API
The FMP DCF Bulk API enables users to quickly retrieve discounted cash flow (DCF) valuations for multiple symbols in one request. Access the implied price movement and percentage differences for all listed companies.

#### Request
```http
GET https://financialmodelingprep.com/stable/dcf-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### Financial Scores Bulk API
The FMP Scores Bulk API allows users to quickly retrieve a wide range of key financial scores and metrics for multiple symbols. These scores provide valuable insights into company performance, financial health, and operational efficiency.

#### Request
```http
GET https://financialmodelingprep.com/stable/scores-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### Price Target Summary Bulk API
The Price Target Summary Bulk API provides a comprehensive overview of price targets for all listed symbols over multiple timeframes. With this API, users can quickly retrieve price target data, helping investors and analysts compare current prices to projected targets across different periods.

#### Request
```http
GET https://financialmodelingprep.com/stable/price-target-summary-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### ETF Holder Bulk API
The ETF Holder Bulk API allows users to quickly retrieve detailed information about the assets and shares held by Exchange-Traded Funds (ETFs). This API provides insights into the weight each asset carries within the ETF, along with key financial information related to these holdings.

#### Request
```http
GET https://financialmodelingprep.com/stable/etf-holder-bulk?part=1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `part*` | `string` | `1` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Upgrades Downgrades Consensus Bulk API
The Upgrades Downgrades Consensus Bulk API provides a comprehensive view of analyst ratings across all symbols. Retrieve bulk data for analyst upgrades, downgrades, and consensus recommendations to gain insights into the market's outlook on individual stocks.

#### Request
```http
GET https://financialmodelingprep.com/stable/upgrades-downgrades-consensus-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### Key Metrics TTM Bulk API
The Key Metrics TTM Bulk API allows users to retrieve trailing twelve months (TTM) data for all companies available in the database. The API provides critical financial ratios and metrics based on each company’s latest financial report, offering insights into company performance and financial health.

#### Request
```http
GET https://financialmodelingprep.com/stable/key-metrics-ttm-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### Ratios TTM Bulk API
The Ratios TTM Bulk API offers an efficient way to retrieve trailing twelve months (TTM) financial ratios for stocks. It provides users with detailed insights into a company’s profitability, liquidity, efficiency, leverage, and valuation ratios, all based on the most recent financial report.

#### Request
```http
GET https://financialmodelingprep.com/stable/ratios-ttm-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### Stock Peers Bulk API
The Stock Peers Bulk API allows you to quickly retrieve a comprehensive list of peer companies for all stocks in the database. By accessing this data, you can easily compare a stock’s performance with its closest competitors or similar companies within the same industry or sector.

#### Request
```http
GET https://financialmodelingprep.com/stable/peers-bulk
```

### Sample response
_No sample response was captured in the source text for this endpoint._

### Earnings Surprises Bulk API
The Earnings Surprises Bulk API allows users to retrieve bulk data on annual earnings surprises, enabling quick analysis of which companies have beaten, missed, or met their earnings estimates. This API provides actual versus estimated earnings per share (EPS) for multiple companies at once, offering valuable insights for investors and analysts.

#### Request
```http
GET https://financialmodelingprep.com/stable/earnings-surprises-bulk?year=2025
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Income Statement Bulk API
The Bulk Income Statement API allows users to retrieve detailed income statement data in bulk. This API is designed for large-scale data analysis, providing comprehensive insights into a company's financial performance, including revenue, gross profit, expenses, and net income.

#### Request
```http
GET https://financialmodelingprep.com/stable/income-statement-bulk?year=2025&period=Q1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Income Statement Growth Bulk API
The Bulk Income Statement Growth API provides access to growth data for income statements across multiple companies. Track and analyze growth trends over time for key financial metrics such as revenue, net income, and operating income, enabling a better understanding of corporate performance trends.

#### Request
```http
GET https://financialmodelingprep.com/stable/income-statement-growth-bulk?year=2025&period=Q1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Balance Sheet Statement Bulk API
The Bulk Balance Sheet Statement API provides comprehensive access to balance sheet data across multiple companies. It enables users to analyze financial positions by retrieving key figures such as total assets, liabilities, and equity. Ideal for comparing the financial health and stability of different companies on a large scale.

#### Request
```http
GET https://financialmodelingprep.com/stable/balance-sheet-statement-bulk?year=2025&period=Q1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Balance Sheet Statement Growth Bulk API
The Balance Sheet Growth Bulk API allows users to retrieve growth data across multiple companies’ balance sheets, enabling detailed analysis of how financial positions have changed over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/balance-sheet-statement-growth-bulk?year=2025&period=Q1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Cash Flow Statement Bulk API
The Cash Flow Statement Bulk API provides access to detailed cash flow reports for a wide range of companies. This API enables users to retrieve bulk cash flow statement data, helping to analyze companies’ operating, investing, and financing activities over time.

#### Request
```http
GET https://financialmodelingprep.com/stable/cash-flow-statement-bulk?year=2025&period=Q1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Cash Flow Statement Growth Bulk API
The Cash Flow Statement Growth Bulk API allows you to retrieve bulk growth data for cash flow statements, enabling you to track changes in cash flows over time. This API is ideal for analyzing the cash flow growth trends of multiple companies simultaneously.

#### Request
```http
GET https://financialmodelingprep.com/stable/cash-flow-statement-growth-bulk?year=2025&period=Q1
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `year*` | `string` | `2025` |
| `period*` | `string` | `Q1,Q2,Q3,Q4,FY` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._

### Eod Bulk API
The EOD Bulk API allows users to retrieve end-of-day stock price data for multiple symbols in bulk. This API is ideal for financial analysts, traders, and investors who need to assess valuations for a large number of companies.

#### Request
```http
GET https://financialmodelingprep.com/stable/eod-bulk?date=2024-10-22
```

### Parameters
| Parameter | Type | Example |
|---|---|---|
| `date*` | `string` | `2024-10-22` |

> (*) Required

### Sample response
_No sample response was captured in the source text for this endpoint._
