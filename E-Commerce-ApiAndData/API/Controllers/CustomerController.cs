using Bussiness_Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController:ControllerBase
    {
        //Dependency Injection
        private readonly CustomerServices _CustomerServices;
        public CustomerController(CustomerServices customerServices)
        {
            _CustomerServices = customerServices;  
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var cust = _CustomerServices.GetAllCustomers();
            return Ok(cust);
        }
    }
}
