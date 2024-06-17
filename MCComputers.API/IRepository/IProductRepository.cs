using Common;
using MCComputers.API.Models;

namespace MCComputers.API.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetByListAsync(IEnumerable<Guid> ids);
    }
}
