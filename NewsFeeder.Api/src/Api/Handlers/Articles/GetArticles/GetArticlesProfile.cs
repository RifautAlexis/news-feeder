using AutoMapper;
using Api.Domain;

namespace Api.Endpoints.Articles;

public class GetArticlesProfile : Profile
{
    public GetArticlesProfile()
    {
        CreateMap<Article, GetArticlesResult>();
    }
}
