using NewsFeeder.Api.Domain;

namespace NewsFeeder.Api.Endpoints.Articles;

public class ArticleByIdResult : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int AuthorId { get; set; }
    public int? UpdaterId { get; set; }
}
