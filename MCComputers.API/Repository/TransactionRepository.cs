using Common;
using MCComputers.API.Data;
using MCComputers.API.IRepository;
using MCComputers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.API.Repository
{
    public class TransactionRepository : GenericRepository<Invoice>, ITransactionRepository
    {
        private readonly ApplicationDbContext _context;
        public TransactionRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task AddInvoiceItemsAsync(IEnumerable<InvoiceItem> invoiceItems)
        {
            _context.InvoiceItems.AddRange(invoiceItems);
            await _context.SaveChangesAsync();
        }

        public async Task<Invoice?> GetByIdWithItemsAsync(Guid id)
        {
            return await _context.Invoices
            .Include(i => i.InvoiceItems)
            .ThenInclude(p => p.Product)
            .Include(i => i.Customer)
            .FirstOrDefaultAsync(i => i.Id == id);
        }

        public override async Task<IEnumerable<Invoice>> GetAllAsync()
        {
            return await _context.Invoices.Include(i => i.Customer).ToListAsync();
        }
    }
}
