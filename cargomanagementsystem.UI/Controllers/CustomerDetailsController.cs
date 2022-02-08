using cargomanagementsystem.Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cargomanagementsystem.UI.Controllers
{
    public class CustomerDetailsController : Controller
    {
        private IConfiguration _configuration;
        public CustomerDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Customer(Cust_details customer)
        {
            ViewBag.status = "";
            if (Request.Form.Files.Count > 0)
            {
                MemoryStream ms = new MemoryStream();
                Request.Form.Files[0].CopyTo(ms);

            }
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "CargoController/AddCust_details";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Customer details saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }

    }
}
