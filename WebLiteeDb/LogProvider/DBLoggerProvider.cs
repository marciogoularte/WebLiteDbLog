using Microsoft.Extensions.Logging;

namespace WebLiteeDb.LogProvider
{
    public class DBLoggerProvider : ILoggerProvider
    {

        public ILogger CreateLogger(string categoryName)
        {
            return new DBLogger();
        }

        public void Dispose()
        {
        }
    }
}
