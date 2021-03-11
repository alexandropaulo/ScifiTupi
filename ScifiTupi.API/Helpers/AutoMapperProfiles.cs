using AutoMapper;
using ScifiTupi.API.Dtos;
using ScifiTupi.API.Models;

namespace ScifiTupi.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Article, ArticleForContentDto>()
               .ForMember(dest => dest.Category, opt => 
                    opt.MapFrom(src => src.Category.Title));
            CreateMap<Article, ArticleForReadingDto>()
               .ForMember(dest => dest.Category, opt => 
                    opt.MapFrom(src => src.Category.Title));
            CreateMap<Comment, CommentForReadingDto>();
            CreateMap<Comment, CommentForListDto>();
        }
    }
}