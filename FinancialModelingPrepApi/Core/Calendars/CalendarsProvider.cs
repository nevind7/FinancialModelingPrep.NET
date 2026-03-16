using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using FinancialModelingPrep.Abstractions.Calendars;
using FinancialModelingPrep.Core.Http;
using FinancialModelingPrep.Model;
using FinancialModelingPrep.Model.Calendars;

namespace FinancialModelingPrep.Core.Calendars;

public class CalendarsProvider : ICalendarsProvider
{
    private readonly FinancialModelingPrepHttpClient client;

    public CalendarsProvider(FinancialModelingPrepHttpClient client)
    {
        this.client = client ?? throw new ArgumentNullException(nameof(client));
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarAsync(string from, string to)
    {
        if (string.IsNullOrEmpty(from))
        {
            throw new ArgumentException($"'{nameof(from)}' cannot be null or empty.", nameof(from));
        }

        if (string.IsNullOrEmpty(to))
        {
            throw new ArgumentException($"'{nameof(to)}' cannot be null or empty.", nameof(to));
        }

        return GetEarningsCalendarInternalAsync(from, to);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarAsync()
        => GetEarningsCalendarInternalAsync();

    private Task<ApiResponse<List<EarningsCalendarResponse>>> GetEarningsCalendarInternalAsync(string? from = null, string? to = null)
    {
        const string url = Endpoint.EarningsCalendar;

        var queryString = new QueryStringBuilder();

        if (!string.IsNullOrEmpty(from) && !string.IsNullOrEmpty(to))
        {
            queryString.Add("from", from);
            queryString.Add("to", to);
        }

        return client.GetJsonAsync<List<EarningsCalendarResponse>>(url, new NameValueCollection(), queryString);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<EarningsCalendarResponse>>> GetHistoricalEarningsCalendarAsync(string symbol, int? limit = null)
    {
        const string url = Endpoint.Earnings;

        var pathParams = new NameValueCollection();

        var queryString = new QueryStringBuilder();
        queryString.Add("symbol", symbol);

        if (limit != null)
        {
            queryString.Add("limit", limit);
        }

        return client.GetJsonAsync<List<EarningsCalendarResponse>>(url, pathParams, queryString);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<List<IPOCalendarResponse>>> GetIPOCalendarAsync(string from, string to)
        => GetGenericCalendarAsync<IPOCalendarResponse>(Endpoint.IPOCalendar, from, to);

    /// <inheritdoc/>
    public Task<ApiResponse<List<DividendCalendarResponse>>> GetDividendCalendarAsync(string from, string to)
        => GetGenericCalendarAsync<DividendCalendarResponse>(Endpoint.StockDividendCalendar, from, to);

    /// <inheritdoc/>
    public Task<ApiResponse<List<EconomicCalendarResponse>>> GetEconomicCalendarAsync(string from, string to)
        => GetGenericCalendarAsync<EconomicCalendarResponse>(Endpoint.EconomicCalendar, from, to);

    /// <inheritdoc/>
    public Task<ApiResponse<List<StockSplitCalendarResponse>>> GetStockSplitCalendarAsync(string from, string to)
        => GetGenericCalendarAsync<StockSplitCalendarResponse>(Endpoint.StockSplitCalendar, from, to);

    private Task<ApiResponse<List<T>>> GetGenericCalendarAsync<T>(string urlTemplate, string from, string to)
    {
        if (string.IsNullOrEmpty(from))
        {
            throw new ArgumentException($"'{nameof(from)}' cannot be null or empty.", nameof(from));
        }

        if (string.IsNullOrEmpty(to))
        {
            throw new ArgumentException($"'{nameof(to)}' cannot be null or empty.", nameof(to));
        }

        var pathParams = new NameValueCollection();

        var queryString = new QueryStringBuilder();

        queryString.Add("from", from);
        queryString.Add("to", to);

        return client.GetJsonAsync<List<T>>(urlTemplate, pathParams, queryString);
    }
}