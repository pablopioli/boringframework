using System;

namespace Boring
{
    // From https://github.com/vkhorikov/CSharpFunctionalExtensions
    public class ResultFailureException : Exception
    {
        public string Error { get; }

        internal ResultFailureException(string error) : base(ResultMessages.ValueIsInaccessibleForFailure)
        {
            Error = error;
        }

        public ResultFailureException() : base()
        {
        }

        public ResultFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class ResultFailureException<E> : ResultFailureException
    {
        public new E Error { get; }

        internal ResultFailureException(E error) : base(ResultMessages.ValueIsInaccessibleForFailure)
        {
            Error = error;
        }

        public ResultFailureException() : base()
        {
        }

        public ResultFailureException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
