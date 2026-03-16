using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Calendars
{
    public class DividendCalendarResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("adjDividend")]
        public decimal AdjDividend { get; set; }
        
        [JsonPropertyName("dividend")]
        public decimal? Dividend { get; set; }

        [JsonPropertyName("recordDate")]
        public string RecordDate { get; set; }

        [JsonPropertyName("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonPropertyName("declarationDate")]
        public string DeclarationDate { get; set; }
        
        [JsonPropertyName("frequency")]
        public string Frequency { get; set; }
        
        [JsonPropertyName("yield")]
        public decimal Yield { get; set; }
    }
}
