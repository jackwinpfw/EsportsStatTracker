using MongoDB.Bson.Serialization.Attributes;

namespace EsportsStatTracker.Database_Models
{
    public class Team
    {
        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;
        [BsonElement("game")]
        public string Game { get; set; } = string.Empty;
    }
}
