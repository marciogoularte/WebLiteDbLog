using Microsoft.Extensions.Logging;
using System;

namespace WebLiteeDb.LogProvider
{
    public class DBLogger : ILogger
    {

        public DBLogger()
        {

        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            //return logLevel == LogLevel.Trace;
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                LiteDB.Insert(new EventLog
                                {
                                    EventId = eventId.Id,
                                    LogLevel = logLevel.ToString(),
                                    Message = formatter(state, exception) + Environment.NewLine,
                                    CreatedTime = DateTime.Now
                                });
                    
            }
        }
    }
}
