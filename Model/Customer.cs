namespace Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public Address? Address { get; set; }
        public Address? ShippingAddress { get; set; } = null;
    }
}
