using MediatR;

namespace Application.Articles.GetArticles;

public class GetArticlesRequest : IRequest<IEnumerable<GetArticlesResult>>
{
}