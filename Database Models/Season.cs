using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EsportsStatTracker.Database_Models
{
    public class Season
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("semester")]
        public string Semester { get; set; } = string.Empty;

        [BsonElement("year")]
        public int Year { get; set; } = 0;
    }
}
