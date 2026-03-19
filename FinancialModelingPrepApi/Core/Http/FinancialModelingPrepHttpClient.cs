using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Error;

namespace FinancialModelingPrep.Core.Http;

public class FinancialModelingPrepHttpClient
{
    private readonly HttpClient client;
    private readonly FinancialModelingPrepOptions options;
    private readonly JsonSerializerOptions jsonSerializerOptions;
    private const string EmptyArrayResponse = "[ ]";
    private const string EmptyArrayResponse2 = "[]";
    private const string ErrorMessageResponse = "Error Message";

    public FinancialModelingPrepHttpClient(HttpClient client, FinancialModelingPrepOptions options)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
        this.options = options ?? throw new ArgumentNullException(nameof(options));
        jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            PropertyNameCaseInsensitive = true,
        };

        if (string.IsNullOrWhiteSpace(this.options.ApiKey))
        {
            throw new ArgumentException("'ApiKey' can not be null or empty");
        }
    }

    public async Task<ApiResponse<string>> GetStringAsync(string urlPattern, NameValueCollection pathParams, QueryStringBuilder queryString)
    {
        var response = await CallApiAsync(urlPattern, pathParams, queryString);

        if (response.HasError)
        {
            return ApiResponse.FromError<string>(response.Error);
        }

        if (response.Data.Contains(ErrorMessageResponse))
        {
            var errorData = JsonSerializer.Deserialize<ErrorResponse>(response.Data);

            return ApiResponse.FromError<string>(errorData.ErrorMessage);
        }

        if (response.Data.Equals(EmptyArrayResponse, StringComparison.OrdinalIgnoreCase) ||
            response.Data.Equals(EmptyArrayResponse2, StringComparison.OrdinalIgnoreCase))
        {
            return ApiResponse.FromError<string>("Invalid parameters");
        }

        return ApiResponse.FromSuccess(response.Data);
    }

    public async Task<ApiResponse<T>> GetJsonAsync<T>(string urlPattern, NameValueCollection? pathParams = null, QueryStringBuilder? queryString = null)
        where T : class
    {
        pathParams ??= new NameValueCollection();
        try
        {
            var response = await GetStringAsync(urlPattern, pathParams, queryString);

            if (response.HasError)
            {
                return ApiResponse.FromError<T>(response.Error);
            }

            var data = JsonSerializer.Deserialize<T>(response.Data, jsonSerializerOptions);

            return ApiResponse.FromSuccess(data);
        }
        catch (JsonException ex)
        {
            return ApiResponse.FromError<T>(ex.ToString());
        }
    }

    private async Task<ApiResponse<string>> CallApiAsync(string urlPattern, NameValueCollection pathParams, QueryStringBuilder queryString)
    {
        PreProcessUrl(ref urlPattern, ref pathParams, ref queryString);

        queryString.Add("apikey", options.ApiKey);

        var requestUrl = $"{urlPattern}{queryString}";

        using var response = await client.GetAsync(requestUrl);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            return ApiResponse.FromError<string>($"{response.StatusCode} - {content}");
        }

        return ApiResponse.FromSuccess(content);
    }

    private static void PreProcessUrl(ref string url, ref NameValueCollection pathParams, ref QueryStringBuilder qsb)
    {
        if (string.IsNullOrEmpty(url))
        {
            throw new ArgumentNullException(nameof(url));
        }

        if (pathParams == null)
        {
            throw new ArgumentNullException(nameof(pathParams));
        }

        qsb ??= new QueryStringBuilder();

        if (pathParams.Count == 0)
        {
            return;
        }

        foreach (string key in pathParams.Keys)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("Provided path parameter was null or empty");
            }

            if (string.IsNullOrWhiteSpace(pathParams[key]))
            {
                throw new ArgumentException($"Provided path parameter value for {key} was null or empty");
            }

            url = url.Replace($"[{key}]", pathParams[key]);
        }
    }
}