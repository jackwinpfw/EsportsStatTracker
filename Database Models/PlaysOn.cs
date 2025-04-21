using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EsportsStatTracker.Database_Models
{
    public class PlaysOn
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("teamId")]
        public ObjectId TeamId;

        [BsonElement("playerId")]
        public ObjectId PlayerId;
    }
}
