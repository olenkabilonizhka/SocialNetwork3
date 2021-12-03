using DTO;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserNeoDAL
    {
        static GraphClient client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "test");

        public static void AddUser(UserNeo user)
        {
            using (client)
            {
                client.Connect();
                client.Cypher
                    .Create("(u:User {newUser})")
                    .WithParam("newUser", user)
                    .ExecuteWithoutResults();
            }
        }

        public static void DeleteUser(string userId)
        {
            using (client)
            {
                client.Connect();
                client.Cypher
                .Match("(u:User {id: {userId}})")
                .WithParam("userId", userId)
                .Delete("u")
                .ExecuteWithoutResults();
            }
        }

        public static void CreateRelationship(string userIdCurrent, string userIdProfile)
        {
            using (client)
            {
                client.Connect();
                client.Cypher
                .Match("(uC:User {id: {uCurrId}})", "(uP:User {id: {uProfId}})")
                .WithParam("uCurrId", userIdCurrent)
                .WithParam("uProfId", userIdProfile)
                .Create("(uC)-[:FOLLOW]->(uP)")
                .ExecuteWithoutResults();
            }
        }

        public static void DeleteRelationship(string userIdCurrent, string userIdProfile)
        {
            using (client)
            {
                client.Connect();
                client.Cypher
                .Match("(uC:User {id: {uCurrId}})-[r:FOLLOW]->(uP:User {id: {uProfId}})")
                .WithParam("uCurrId", userIdCurrent)
                .WithParam("uProfId", userIdProfile)
                .Delete("r")
                .ExecuteWithoutResults();
            }
        }

        public static int ShortestPathBetweenUsers(string userIdCurrent, string userIdProfile)
        {
            int res;
            using (client)
            {
                client.Connect();
                if (userIdCurrent == userIdProfile)
                    return 0;
                res = client.Cypher
                    .Match("d=shortestPath((uC:User {id: {uCurrId}})-[*..5]->(uP:User {id: {uProfId}}))")
                    .WithParam("uCurrId", userIdCurrent)
                    .WithParam("uProfId", userIdProfile)
                    .Return((d) => new { len = Return.As<int>("length(d)") }).Results.Single().len;
                return res;
            }
        }

        public static bool IfFollower(string userIdCurrent, string userIdProfile)
        {
            return ShortestPathBetweenUsers(userIdCurrent, userIdProfile) == 1 ? true : false;
        }

        public static void FollowOrUnfollowUser(string userIdCurrent, string userIdProfile)
        {
            if (IfFollower(userIdCurrent, userIdProfile))
                DeleteRelationship(userIdCurrent, userIdProfile);
            else
                CreateRelationship(userIdCurrent,userIdProfile);
        }

        public static void DeleteRelationshipsOfUser(string userId)
        {
            using (client)
            {
                client.Connect();
                client.Cypher
                    .Match("(u:User {id: {uCurrId}})-[r:FOLLOW]->(u2:User)")
                    .WithParam("uCurrId", userId)
                    .Delete("r")
                    .ExecuteWithoutResults();
                client.Cypher
                    .Match("(u2:User)-[r:FOLLOW]->(u:User {id: {uCurrId}})")
                    .WithParam("uCurrId", userId)
                    .Delete("r")
                    .ExecuteWithoutResults();
            }
        }

    }
}
