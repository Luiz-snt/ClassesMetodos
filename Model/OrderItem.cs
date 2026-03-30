namespace Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; } = null!;
        public float Quantity { get; set; }
        public double SalePrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
