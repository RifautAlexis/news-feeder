using AutoMapper;
using NewsFeeder.Api.Domain;

namespace NewsFeeder.Api.Endpoints.Articles;

public class ArticleByIdProfile : Profile
{
    public ArticleByIdProfile()
    {
        CreateMap<Article, ArticleByIdResult>();
    }
}
