using Domain.Entities;
using Domain.Enum;

namespace Domain.Repositories;

public interface IMoneyMovementRepository : IBaseRepository<MoneyMovement>
{
    Task<IQueryable<MoneyMovement>> GetMoneyMovementsByType(EMovementType type);   
}
