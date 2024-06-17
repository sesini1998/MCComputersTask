namespace MCComputers.API.Models
{
    public class InvoiceItem
    {
        public Guid Id { get; set; }
        public required int ProductQuantity { get; set; }
        public required decimal ProductPrice { get; set; }
        public required decimal Amount { get; set; }
        public required Guid ProductId { get; set; }
        public Product Product { get; set; }
        public required Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
