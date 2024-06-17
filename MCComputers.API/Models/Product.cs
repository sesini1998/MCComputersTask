namespace MCComputers.API.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public required string ProductName { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required int StockQuantity { get; set; }
        public required decimal Discount { get; set; }
    }
}
