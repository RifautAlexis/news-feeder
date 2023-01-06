using MediatR;

namespace Api.Endpoints.Articles
{
    public class GetArticlesRequest : IRequest<IEnumerable<GetArticlesResult>>
    {
    }
}
