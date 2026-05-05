
using static Core.Enums.Enums;

namespace Model
{    
    public class Order
    {
        #region Attributes
        public int Id { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<OrderItem> OrderItems { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Openned;
        #endregion

        #region
        public Order()
        {
        }

        public Order(
            int id, 
            Customer customer, 
            List<OrderItem> orderItems, 
            DateTime orderDate, 
            OrderStatus orderStatus
        )
        {
            Id = id;
            Customer = customer;
            OrderItems = orderItems;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
        #endregion
    }
}
