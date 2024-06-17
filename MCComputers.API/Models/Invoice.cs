namespace MCComputers.API.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public required int Quantity { get; set; }
        public required decimal TotalAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public required DateTime TransactionDate { get; set; }
        public decimal Discount { get; set; }
        public required Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; } = [];
    }
}
