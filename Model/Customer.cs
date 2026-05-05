namespace Model
{
    public class Customer : People
    {
        #region Attributes

        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public Address? HomeAddress { get; set; }
        public Address ShippingAddress { get; set; } = null!;

        #endregion

        #region Constructors

        public Customer()
        {
        }

        public Customer(
            int id, 
            string firstName, 
            string lastName, 
            string email, 
            string phone, 
            Address? homeAddress, 
            Address shippingAddress
        )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            HomeAddress = homeAddress;
            ShippingAddress = shippingAddress;
        }

        #endregion
    }
}
