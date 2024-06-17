using Common;
using MCComputers.API.IRepository;
using MCComputers.API.IService;
using MCComputers.API.Models;
using MCComputers.API.Repository;

namespace MCComputers.API.Serives
{
    public class TransactionService : GenericService<Invoice>, ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IProductRepository _productRepository;
        public TransactionService(ITransactionRepository repository, 
            IProductRepository productRepository) : base(repository)
        {
            this._repository = repository;
            this._productRepository = productRepository;
        }

        public async Task AddInvoiceItemsAsync(IEnumerable<InvoiceItem> invoiceItems)
        {
            await _repository.AddInvoiceItemsAsync(invoiceItems);
        }

        public async Task CreateTransAsync(Invoice invoice, IEnumerable<Guid> ids)
        {
            var products = await _productRepository.GetByListAsync(ids);

            invoice.Discount = products.Sum(p => p.Discount * p.Price);
            invoice.BalanceAmount = invoice.TotalAmount - invoice.Discount;

            await _repository.AddAsync(invoice);
        }

        public async Task<Invoice?> GetByIdWithItemsAsync(Guid id)
        {
            return await _repository.GetByIdWithItemsAsync(id);
        }
    }
}
