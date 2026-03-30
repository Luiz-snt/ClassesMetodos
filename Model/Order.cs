using static Core.Enums.Enums;
namespace Model
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<OrderItem> OrdemItems { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Openned;
}
}
