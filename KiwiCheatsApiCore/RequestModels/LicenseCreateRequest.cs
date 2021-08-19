using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class LicenseCreateRequest {
        [JsonPropertyName("packageId")]
        public string PackageId { get; set; }
        
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}