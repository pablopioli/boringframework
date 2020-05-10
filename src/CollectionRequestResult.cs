using System.Collections.Generic;

namespace Boring
{
    public class CollectionRequestResult<T>
    {
        public bool IsFailure => TextError.IsNotNullOrEmpty() || HttpError != null;
        public string TextError { get; set; }
        public HttpError HttpError { get; set; }
        public ICollection<T> Value { get; set; }
        public bool HasMoreData { get; set; }

        public CollectionRequestResult()
        { }

        public CollectionRequestResult(string textError)
        {
            TextError = textError;
        }

        public CollectionRequestResult(HttpError httpError)
        {
            HttpError = httpError;
        }

        public CollectionRequestResult(ICollection<T> value)
        {
            Value = value;
        }

        public CollectionRequestResult(ICollection<T> value, bool hasMoreData)
        {
            Value = value;
            HasMoreData = hasMoreData;
        }
    }
}
