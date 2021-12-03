using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;

namespace DAL
{
    public class UserDAL
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase database = client.GetDatabase("sn");
        static IMongoCollection<User> users = database.GetCollection<User>("users");

        public static string AddUser(User user)
        {
            user.Id = ObjectId.GenerateNewId().ToString();
            users.InsertOne(user);
            return user.Id;
        }

        public static void DeleteUser(User user)
        {
            users.DeleteOne(x => x.Id == user.Id);
        }

        public static User FindUserByEmailAndPassword(string email,string password)
        {
            return users.Find(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

        public static User FindUserByFullName(string name)
        {
            var valueArr = name.Split(' ');
            return users.Find(x => (x.FirstName == valueArr[0] && x.LastName == valueArr[1])).FirstOrDefault(); ;
        }

        public static User GetUserById(string userIdCurrent)
        {
            return users.Find(x => x.Id == userIdCurrent).FirstOrDefault();
        }

        public static bool IfFollower(string userIdCurrent, string userIdProfile)
        {
            return users.Find(x => x.Id == userIdCurrent).FirstOrDefault().FollowPeople.Contains(userIdProfile) ? true : false;
        }

        public static void FollowOrUnfollowUser(string userIdCurrent, string userIdProfile)
        {
            var followArray = users.Find(x => x.Id == userIdCurrent).Project("{_id:0,followPeople:1}").FirstOrDefault().First().Value.AsBsonArray;
            if (IfFollower(userIdCurrent, userIdCurrent)) { }
            else if (IfFollower(userIdCurrent, userIdProfile))
                followArray.Remove(userIdProfile);
            else
                followArray.Add(userIdProfile);

            var filter = Builders<User>.Filter.Eq(x => x.Id, userIdCurrent);
            var update = Builders<User>.Update.Set("followPeople", followArray);
            users.UpdateOne(filter, update);
        }

    }
}
