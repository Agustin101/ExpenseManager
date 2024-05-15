using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration;

public sealed class MoneyMovementCategoriesConfiguration : IEntityTypeConfiguration<MoneyMovementCategory>
{
    public void Configure(EntityTypeBuilder<MoneyMovementCategory> builder)
    {
        builder.ToTable("MoneyMovementCategories");
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.MoneyMovements)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId);

        builder.Property(x => x.Description).HasMaxLength(100);
    }
}
