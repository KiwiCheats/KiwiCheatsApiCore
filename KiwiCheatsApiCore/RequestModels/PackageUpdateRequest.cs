using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class PackageUpdateRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("price")]
        public double Price { get; set; }
        
        [JsonPropertyName("credits")]
        public double Credits { get; set; }
        
        [JsonPropertyName("expires")]
        public long Expires { get; set; }
        
        [JsonPropertyName("products")]
        public List<string> Products { get; set; }
        
        [JsonPropertyName("seller")]
        public bool Seller { get; set; }
    }
}