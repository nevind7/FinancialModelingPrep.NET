using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Calendars
{
    public class EarningsCalendarResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("epsActual")]
        public double? Eps { get; set; }

        [JsonPropertyName("epsEstimated")]
        public double? EpsEstimated { get; set; }

        [JsonPropertyName("revenueActual")]
        public double? Revenue { get; set; }

        [JsonPropertyName("revenueEstimated")]
        public double? RevenueEstimated { get; set; }

        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }
    }
}
