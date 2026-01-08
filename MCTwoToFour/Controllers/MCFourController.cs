using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCTwoToFour.Models;
using MCTwoToFour.Controllers;
using MCTwoToFour.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTwoToFour.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCFourController : ControllerBase
    {
        private readonly MCFourServices _mcFourServices;

        public MCFourController(MCFourServices mcFourServices)
        {
            _mcFourServices = mcFourServices;
        }

        [HttpGet]
        [Route("GreaterOrLessThan/{num3}/{num4}")]
        public string GreaterOrLessThan (int num3, int num4)
        {
            return _mcFourServices.GreaterOrLessThan(num3, num4);
        }
    }
}