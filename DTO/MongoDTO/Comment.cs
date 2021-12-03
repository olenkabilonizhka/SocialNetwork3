using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DTO
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("body")]
        public string CommentBody { get; set; }

        [BsonElement("likesComment")]
        public int Likes { get; set; }

        [BsonElement("likesUsers")]
        public List<string> LikesUsers { get; set; }

    }
}
