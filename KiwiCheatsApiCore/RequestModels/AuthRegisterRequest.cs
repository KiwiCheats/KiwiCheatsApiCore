using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class AuthRegisterRequest {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}