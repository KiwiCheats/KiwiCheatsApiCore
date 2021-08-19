using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class LicenseRedeemRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}