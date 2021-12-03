using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DTO
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("userIdPost")]
        public string UserIdPost { get; set; }

        [BsonElement("titlePost")]
        public string Title { get; set; }

        [BsonElement("bodyPost")]
        public string Body { get; set; }

        [BsonElement("likesPost")]
        public int LikesPost { get; set; }

        [BsonElement("likesUsersPost")]
        public List<string> LikesUsers { get; set; }

        [BsonElement("timePost")]
        public DateTime CreatedTime { get; set; }

        [BsonElement("comments")]
        public List<Comment> Comments { get; set; }

    }
}
