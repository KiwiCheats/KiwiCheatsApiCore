using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class AuthLoginByLoaderRequest {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}