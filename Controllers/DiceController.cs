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
    public class DiceController : ControllerBase
    {
        [HttpGet("{sides}")]
        public List<int> Roll(int sides, int count = 1)
        {
            var rolls = new List<int>();

            var randomNumberGenerator = new Random();

            for (var rollNumber = 0; rollNumber < count; rollNumber++)
            {
                var roll = randomNumberGenerator.Next(sides) + 1;

                rolls.Add(roll);
            }


            return rolls;
        }
    }
}