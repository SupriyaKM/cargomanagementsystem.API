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
    public class RegisterController : ControllerBase
    {
        private RegisterService _registerService;
        public RegisterController(RegisterService registerService)
        {
            _registerService = registerService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody]cargomanagementRegister cargomanagementRegister)
        {
            _registerService.Register(cargomanagementRegister);
            return Ok("Registerd Successfully");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] cargomanagementRegister cargologin)
        {
            cargomanagementRegister user = _registerService.Login(cargologin);
            if (user != null)
                return Ok("Login Success!!!");
            else
                return NotFound();
        }
    }
}
