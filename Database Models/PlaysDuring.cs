using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EsportsStatTracker.Database_Models
{
    public class PlaysDuring
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("teamId")]
        public ObjectId TeamId;

        [BsonElement("seasonId")]
        public ObjectId SeasonId;

        public PlaysDuring(ObjectId teamId, ObjectId seasonId)
        {
            TeamId = teamId;
            SeasonId = seasonId;
        }
    }
}
