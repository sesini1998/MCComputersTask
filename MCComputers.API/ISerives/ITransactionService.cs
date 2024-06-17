using Common;
using MCComputers.API.Models;

namespace MCComputers.API.IService
{
    public interface ITransactionService : IService<Invoice>
    {
        Task AddInvoiceItemsAsync(IEnumerable<InvoiceItem> invoiceItems);
        Task<Invoice?> GetByIdWithItemsAsync(Guid id);
        Task CreateTransAsync(Invoice invoice, IEnumerable<Guid> ids);
    }
}
