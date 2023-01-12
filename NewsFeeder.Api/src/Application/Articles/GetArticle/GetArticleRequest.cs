using MediatR;

namespace Application.Articles.GetArticle;

public class GetArticleRequest : IRequest<GetArticleResult>
{
    public int Id { get; set; }
}