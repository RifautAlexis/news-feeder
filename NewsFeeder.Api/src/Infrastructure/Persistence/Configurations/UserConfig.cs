using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

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