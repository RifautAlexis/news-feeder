using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsFeeder.Api.Domain;

namespace NewsFeeder.Api.DataAccess.Configs;

public class ArticleConfig : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.Property(e => e.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Property(e => e.Title)
            .IsRequired();
        builder.Property(e => e.Content)
            .IsRequired();

        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.Author)
            .WithMany(e => e.WrittenArticles)
            .HasForeignKey(e => e.AuthorId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
        builder.HasOne(e => e.Updater)
            .WithMany(e => e.UpdatedArticles)
            .HasForeignKey(e => e.UpdaterId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired(false);
    }
}
