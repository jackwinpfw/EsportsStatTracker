using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EsportsStatTracker.Database_Models
{
    public class PlaysDuring
    {
        [BsonElement("teamId")]
        public ObjectId TeamId;

        [BsonElement("seasonId")]
        public ObjectId SeasonId;
    }
}
