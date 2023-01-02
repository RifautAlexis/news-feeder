namespace NewsFeeder.Api.Domain;

public class Article : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int AuthorId { get; set; }
    public int? UpdaterId { get; set; }

    public virtual User Author { get; set; }
    public virtual User? Updater { get; set; }
}
