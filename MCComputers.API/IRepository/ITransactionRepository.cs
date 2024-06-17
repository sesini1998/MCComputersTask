using Common;
using MCComputers.API.Models;

namespace MCComputers.API.IRepository
{
    public interface ITransactionRepository : IRepository<Invoice>
    {
        Task AddInvoiceItemsAsync(IEnumerable<InvoiceItem> invoiceItems);
        Task<Invoice?> GetByIdWithItemsAsync(Guid id);
    }
}
