using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCTwoToFour.Controllers;
using MCTwoToFour.Services;


namespace MCTwoToFour.Services
{
    public class MCThreeServices
    {
        public string NameAndTimeAwake(string name, string timeAwake)
        {return $"Your name is {name} and you awoke at {timeAwake}. Cool!";}
    }
}