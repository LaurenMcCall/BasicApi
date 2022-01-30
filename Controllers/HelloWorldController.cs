using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string HelloWorld(string who)
        {
            var currentDateAndTime = DateTime.Now;
            return $"Hello, {who}. {currentDateAndTime}";
        }
    }
}