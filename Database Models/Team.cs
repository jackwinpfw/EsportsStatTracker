using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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

        public Team(string Name, string Game)
        {
            this.Name = Name;
            this.Game = Game;
        }
    }
}
