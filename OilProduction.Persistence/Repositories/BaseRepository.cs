

using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Persistence.Data;

namespace OilProduction.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        private readonly OilProductionDbContext _context;

        public BaseRepository(OilProductionDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T Entity)
        {
            await _context.Set<T>().AddAsync(Entity);
            await _context.SaveChangesAsync();
            
            //if (Entity == null)
            //{
            //    return false;
            //}
            //try
            //{
            //    _context.Set<T>().AddAsync(T);
            //    await _context.SaveChangesAsync();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    {
            //        Console.WriteLine(ex.ToString());
            //    }
            //    return false;
            //}
        }

        public async Task DeleteAsync(int Id)
        {
            var Entity = await _context.Set<T>().FindAsync(Id);
            _context.Set<T>().Remove(Entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await _context.Set<T>().FindAsync(Id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T Entity)
        {
            _context.Set<T>().Update(Entity);
            await _context.SaveChangesAsync();
        }

      }
}
