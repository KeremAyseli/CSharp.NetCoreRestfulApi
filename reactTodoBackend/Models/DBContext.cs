using System;
using MongoDB.Driver;

namespace reactTodoBackend.Models
{
    class DBContext
    {
        MongoClientSettings settings;

        IMongoDatabase database;
        private readonly IMongoCollection<User> _user;
        public DBContext()
        {

            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:Q3o8w8V9kDVryLmp@cluster0.n8wz0.mongodb.net/React?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("React");
            _user = database.GetCollection<User>("todo");

        }
        public User AddUser(User user)
        {
            _user.InsertOne(user);
            return user;
        }

    }
}