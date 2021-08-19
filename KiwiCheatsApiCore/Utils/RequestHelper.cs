using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Web;
using KiwiCheatsApiCore.Exceptions;

namespace KiwiCheatsApiCore.Utils {
    internal class RequestHelper {
        internal HttpClient HttpClient { get; } = new();
        
        internal T Get<T>(string endpoint, Dictionary<string, string> parameters) where T : class {
            var url = $"{Constants.ApiUrl}{endpoint}?{ParametersToQueryString(parameters)}";

            var response = HttpClient.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode) {
                throw new BadRequestException(response.StatusCode, "Error sending request.");
            }
            
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

        private string ParametersToQueryString(Dictionary<string, string> parameters) {
            var data = new StringBuilder();

            foreach (string key in parameters.Keys) {
                data.Append($"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(parameters[key])}&");
            }

            if (data.Length > 0) {
                data.Remove(data.Length - 1, 1);
            }

            return data.ToString();
        }

        internal T Post<T>(string endpoint, Dictionary<string, string> body) where T : class {
            var url = $"{Constants.ApiUrl}{endpoint}";

            var response = HttpClient.PostAsJsonAsync(url, body).Result;

            if (!response.IsSuccessStatusCode) {
                throw new BadRequestException(response.StatusCode, "Error sending request.");
            }

            return response.Content.ReadFromJsonAsync<T>().Result;
        }
        
        internal T Post<T, TBody>(string endpoint, TBody body) where T : class where TBody : class {
            var url = $"{Constants.ApiUrl}{endpoint}";

            var response = HttpClient.PostAsJsonAsync(url, body).Result;

            if (!response.IsSuccessStatusCode) {
                throw new BadRequestException(response.StatusCode, "Error sending request.");
            }

            return response.Content.ReadFromJsonAsync<T>().Result;
        }
    }
}