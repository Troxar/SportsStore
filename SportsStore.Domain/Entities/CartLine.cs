namespace SportsStore.Domain.Entities
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal ComputeValue()
        {
            return (Product?.Price ?? 0) * Quantity;
        }
    }
}
