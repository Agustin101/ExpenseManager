using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration;

public sealed class MoneyMovementConfiguration : IEntityTypeConfiguration<MoneyMovement>
{
    public void Configure(EntityTypeBuilder<MoneyMovement> builder)
    {
        builder.ToTable("MoneyMovements");
        builder.HasKey(mm => mm.Id);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.MoneyMovements)
            .HasForeignKey(x => x.CategoryId);

        builder.Property(x => x.Description).HasMaxLength(100);
    }
}
