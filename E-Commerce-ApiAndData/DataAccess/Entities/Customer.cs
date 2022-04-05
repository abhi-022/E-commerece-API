using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerName { get; set; }

        public int Phone { get; set; }

        public string? Address { get; set; }

        public int Wallet { get; set; }
    }
}
