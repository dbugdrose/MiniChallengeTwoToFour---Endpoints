using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCTwoToFour.Models;


namespace MCTwoToFour.Services
{
    public class MCFourServices
    {
        public string GreaterOrLessThan(int num3, int num4)
        {
            if (num3 > num4)
            {return $"{num3} is greater than {num4}. {num4} is less than {num3}.";}
            else if (num3 < num4)
            {return $"{num3} is less than {num4}. {num4} is greater than {num3}.";}
            else
            return $"{num3} is equal to {num4}. {num4} is also equal to {num3}.";
        
        }
    }
}