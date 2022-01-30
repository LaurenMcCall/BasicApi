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
        public string HelloWorld(string who = "World")
        {
            // string whoOrWorld;

            // if (who == null)
            // {
            //     whoOrWorld = "World";
            // }
            // else
            // {
            //     whoOrWorld = who;
            // }
            // string whoOrWorld = (who == null) ? "World" : who;
            return $"Hello, {who}. {DateTime.Now}";
        }
    }
}