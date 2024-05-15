using Domain.Entities;
using Domain.Enum;
using Domain.Repositories;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class MoneyMovementRepository(ApplicationDbContext dbContext) : IMoneyMovementRepository
    {
        public async Task<int> Create(MoneyMovement entity)
        {
            await dbContext.AddAsync(entity);
            var saveResults = await dbContext.SaveChangesAsync();
            
            return saveResults;
        }

        public Task Delete(MoneyMovement entity)
        {
            throw new NotImplementedException();
        }

        public Task<MoneyMovement> Get(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<MoneyMovement>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<MoneyMovement>> GetMoneyMovementsByType(EMovementType type)
        {
            throw new NotImplementedException();
        }

        public Task Update(MoneyMovement entity)
        {
            throw new NotImplementedException();
        }
    }
}
