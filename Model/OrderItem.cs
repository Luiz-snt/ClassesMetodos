namespace Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; } = null!;
        public float Qty { get; set; }
        public double SalePrice { get; set; }
        public double TotalPrice { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(
            int id, 
            Product product, 
            float qty, 
            double salePrice, 
            double totalPrice
        )
        {
            Id = id;
            Product = product;
            Qty = qty;
            SalePrice = salePrice;
            TotalPrice = totalPrice;
        }
    }
}