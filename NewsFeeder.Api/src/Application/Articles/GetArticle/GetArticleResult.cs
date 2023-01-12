using Domain.Entities;

namespace Application.Articles.GetArticle;

public class GetArticleResult : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int AuthorId { get; set; }
    public int? UpdaterId { get; set; }
}