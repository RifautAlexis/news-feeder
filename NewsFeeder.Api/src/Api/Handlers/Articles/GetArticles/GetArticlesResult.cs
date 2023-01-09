using Api.Domain;

namespace Api.Endpoints.Articles;

public class GetArticlesResult : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int AuthorId { get; set; }
    public int? UpdaterId { get; set; }
}