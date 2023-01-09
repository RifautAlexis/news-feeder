using Api.Domain;
using AutoMapper;

namespace Api.Endpoints.Articles;

public class GetArticlesProfile : Profile
{
    public GetArticlesProfile()
    {
        CreateMap<Article, GetArticlesResult>();
    }
}