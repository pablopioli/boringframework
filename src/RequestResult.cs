namespace Boring
{
    public class RequestResult<T>
    {
        public bool IsFailure => TextError.IsNotNullOrEmpty() || HttpError != null;
        public bool IsHttpError => HttpError != null;

        public string TextError { get; set; }
        public HttpError HttpError { get; set; }
        public T Value { get; set; }

        public RequestResult()
        { }

        public RequestResult(string textError)
        {
            TextError = textError;
        }

        public RequestResult(HttpError httpError)
        {
            HttpError = httpError;
        }

        public RequestResult(T value)
        {
            Value = value;
        }
    }
}
