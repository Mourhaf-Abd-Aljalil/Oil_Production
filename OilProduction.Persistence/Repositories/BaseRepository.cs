

using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Domain.Entities;
using OilProduction.Persistence.Data;

namespace OilProduction.Persistence.Repositories
{
    public class BaseRepository<T> : IDbOperationService
    {
        private readonly OilProductionDbContext _context;

        public BaseRepository(OilProductionDbContext context)
        {
            _context = context;
        }


        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task RollBackAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync<TModel>(TModel model) where TModel : BaseModel
        {
            await _context.Set<TModel>().AddAsync(model);
        }

        public async Task AddRangeAsync<TModel>(IEnumerable<TModel> models) where TModel : BaseModel
        {
            await _context.Set<TModel>().AddRangeAsync(models);
        }

        public IQueryable<TModel> Set<TModel>() where TModel : BaseModel
        {
            return _context.Set<TModel>().AsQueryable();
        }

    }
}
