using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.InstitutionalFund;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.InstitutionalFund;

namespace FinancialModelingPrep.Core.InstitutionalFund;

public class InstitutionalFundProvider : IInstitutionalFundProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public InstitutionalFundProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<CikListResponse>>> Get13FListAsync()
    {
        const string url = Endpoint.CikList;

        return client.GetJsonAsync<List<CikListResponse>>(url);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<CikListResponse>>> GetCompanyNameByCik(string cik)
    {
        const string url = Endpoint.SearchCik;

        var queryString = new QueryStringBuilder();
        queryString.Add("cik", cik);

        return client.GetJsonAsync<List<CikListResponse>>(url, new NameValueCollection(), queryString);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<Form13FResponse>>> GetForm13FAsync(string cik, string year, string quarter)
    {
        const string url = Endpoint.Form13F;

        var pathParams = new NameValueCollection
        {
            { "cik", cik }
        };

        var queryString = new QueryStringBuilder();
        queryString.Add("cik", cik);
        queryString.Add("year", year);
        queryString.Add("quarter", quarter);

        return client.GetJsonAsync<List<Form13FResponse>>(url, pathParams, queryString);
    }

    /// <inheritdoc/>
    public async Task<ApiResponse<CusipMapperResponse>> MapCusipAsync(string cusip)
    {
        const string url = Endpoint.SearchCusip;

        var queryString = new QueryStringBuilder();
        queryString.Add("cusip", cusip);

        var result = await client.GetJsonAsync<List<CusipMapperResponse>>(url, new NameValueCollection(), queryString);

        if (result.HasError)
        {
            return ApiResponse.FromError<CusipMapperResponse>(result.Error);
        }

        return ApiResponse.FromSucces(result.Data.First());
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<CikListResponse>>> SearchCikByName(string name)
    {
        const string url = Endpoint.SearchName;

        var queryString = new QueryStringBuilder();
        queryString.Add("query", name);

        return client.GetJsonAsync<List<CikListResponse>>(url, new NameValueCollection(), queryString);
    }
}