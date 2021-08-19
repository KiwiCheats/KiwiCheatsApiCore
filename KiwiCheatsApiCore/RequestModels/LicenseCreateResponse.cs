using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class LicenseCreateResponse {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        
        [JsonPropertyName("message")]
        public string Message { get; set; }
        
        [JsonPropertyName("licenses")]
        public List<string> Licenses { get; set; }
    }
}