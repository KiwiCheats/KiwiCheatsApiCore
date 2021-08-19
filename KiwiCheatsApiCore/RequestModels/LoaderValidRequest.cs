using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class LoaderValidRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}