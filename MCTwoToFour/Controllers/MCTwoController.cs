using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCTwoToFour.Controllers;
using MCTwoToFour.Services;

namespace MCTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MCTwoController : ControllerBase
    {
        private readonly MCTwoServices _mcTwoServices;

        public MCTwoController(MCTwoServices mcTwoServices)
        {
            _mcTwoServices = mcTwoServices;
        }


        [HttpGet]
        [Route("EnterTwoNumbers/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2){
        return _mcTwoServices.AddTwoNumbers(num1, num2);
    }
}
}