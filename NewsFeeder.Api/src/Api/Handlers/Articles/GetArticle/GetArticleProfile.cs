using Api.Domain;
using AutoMapper;

namespace Api.Endpoints.Articles;

public class GetArticleProfile : Profile
{
    public GetArticleProfile()
    {
        CreateMap<Article, GetArticleResult>();
    }
}