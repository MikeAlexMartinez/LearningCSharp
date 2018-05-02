using System;
using System.Text;
using static System.Console;

namespace ex02
{
    class Program
    {
        static void Divisor()
        {
            string a;
            string b;
            decimal c;
            decimal d;
            byte max = 255;
            byte min = 0;

            Write("Enter a number between 0 and 255: ");
            a = ReadLine();
            if (decimal.TryParse(a, out c) && c < max && c > min)
            {
                Write("Enter another number between 0 and 255: ");
                b = ReadLine();
                if (decimal.TryParse(b, out d) && d < max && d > min)
                {
                    WriteLine($"{c} divided by {d} is {c / d}");
                }
                else
                {
                    WriteLine("FormatException: Input string was not in a correct format");
                }
            }
            else
            {
                WriteLine("FormatException: Input string was not in a correct format");
            }
        }
        
        static void FizzBuzz()
        {
            StringBuilder fizzbuzz = new StringBuilder("1");

            for (byte i = 2; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzz.Append(", FizzBuzz");
                } 
                else if (i % 5 == 0) 
                {
                    fizzbuzz.Append(", Buzz");
                }
                else if (i % 3 == 0)
                {
                    fizzbuzz.Append(", Fizz");
                }
                else
                {
                    fizzbuzz.Append($", {i}");
                }
            }

            WriteLine(fizzbuzz);
        }
        
        static void Main(string[] args)
        {
            int max = 500;
            // this code will cause i to overflow and
            // loop back round to 0;
            // therefore it never ends
            try
            {
                // checked block catches overflow
                checked
                {
                    for (byte i = 0; i < max; i++) {
                        WriteLine(i);
                    }
                }
            }
            catch (OverflowException)
            {
                WriteLine("byte incrementor overflowed.");
            }

            WriteLine();
            FizzBuzz();
            Divisor();
        }
    }
}
