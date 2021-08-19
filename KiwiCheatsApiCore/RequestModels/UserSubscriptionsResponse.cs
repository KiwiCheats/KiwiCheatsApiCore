using System.Text.Json.Serialization;

namespace KiwiCheatsApiCore.RequestModels {
    public class UserSubscriptionsResponse {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }
        
        [JsonPropertyName("expires")]
        public long Expires { get; set; }
    }
}