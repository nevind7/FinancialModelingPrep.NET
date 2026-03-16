using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.Economics;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Economics;

namespace FinancialModelingPrep.Core.Economics;

public class EconomicsProvider : IEconomicsProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public EconomicsProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<EconomicIndicatorResponse>>> GetEconomicIndicatorAsync(EconomicIndicator indicator, string from, string to)
    {
        const string url = Endpoint.EconomicIndicators;

        var queryString = new QueryStringBuilder();

        queryString.Add("name", indicator.ToFMP());
        queryString.Add("from", from);
        queryString.Add("to", to);

        return client.GetJsonAsync<List<EconomicIndicatorResponse>>(url, new NameValueCollection(), queryString);
    }
}