using MediatR;

namespace Api.Endpoints.Articles;

public class GetArticleRequest : IRequest<GetArticleResult>
{
    public int Id { get; set; }
}