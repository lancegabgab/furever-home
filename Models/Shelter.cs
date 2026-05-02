using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FureverHome.Models
{
    public class Shelter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
