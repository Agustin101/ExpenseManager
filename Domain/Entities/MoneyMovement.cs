using Domain.Common;
using Domain.Enum;

namespace Domain.Entities;

public class MoneyMovement : BaseEntity
{
    public decimal MoneyAmount { get; set; }
    public int CategoryId { get; set; }
    public virtual MoneyMovementCategory Category { get; set; } = null!;
    public EMovementType MovementType { get; set; }
    public DateTime Date { get; set; }
    public string? Description { get; set; }
    public byte[]? Photo { get; set; }

}
