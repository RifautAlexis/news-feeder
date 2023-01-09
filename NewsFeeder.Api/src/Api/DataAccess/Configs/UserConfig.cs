using Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.Configs;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(e => e.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        builder.Property(e => e.Email)
            .IsRequired();
        builder.Property(e => e.Name)
            .IsRequired();
        builder.Property(e => e.Role)
            .IsRequired();

        builder.HasKey(e => e.Id);
    }
}