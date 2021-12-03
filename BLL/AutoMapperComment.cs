using AutoMapper;
using DTO;
using System;

namespace BLL
{
    //public class CommentDynamoConverter : ITypeConverter<Comment, CommentDynamo>
    //{
    //    public CommentDynamo Convert(Comment source, CommentDynamo destination, ResolutionContext context)
    //    {
    //        return new CommentDynamo
    //        {
    //            CommentId = source.Id,
    //            PostId = context.Options.Items["PostId"].ToString(),
    //            UserId = context.Options.Items["UserId"].ToString(),
    //            Body = source.CommentBody,
    //            CreatedTime = DateTime.UtcNow,
    //            ModifiedTime = DateTime.UtcNow
    //        };
    //    }
    //}

    public class AutoMapperComment : Profile
    {
        public AutoMapperComment()
        {
            CreateMap<Comment, CommentDynamo>()
                .ForMember(x => x.CommentId, s => s.MapFrom(x => x.Id))
                .ForMember(x => x.Body, s => s.MapFrom(x => x.CommentBody))
                .ForMember(x => x.CreatedTime, s => s.MapFrom(t => DateTime.UtcNow))
                .ForMember(x => x.ModifiedTime, s => s.MapFrom(t => DateTime.UtcNow));
        }

    }
}
