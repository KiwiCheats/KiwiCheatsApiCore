using System.Collections.Generic;
using System.Text.Json.Serialization;
using KiwiCheatsApiCore.Utils;

namespace KiwiCheatsApiCore.Models {
    public class User {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("balance")]
        public double Balance { get; set; }

        [JsonPropertyName("roles")]
        public List<string> Roles { get; set; } = new();
    }
}