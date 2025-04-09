using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EsportsStatTracker.Database_Models
{
    public class PlaysOn
    {
        [BsonElement("teamId")]
        public ObjectId TeamId;

        [BsonElement("playerId")]
        public ObjectId PlayerId;
    }
}
