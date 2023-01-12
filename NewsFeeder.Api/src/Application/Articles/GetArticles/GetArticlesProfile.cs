using Domain.Entities;
using AutoMapper;

namespace Application.Articles.GetArticles;

public class GetArticlesProfile : Profile
{
    public GetArticlesProfile()
    {
        CreateMap<Article, GetArticlesResult>();
    }
}