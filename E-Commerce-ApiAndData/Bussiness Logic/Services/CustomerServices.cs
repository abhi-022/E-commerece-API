using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Services
{
    public class CustomerServices
    {
        private readonly EComDbContext _EComDbContext;

        public CustomerServices(EComDbContext EComDbContext)
        {
            _EComDbContext = EComDbContext;
        }

        public List<Customer> GetAllCustomers()
        {
            var cust = _EComDbContext.Customers;
            return cust.ToList();
        }
    }
}
