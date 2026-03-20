using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.CompanyValuation;

public sealed record PriceTargetSummaryResponse
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = string.Empty;

    [JsonPropertyName("lastMonthCount")]
    public int LastMonthCount { get; init; }

    [JsonPropertyName("lastMonthAvgPriceTarget")]
    public double LastMonthAvgPriceTarget { get; init; }

    [JsonPropertyName("lastQuarterCount")]
    public int LastQuarterCount { get; init; }

    [JsonPropertyName("lastQuarterAvgPriceTarget")]
    public double LastQuarterAvgPriceTarget { get; init; }

    [JsonPropertyName("lastYearCount")]
    public int LastYearCount { get; init; }

    [JsonPropertyName("lastYearAvgPriceTarget")]
    public double LastYearAvgPriceTarget { get; init; }

    [JsonPropertyName("allTimeCount")]
    public int AllTimeCount { get; init; }

    [JsonPropertyName("allTimeAvgPriceTarget")]
    public double AllTimeAvgPriceTarget { get; init; }

    [JsonPropertyName("publishers")]
    [JsonConverter(typeof(JsonStringToStringListConverter))]
    public List<string> Publishers { get; init; } = [];
}

public sealed class JsonStringToStringListConverter : JsonConverter<List<string>>
{
    public override List<string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var json = reader.GetString();

        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        return JsonSerializer.Deserialize<List<string>>(json, options) ?? [];
    }

    public override void Write(Utf8JsonWriter writer, List<string> value, JsonSerializerOptions options)
    {
        var json = JsonSerializer.Serialize(value, options);
        writer.WriteStringValue(json);
    }
}
