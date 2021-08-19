using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class ProductDeleteRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}