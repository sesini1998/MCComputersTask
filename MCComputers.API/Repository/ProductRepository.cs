using Common;
using MCComputers.API.Data;
using MCComputers.API.IRepository;
using MCComputers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.API.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Product>> GetByListAsync(IEnumerable<Guid> ids)
        {
            return await _context.Products.Where(
                e => ids.Contains(e.Id)).ToListAsync();
        }

    }
}
