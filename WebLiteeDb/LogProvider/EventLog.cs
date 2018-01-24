using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLiteeDb.LogProvider
{
    public class EventLog
    {
        public int? EventId { get; set; }
        public string LogLevel { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
