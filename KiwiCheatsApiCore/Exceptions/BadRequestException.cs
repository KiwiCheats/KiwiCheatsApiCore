using System.Net;

namespace KiwiCheatsApiCore.Exceptions {
    public class BadRequestException : KiwiCheatsException {
        public BadRequestException(HttpStatusCode statusCode, string message) : base(message) {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; init; }
    }
}