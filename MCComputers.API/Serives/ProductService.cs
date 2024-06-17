using Common;
using MCComputers.API.IRepository;
using MCComputers.API.IService;
using MCComputers.API.Models;
using MCComputers.API.Repository;

namespace MCComputers.API.Serives
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {
        }
    }
}
