using System.Net;

namespace Boring
{
    public class HttpError
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string UserDisplayableError { get; set; } = string.Empty;

        public HttpError()
        { }

        public HttpError(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public HttpError(string userDisplayableError)
        {
            UserDisplayableError = userDisplayableError;
        }

        public HttpError(HttpStatusCode statusCode, string userDisplayableError)
        {
            StatusCode = statusCode;
            UserDisplayableError = userDisplayableError;
        }
    }
}
