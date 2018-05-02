using System;
using static System.Console;
using System.Text;

namespace Packt.PrimeFactors
{
    public class PrimeFactors
    {
        public string Fetch(int num)
        {
            StringBuilder returnString = new StringBuilder("");
            
            // determine how many times we can divide the number by 2.
            while (num % 2 == 0)
            {
                returnString.Append(", 2");
                num = num / 2;
            }

            // n must be odd at this point
            // so skip off 2 and iterate up
            for (int i = 3; i <= ((int)Math.Sqrt((double)num)) + 1; i++)
            {
                // while i divides num, add to string
                while (num % i == 0)
                {
                    returnString.Append($", {i}");
                    num = num / i;
                }
            }

            // if n is prime number greater than 2
            if( num > 2 )
            {
                returnString.Append($", {num}");
            } 

            return returnString.ToString(2, returnString.Length - 2);;
        }
    }
}
