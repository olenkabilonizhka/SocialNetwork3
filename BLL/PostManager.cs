using AutoMapper;
using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PostManager
    {
        static IMapper mapper = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new AutoMapperPost());
            mc.AddProfile(new AutoMapperComment());
        }).CreateMapper();

        public static List<Post> GetSortedPosts()
        {
            return PostDAL.GetSortedPosts();
        }

        public static Post GetPostById(string postId)
        {
            return PostDAL.GetPostById(postId);
        }

        public static Comment GetCommentById(string postId, string commentId)
        {
            return PostDAL.GetCommentById(postId,commentId);
        }

        public static List<Post> GetUserPosts(string userId)
        {
            return PostDAL.GetUserPosts(userId);
        }

        public static string AddComment(string postId, string userId, Comment comment)
        {
            comment.Id = PostDAL.AddComment(postId, comment).Id;

            var commentD = mapper.Map<Comment,CommentDynamo>(comment);
            commentD.PostId = postId;
            commentD.UserId = userId;
            PostDynamoDAL.AddComment(commentD);

            return comment.Id;
        }

        public static string AddPost(Post post)
        {
            post.Id = PostDAL.AddPost(post).Id;

            var postD = mapper.Map<PostDynamo>(post);
            PostDynamoDAL.AddPost(postD);

            return post.Id;
        }

        public static void LikePost(string postId, string userIdCurrent)
        {
            PostDAL.LikePost(postId,userIdCurrent);
        }

        public static void LikeComment(string postId, string commentId, string userIdCurrent)
        {
            PostDAL.LikeComment(commentId, userIdCurrent);
        }

        public static void SavePost(string postId, string newVal, bool TitleOrBody = false)
        {
            PostDynamoDAL.UpdatePost(postId, newVal);
            PostDAL.UpdatePost(postId,newVal);
        }

        public static void SaveComment(string postId, string commentId, string newVal)
        {
            PostDynamoDAL.UpdateCommentBody(commentId,newVal);
            PostDAL.UpdateComment(postId,commentId,newVal);
        }

        public static List<Comment> GetCommentsSorted(string postId)
        {
            var list = new List<Comment>();
            foreach (var item in PostDynamoDAL.GetCommentsSortedByPostId(postId))
            {
                list.Add(GetCommentById(item.PostId, item.CommentId));
            }
            return list;
        }

        public static string GetUserIdByCommentId(string commentId)
        {
            var c = PostDynamoDAL.GetCommentById(commentId);
            return c.UserId;
        }

    }
}
