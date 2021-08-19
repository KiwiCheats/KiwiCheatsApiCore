using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class ProductUpdateRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}