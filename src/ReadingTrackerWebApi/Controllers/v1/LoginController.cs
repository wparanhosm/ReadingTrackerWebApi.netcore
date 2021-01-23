using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadingTracker.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadingTracker.WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginServices;
        public LoginController(ILoginService loginServices)
        {
            this.loginServices = loginServices;
        }


        [HttpPost("Login")]
        public ActionResult Login([FromForm] string login, [FromForm] string senha)
        {
            int value = loginServices.doLogin(login, senha);

            if(value > 0)
            {
                return Ok(new { Id = value });
            } else
            {
                return Unauthorized("Email e/ou senha incorretos");
            }
        }
    }
}
