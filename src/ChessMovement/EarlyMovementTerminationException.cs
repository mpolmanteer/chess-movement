using System;
using System.Runtime.Serialization;

namespace ChessMovement
{
    [Serializable]
    internal class EarlyMovementTerminationException : Exception
    {
        public EarlyMovementTerminationException()
        {
        }

        public EarlyMovementTerminationException(string message) : base(message)
        {
        }

        public EarlyMovementTerminationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EarlyMovementTerminationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}