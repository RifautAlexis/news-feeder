namespace Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
    public Role Role { get; set; }

    public virtual ICollection<Article> WrittenArticles { get; set; }
    public virtual ICollection<Article> UpdatedArticles { get; set; }
}