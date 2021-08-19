using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class AuthLoginRequest {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}