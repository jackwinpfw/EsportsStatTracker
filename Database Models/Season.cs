using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace EsportsStatTracker.Database_Models
{
    public class Season
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;

        [BsonElement("semester")]
        public string Semester { get; set; } = string.Empty;

        [BsonElement("year")]
        public int Year { get; set; } = 0;

        public Season() { }

        public Season(string Semester, int Year)
        {
            this.Semester = Semester;
            this.Year = Year;
        }

        public void UpdateInfo(Season season)
        {
            Semester = season.Semester;
            Year = season.Year;

            IMongoDatabase database = MainScreen.GetDatabase();
            database.GetCollection<Season>("seasons").UpdateOne(
                Builders<Season>.Filter.Eq(s => s.Id, Id),
                Builders<Season>.Update.Set(s => s.Semester, Semester).Set(s => s.Year, Year)
            );
        }
    }
}
