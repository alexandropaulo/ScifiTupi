using AutoMapper;
using ScifiTupi.API.Dtos;
using ScifiTupi.API.Models;

namespace ScifiTupi.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Article, ArticleForContentDto>();
            CreateMap<Article, ArticleForReadingDto>();
            CreateMap<Comment, CommentForReadingDto>();
            CreateMap<Comment, CommentForListDto>();
        }
    }
}