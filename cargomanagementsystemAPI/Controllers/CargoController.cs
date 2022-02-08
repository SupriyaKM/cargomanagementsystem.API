using cargomanagementsystem.BAL.Service;
using cargomanagementsystem.Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cargomanagementsystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private CustService _custService;
        public CargoController(CustService custService)
        {
            _custService = custService;
        }
        [HttpGet("GetCust_details")]
        public IEnumerable<Cust_details> GetCust_Details()
        {
            return _custService.GetCustdetails();
        }
        [HttpPost("AddCust_details")]
       public IActionResult AddCust_details([FromBody]Cust_details customer)
        {
            _custService.AddCust_Details(customer);
            return Ok("Successfully added Customer Details");
        }
        [HttpDelete("DeleteCust_details")]
        public IActionResult DeleteCust_details(int customerid)
        {
            _custService.DeleteCust_details(customerid);
            return Ok("Successfully deleted Customer Details");
        }
    }
}
