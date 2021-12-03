using System;
using DTO;
using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace DAL
{
    public class PostDynamoDAL
    {
        static AmazonDynamoDBClient client = new AmazonDynamoDBClient(new AmazonDynamoDBConfig { ServiceURL = "http://localhost:8000" });
        static string tableName = "UserStream";

        
        public static PostDynamo AddPost(PostDynamo post)
        {
            Dictionary<string, AttributeValue> item = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "POST#" + post.PostId} },
                {"SK", new AttributeValue{S = "POST#" + post.PostId} },
                {"PostId", new AttributeValue{S = post.PostId} },
                {"UserId", new AttributeValue{S = post.UserId} },
                {"Title", new AttributeValue{S = post.Title} },
                {"Body", new AttributeValue{S = post.Body} },
                {"CreatedTime", new AttributeValue{ S = post.CreatedTime.ToString("O")} },
                {"ModifiedTime", new AttributeValue{S = post.ModifiedTime.ToString("O")} }
            };

            var request = new PutItemRequest
            {
                TableName = tableName,
                Item = item
            };

            client.PutItem(request);
            return post;
        }
        
        public static void UpdatePost(string postId, string newVal) 
        {
            Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "POST#" + postId} },
                {"SK", new AttributeValue{S = "POST#" + postId } }
            };

            Dictionary<string, string> expAttNames = new Dictionary<string, string>
            {
                {"#B","Body" },
                {"#M","ModifiedTime" }
            };

            Dictionary<string, AttributeValue> expAttValues = new Dictionary<string, AttributeValue>
            {
                {":newval", new AttributeValue{ S = newVal} },
                {":newtime", new AttributeValue{S = DateTime.UtcNow.ToString("O")} }
            };

            var request = new UpdateItemRequest
            {
                TableName = tableName,
                Key = key,
                ExpressionAttributeNames = expAttNames,
                ExpressionAttributeValues = expAttValues,
                UpdateExpression = "SET #B = :newval, #M = :newtime"
            };

            client.UpdateItem(request);
        }

        public static PostDynamo GetPostById(string postId)
        {
            Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "POST#" + postId} },
                {"SK", new AttributeValue{S = "POST#" + postId} }
            };

            GetItemRequest request = new GetItemRequest
            {
                TableName = tableName,
                Key = key,
                ConsistentRead = true
            };
            var doc = client.GetItem(request);
            if (doc == null)
                throw new Exception("Not found post!");
            return DictToPost(doc.Item);
        }

        public static void DeletePost(string postId)
        {
            Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "POST#" + postId} },
                {"SK", new AttributeValue{S = "POST#" + postId} }
            };

            var request = new DeleteItemRequest
            {
                TableName = tableName,
                Key = key
            };

            client.DeleteItem(request);
        }

        static PostDynamo DictToPost(Dictionary<string, AttributeValue> dict)
        {
            var post = new PostDynamo();
            post.PostId = dict["PostId"].S;
            post.UserId = dict["UserId"].S;
            post.Title = dict["Title"].S;
            post.Body = dict["Body"].S;
            post.CreatedTime = Convert.ToDateTime(dict["CreatedTime"].S);
            post.ModifiedTime = Convert.ToDateTime(dict["ModifiedTime"].S);
            return post;
        }

        public static CommentDynamo AddComment(CommentDynamo comment)
        {
            Dictionary<string, AttributeValue> item = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "COMMENT#" + comment.CommentId} },
                {"SK", new AttributeValue{S = "COMMENT#" + comment.CommentId} },
                {"CommentId", new AttributeValue{S = comment.CommentId} },
                {"PostId", new AttributeValue{S = comment.PostId} },
                {"UserId", new AttributeValue{S = comment.UserId} },
                {"Body", new AttributeValue{S = comment.Body} },
                {"CreatedTime", new AttributeValue{ S = comment.CreatedTime.ToString("O")} },
                {"ModifiedTime", new AttributeValue{S = comment.ModifiedTime.ToString("O")} },
                {"GSIPK", new AttributeValue{S = "POSTCOMMENT#" + comment.PostId} },
                {"GSISK", new AttributeValue{S = comment.ModifiedTime.ToString("O")} }
            };

            var request = new PutItemRequest
            {
                TableName = tableName,
                Item = item
            };

            client.PutItem(request);
            return comment;
        }

        public static void UpdateCommentBody(string commentId, string newVal)
        {
            Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "COMMENT#" + commentId} },
                {"SK", new AttributeValue{S = "COMMENT#" + commentId } }
            };

            Dictionary<string, string> expAttNames = new Dictionary<string, string>
            {
                {"#B","Body" },
                {"#M","ModifiedTime" },
                {"#S","GSISK" }
            };

            Dictionary<string, AttributeValue> expAttValues = new Dictionary<string, AttributeValue>
            {
                {":newval", new AttributeValue{ S = newVal} },
                {":newtime", new AttributeValue{S = DateTime.UtcNow.ToString("O")} }
            };

            var request = new UpdateItemRequest
            {
                TableName = tableName,
                Key = key,
                ExpressionAttributeNames = expAttNames,
                ExpressionAttributeValues = expAttValues,
                UpdateExpression = "SET #B = :newval, #M = :newtime, #S = :newtime"
            };

            client.UpdateItem(request);
        }

        public static void DeleteComment(string commentId)
        {
            Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "COMMENT#" + commentId} },
                {"SK", new AttributeValue{S = "COMMENT#" + commentId } }
            };

            var request = new DeleteItemRequest
            {
                TableName = tableName,
                Key = key
            };
            client.DeleteItem(request);
        }

        public static CommentDynamo GetCommentById(string commentId)
        {
            Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
            {
                {"PK", new AttributeValue{S = "COMMENT#" + commentId} },
                {"SK", new AttributeValue{S = "COMMENT#" + commentId} }
            };

            GetItemRequest request = new GetItemRequest
            {
                TableName = tableName,
                Key = key,
                ConsistentRead = true
            };

            var doc = client.GetItem(request);
            if (doc == null)
                throw new Exception("Not found comment!");
            return DictToComment(doc.Item);
        }

        static CommentDynamo DictToComment(Dictionary<string,AttributeValue> dict)
        {
            var comment = new CommentDynamo();
            comment.CommentId = dict["CommentId"].S;
            comment.PostId = dict["PostId"].S;
            comment.UserId = dict["UserId"].S;
            comment.Body = dict["Body"].S;
            comment.CreatedTime = Convert.ToDateTime(dict["CreatedTime"].S);
            comment.ModifiedTime = Convert.ToDateTime(dict["ModifiedTime"].S);
            return comment;
        }

        public static List<CommentDynamo> GetCommentsSortedByPostId(string postId)
        {
            Dictionary<string, AttributeValue> expAttVal = new Dictionary<string, AttributeValue>
            {
                {":postid", new AttributeValue{S = "POSTCOMMENT#" + postId} }
            };

            var request = new QueryRequest
            {
                TableName = tableName,
                KeyConditionExpression = "GSIPK = :postid",
                ExpressionAttributeValues = expAttVal,
                IndexName = "GSI",
                ScanIndexForward = false //false - descending(newest first), true - ascending
            };
            var res = client.Query(request);

            List<CommentDynamo> list = new List<CommentDynamo>();
            foreach (var item in res.Items)
            {
                list.Add(DictToComment(item));
            }

            return list;
        }

    }
}
