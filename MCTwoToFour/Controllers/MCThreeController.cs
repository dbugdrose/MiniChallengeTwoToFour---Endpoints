using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCTwoToFour.Controllers;
using MCTwoToFour.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCTwoToFour.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCThreeController : ControllerBase
    {
        private readonly MCThreeServices _mcThreeServices;

        public MCThreeController(MCThreeServices mcThreeServices)
        {
            _mcThreeServices = mcThreeServices;
        }

        [HttpGet]
        [Route("NameAndTimeYouAwoke/{name}/{timeAwake}")]
        
        public string NameAndTime(string name, string timeAwake)
        {
            return _mcThreeServices.NameAndTimeAwake(name, timeAwake);
        }
    }
}