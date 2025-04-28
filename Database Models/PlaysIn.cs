using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace EsportsStatTracker.Database_Models
{
    public class PlaysIn
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("teamId")]
        public ObjectId TeamId;

        [BsonElement("matchId")]
        public ObjectId MatchId;

        [BsonElement("playerIds")]
        public List<ObjectId> PlayerIds;

        public PlaysIn(ObjectId teamId, ObjectId matchId)
        {
            TeamId = teamId;
            MatchId = matchId;
            PlayerIds = new List<ObjectId>();
        }
    }
}
