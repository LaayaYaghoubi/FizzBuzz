using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Logics
{
    public class FizzBuzzGame
    {
        public string DivisibleTest(int currentNumber)
        {

            if (currentNumber % 3 == 0 && currentNumber % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (currentNumber % 3 == 0)
            {
                return "Fizz";
            }
            else if (currentNumber % 5 == 0)
            {
                return "Buzz";
            }

            else return "Not Divisible By 3 or 5 or Both";
        }
    }
}
