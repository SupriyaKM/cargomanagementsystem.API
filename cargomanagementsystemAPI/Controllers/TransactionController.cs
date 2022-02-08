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
    public class TransactionController : ControllerBase
    {
        private TransactionService _transactionService;
        public TransactionController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpGet("GetTransaction_Details")]
        public IEnumerable<Transaction> GetTransaction_Details()
        {
            return _transactionService.GetTransaction();
        }
        [HttpPost("AddTransaction_Details")]
        public IActionResult AddTransaction_Details([FromBody] Transaction transaction)
        {
            _transactionService.AddTransaction_Details(transaction);
            return Ok("Successfully added Transaction Details");
        }
        [HttpDelete("DeleteTransaction_Details")]
        public IActionResult DeleteTransaction_Details(int Bill_no)
        {
            _transactionService.DeleteTransaction_Details(Bill_no);
            return Ok("Successfully deleted Transaction Details");
        }
        [HttpPut("UpdateTransaction_Details")]
        public IActionResult UpdateTransaction_Details(Transaction transaction)
        {
            _transactionService.UpdateTransaction_Details(transaction);
            return Ok("Successfully updated Transaction Details");
        }
        [HttpGet("GetTransaction_Detailsbyno")]
        public void GetTransaction_Detailsbyno(int Bill_no)
        {
            _transactionService.GetTransaction_Detailsbyno(Bill_no);
        }

    }
}
