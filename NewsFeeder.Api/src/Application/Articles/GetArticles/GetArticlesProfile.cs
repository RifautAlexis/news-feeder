using AutoMapper;
using Domain.Entities;

namespace Application.Articles.GetArticles;

public class GetArticlesProfile : Profile
{
    public GetArticlesProfile()
    {
        CreateMap<Article, GetArticlesResult>();
    }
}