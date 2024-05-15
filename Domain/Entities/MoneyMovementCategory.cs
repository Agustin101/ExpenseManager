using Domain.Common;

namespace Domain.Entities;

public class MoneyMovementCategory : BaseEntity
{
    public string Description { get; set; } = null!;
    public virtual ICollection<MoneyMovement> MoneyMovements { get; set; } = null!;
}
