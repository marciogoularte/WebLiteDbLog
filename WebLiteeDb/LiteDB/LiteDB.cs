using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLiteeDb.LogProvider;

namespace WebLiteeDb
{
    public static class LiteDB
    {
        private static LiteDatabase db = new LiteDatabase(@"LogData.db");
        private static LiteCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("MyAppEventLog");

        public static void Insert(EventLog logData)
        {
            collection.Insert(new BsonDocument
                        {
                            ["EventId"] = logData.EventId,
                            ["LogLevel"] = logData.LogLevel,
                            ["Message"] = logData.Message,
                            ["CreatedTime"] = logData.CreatedTime
                        });
        }
    }
}
