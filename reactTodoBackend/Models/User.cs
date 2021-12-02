using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace reactTodoBackend.Models{
    class User{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
       [BsonElement("Email")]
        public string Email { get; set; }

    }
}