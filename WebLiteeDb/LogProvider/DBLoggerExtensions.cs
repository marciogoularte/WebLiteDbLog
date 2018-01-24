using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLiteeDb.LogProvider
{
    public static class DBLoggerExtensions
    {
        public static ILoggerFactory AddDB(this ILoggerFactory factory)
        {
            factory.AddProvider(new DBLoggerProvider());
            return factory;
        }
    }
}
