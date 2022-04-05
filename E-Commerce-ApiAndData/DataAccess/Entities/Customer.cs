namespace DataAccess.Entities
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerName { get; set; }

        public string Password { get; set; }

        public long Phone { get; set; }

        public string? Address { get; set; }

        public int Wallet { get; set; }
    }
}
