using AutoMapper;
using NewsFeeder.Api.Domain;

namespace NewsFeeder.Api.Endpoints.Articles;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, ArticleResult>();
    }
}
