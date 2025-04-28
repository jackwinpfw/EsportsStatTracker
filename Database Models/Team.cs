using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace EsportsStatTracker.Database_Models
{
    public class Team
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;
        [BsonElement("game")]
        public string Game { get; set; } = string.Empty;

        public Team() { }

        public Team(string Name, string Game)
        {
            this.Name = Name;
            this.Game = Game;
        }

        public void UpdateInfo(Team team)
        {
            Name = team.Name;
            Game = team.Game;

            IMongoDatabase database = MainScreen.GetDatabase();
            database.GetCollection<Team>("teams").UpdateOne(
                Builders<Team>.Filter.Eq(t => t.Id, Id),
                Builders<Team>.Update
                    .Set(t => t.Name, Name)
                    .Set(t => t.Game, Game)
            );
        }
    }
}
