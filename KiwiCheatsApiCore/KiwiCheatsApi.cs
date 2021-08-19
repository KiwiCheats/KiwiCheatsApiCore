using System.Collections.Generic;
using System.Net.Http.Headers;

using KiwiCheatsApiCore.Models;
using KiwiCheatsApiCore.RequestModels;
using KiwiCheatsApiCore.Utils;

namespace KiwiCheatsApiCore {
    public class KiwiCheatsApi {
        public bool Authenticate(string token, out string message) {
            var response = _requestHelper.Post<AuthResponse, AuthLoginByLoaderRequest>("auth/loginByLoader", new() {
                Token = token
            });

            if (response.Success) {
                _requestHelper.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.Token);
            }

            message = response.Message;

            return response.Success;
        }

        public bool Authenticate(string email, string password, out string message) {
            var response = _requestHelper.Post<AuthResponse, AuthLoginRequest>("auth/login", new() {
                Email = email,
                Password = password
            });

            if (response.Success) {
                _requestHelper.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.Token);
            }

            message = response.Message;

            return response.Success;
        }

        public User GetUser() {
            return _requestHelper.Get<User>("user/info", new());
        }

        public StatusResponse CreateProduct(ProductCreateRequest request) {
            return _requestHelper.Post<StatusResponse, ProductCreateRequest>("product/create", request);
        }
        
        public StatusResponse DeleteProduct(ProductDeleteRequest request) {
            return _requestHelper.Post<StatusResponse, ProductDeleteRequest>("product/delete", request);
        }

        public List<Product> GetProducts() {
            return _requestHelper.Get<List<Product>>("product/list", new());
        }
        
        public StatusResponse CreatePackage(PackageCreateRequest request) {
            return _requestHelper.Post<StatusResponse, PackageCreateRequest>("package/create", request);
        }

        public StatusResponse DeletePackage(PackageDeleteRequest request) {
            return _requestHelper.Post<StatusResponse, PackageDeleteRequest>("package/delete", request);
        }
        
        public StatusResponse UpdatePackage(PackageUpdateRequest request) {
            return _requestHelper.Post<StatusResponse, PackageUpdateRequest>("package/update", request);
        }
        
        public List<Package> GetPackages() {
            return _requestHelper.Get<List<Package>>("package/list", new());
        }

        public List<UserSubscriptionsResponse> GetSubscriptions() {
            return _requestHelper.Get<List<UserSubscriptionsResponse>>("user/subscriptions", new());
        }

        private readonly RequestHelper _requestHelper = new();
    }
}