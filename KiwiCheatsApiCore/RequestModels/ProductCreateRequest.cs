using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class ProductCreateRequest {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}