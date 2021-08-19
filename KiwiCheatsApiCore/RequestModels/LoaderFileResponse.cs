using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class LoaderFileResponse {
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}