using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.Models {
    public class Package {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("credits")]
        public double Credits { get; set; }
        
        [JsonPropertyName("price")]
        public double Price { get; set; }
        
        [JsonPropertyName("expires")]
        public long Expires { get; set; }
        
        [JsonPropertyName("productIds")]
        public IEnumerable<string> Products { get; set; } = new List<string>();
    }
}