using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace EsportsStatTracker.Database_Models
{
    public class Player
    {
        [BsonElement("usernames")]
        public List<string> Usernames { get; set; } = new List<string>();

        [BsonElement("retired")]
        public bool IsRetired { get; set; } = false;
    }
}
