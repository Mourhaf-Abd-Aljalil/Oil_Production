

using OilProduction.Domain.Entities;

namespace OilProduction.Application.Contracts
{
    public interface IDbOperationService
    {
        Task BeginTransactionAsync();
        Task RollBackAsync();
        Task CommitAsync();
        Task SaveAsync();
        Task AddAsync<TModel>(TModel model) where TModel : BaseModel;
        Task AddRangeAsync<TModel>(IEnumerable<TModel> models) where TModel : BaseModel;
        IQueryable<TModel> Set<TModel>() where TModel : BaseModel;
    }
}
