using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalDividendsResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<HistoricalDividendItem> Historical { get; set; }
    }
}
