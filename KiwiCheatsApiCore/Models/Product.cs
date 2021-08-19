using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.Models {
    public class Product {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("status")]
        public int Status { get; set; }
    }
}