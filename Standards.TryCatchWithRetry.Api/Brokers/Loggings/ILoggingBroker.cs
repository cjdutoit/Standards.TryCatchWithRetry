using System;

namespace Standards.TryCatchWithRetry.Api.Brokers.Loggings
{
    public interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogTrace(string message);
    }
}
