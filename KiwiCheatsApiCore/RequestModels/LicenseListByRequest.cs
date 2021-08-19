using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class LicenseListByRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("redeemed")]
        public bool Redeemed { get; set; }

        [JsonPropertyName("idx")]
        public int Idx { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}