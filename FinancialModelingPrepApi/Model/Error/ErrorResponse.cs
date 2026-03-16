using System.Text.Json.Serialization;

namespace FinancialModelingPrep.Model.Error
{
    public class ErrorResponse
    {
        [JsonPropertyName("Error Message")]
        public string ErrorMessage { get; set; }
    }
}
