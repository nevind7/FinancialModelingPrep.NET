using System.Collections.Specialized;
using FinancialModelingPrep.Abstractions.StatementAnalysis;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.StatementAnalysis;

namespace FinancialModelingPrep.Core.StatementAnalysis;

public class StatementAnalysisProvider : IStatementAnalysisProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public StatementAnalysisProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<FinancialGrowthResponse>>> GetFinancialGrowthAsync(string symbol,
        Period period = Period.Annual, int? limit = 30)
    {
        const string url = Endpoint.FinancialGrowth;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        queryString.Add("period", period.ToString().ToLower());

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<FinancialGrowthResponse>>(url, new NameValueCollection(), queryString);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<RevenueSegmentationItem>>> GetRevenueProductSegmentationAsync(
        string symbol, Period period = Period.Annual, RevenueSegmentationStructure? structure = null)
    {
        const string url = Endpoint.RevenueProductSegmentation;

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);
        queryString.Add("period", period.ToString().ToLower());
        if (structure != null) queryString.Add("structure", structure.ToString().ToLower());

        return client.GetJsonAsync<List<RevenueSegmentationItem>>(url, queryString: queryString);
    }
}