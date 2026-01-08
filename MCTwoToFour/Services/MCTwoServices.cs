using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCTwoToFour.Models;
using MCTwoToFour.Controllers;
using MCTwoToFour.Services;

namespace MCTwoToFour.Services
{
    public class MCTwoServices
    {
        public string AddTwoNumbers(int num1, int num2){
        return $"The sum of {num1} and {num2} is {num1+num2}.";}
    }
}