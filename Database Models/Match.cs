using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EsportsStatTracker.Database_Models
{
    public class Match
    {
        [BsonElement("pfw_score")]
        public int PfwScore { get; set; } = 0;

        [BsonElement("opp_score")]
        public int OppScore { get; set; } = 0;

        [BsonElement("date_played")]
        public DateTime DatePlayed { get; set; } = DateTime.Now;

        [BsonElement("extra_data")]
        public BsonDocument ExtraData { get; set; } = new BsonDocument();
    }
}
