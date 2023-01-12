using Domain.Entities;
using AutoMapper;

namespace Application.Articles.GetArticle;

public class GetArticleProfile : Profile
{
    public GetArticleProfile()
    {
        CreateMap<Article, GetArticleResult>();
    }
}