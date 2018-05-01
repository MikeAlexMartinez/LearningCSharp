using System;
using System.Text;
using static System.Console;

namespace ex02
{
    class Program
    {
        static void Divisor()
        {
            Write("Enter a number between 0 and 255: ");
            string a = ReadLine();
            Write("Enter another number between 0 and 255: ");
            string b = ReadLine();
            int c;
            int d;
            decimal e;

            try
            {
                c = (int)a;
                d = (int)b;
                e = (decimal)(a / b);
            }
            catch (FormatException)
            {
                WriteLine("FormatException: Input string was not in a correct format");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()}: {ex.Message}");
            }

            WriteLine($"${c} divided by {d} is {e}");
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
                checked
                {
                    for (byte i = 0; i < 500; i++) {
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
        }
    }
}
