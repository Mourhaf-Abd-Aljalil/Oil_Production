

namespace OilProduction.Application.Contracts
{
    public interface IAsyncRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int Id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task AddAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(int Id);

    }
}
