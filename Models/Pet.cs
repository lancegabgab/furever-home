using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using FureverHome.Enums;

namespace FureverHome.Models
{
    public class Pet
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
      
        [BsonRepresentation(BsonType.String)]
        public PetType PetType { get; set; }
      
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public PetGender Gender { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public required string ShelterId { get; set; }
      
        [BsonRepresentation(BsonType.String)]
        public PetStatus Status { get; set; } = PetStatus.Available;
      
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
