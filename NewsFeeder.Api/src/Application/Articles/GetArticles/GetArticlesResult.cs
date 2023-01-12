using Domain.Entities;

namespace Application.Articles.GetArticles;

public class GetArticlesResult : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int AuthorId { get; set; }
    public int? UpdaterId { get; set; }
}