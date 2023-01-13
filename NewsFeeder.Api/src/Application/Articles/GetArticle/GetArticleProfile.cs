using AutoMapper;
using Domain.Entities;

namespace Application.Articles.GetArticle;

public class GetArticleProfile : Profile
{
    public GetArticleProfile()
    {
        CreateMap<Article, GetArticleResult>();
    }
}