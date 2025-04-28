using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;

namespace EsportsStatTracker.Database_Models
{
    public class Match
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("pfw_score")]
        public int PfwScore { get; set; } = 0;

        [BsonElement("opp_name")]
        public string OppName { get; set; } = string.Empty;

        [BsonElement("opp_score")]
        public int OppScore { get; set; } = 0;

        [BsonElement("date_played")]
        public DateTime DatePlayed { get; set; } = DateTime.Now;

        [BsonElement("extra_data")]
        public BsonDocument ExtraData { get; set; }

        public Match() { }

        public Match(int pfwscore, string oppname, int oppscore, DateTime date)
        {
            PfwScore = pfwscore;
            OppName = oppname;
            OppScore = oppscore;
            DatePlayed = date;
        }

        public void UpdateInfo(Match match)
        {
            PfwScore = match.PfwScore;
            OppName = match.OppName;
            OppScore = match.OppScore;
            DatePlayed = match.DatePlayed;

            IMongoDatabase database = MainScreen.GetDatabase();
            database.GetCollection<Match>("matches").UpdateOne(
                Builders<Match>.Filter.Eq(m => m.Id, Id),
                Builders<Match>.Update
                    .Set(m => m.PfwScore, PfwScore)
                    .Set(m => m.OppName, OppName)
                    .Set(m => m.OppScore, OppScore)
                    .Set(m => m.DatePlayed, DatePlayed)
                );
        }
    }
}
