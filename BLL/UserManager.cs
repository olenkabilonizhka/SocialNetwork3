using DAL;
using DTO;
using System;

namespace BLL
{
    public class UserManager
    {
        public static void AddUser(User user)
        {
            var uId = UserDAL.AddUser(user);
            UserNeoDAL.AddUser(new UserNeo { Id = uId, Name = $"{user.FirstName} {user.LastName}"});
        }

        public static void DeleteUser(User user)
        {
            PostDAL.DeletePostsOfUser(user);
            UserNeoDAL.DeleteRelationshipsOfUser(user.Id);

            UserDAL.DeleteUser(user);
            UserNeoDAL.DeleteUser(user.Id);
        }

        public static string CheckLogin(string email, string password)
        {
            var foundUser = UserDAL.FindUserByEmailAndPassword(email,password);

            if (foundUser == null)
                throw new Exception("Not correct email or password");
            else
                return foundUser.Id;
        }

        public static string FindUserProfile(string name)
        {
            var foundUser = UserDAL.FindUserByFullName(name);

            if (foundUser == null)
                throw new Exception("No user with this name");
            else
                return foundUser.Id;
        }

        public static User GetUserById(string userIdCurrent)
        {
            return UserDAL.GetUserById(userIdCurrent);
        }

        public static bool IfFollower(string userIdCurrent, string userIdProfile)
        {
            return UserNeoDAL.IfFollower(userIdCurrent, userIdProfile);
        }

        public static void FollowUser(string userIdCurrent, string userIdProfile)
        {
            if (userIdCurrent == userIdProfile)
                throw new Exception("Can't follow yourself");
            UserNeoDAL.FollowOrUnfollowUser(userIdCurrent,userIdProfile);
            UserDAL.FollowOrUnfollowUser(userIdCurrent, userIdProfile);
        }

        public static int LengthToUser(string userIdCurrent, string userIdProfile)
        {
            return UserNeoDAL.ShortestPathBetweenUsers(userIdCurrent,userIdProfile);
        }

    }
}
