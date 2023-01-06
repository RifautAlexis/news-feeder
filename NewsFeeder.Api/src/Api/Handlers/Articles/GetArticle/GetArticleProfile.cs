using AutoMapper;
using Api.Domain;

namespace Api.Endpoints.Articles;

public class GetArticleProfile : Profile
{
    public GetArticleProfile()
    {
        CreateMap<Article, GetArticleResult>();
    }
}
