using MediatR;

namespace NewsFeeder.Api.Endpoints.Articles;

public class ArticleByIdRequest : IRequest<ArticleByIdResult>
{
    public int Id { get; set; }
}
