using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class AuthResponse {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        
        [JsonPropertyName("message")]
        public string Message { get; set; }
        
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}