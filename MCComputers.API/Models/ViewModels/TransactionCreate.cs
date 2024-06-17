namespace MCComputers.API.Models.ViewModels
{
    public class TransactionCreate
    {
        public Guid CustomerId { get; set; }
        public List<SingleItem> InvoiceItems { get; set; } = [];
    }

    public class SingleItem
    {
        public required Guid ProductId { get; set; }
        public required int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
