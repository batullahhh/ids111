namespace SOFT40081_StarterCode.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; } // Primary key
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Price * Quantity; // Read-only property
    }
}
