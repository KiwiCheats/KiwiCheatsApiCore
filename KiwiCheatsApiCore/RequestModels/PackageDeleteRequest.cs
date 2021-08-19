using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class PackageDeleteRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}