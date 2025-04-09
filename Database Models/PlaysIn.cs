using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace EsportsStatTracker.Database_Models
{
    public class PlaysIn
    {
        [BsonElement("teamId")]
        public ObjectId TeamId;

        [BsonElement("matchId")]
        public ObjectId MatchId;

        [BsonElement("playerIds")]
        public List<ObjectId> PlayerIds;
    }
}
