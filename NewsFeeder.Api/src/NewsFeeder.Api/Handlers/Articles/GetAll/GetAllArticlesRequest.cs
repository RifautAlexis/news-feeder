using MediatR;

namespace NewsFeeder.Api.Endpoints.Articles
{
    public class GetAllArticlesRequest : IRequest<IEnumerable<ArticleResult>>
    {
    }
}
