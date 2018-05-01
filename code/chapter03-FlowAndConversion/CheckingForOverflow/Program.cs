using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Split(string s) {
            WriteLine("");
            WriteLine(s);
            WriteLine("=============================");
        }

        static void Main(string[] args)
        {
            Split("Overflow not checked");
            int x = int.MaxValue - 1;
            WriteLine(x);
            x++;
            WriteLine(x);
            x++;
            WriteLine(x);
            x++;
            WriteLine(x);
            
            Split("Overflow with checked block");
            try
            {
                checked
                {
                    int y = int.MaxValue - 1;
                    WriteLine(y);
                    y++;
                    WriteLine(y);
                    y++;
                    WriteLine(y);
                    y++;
                    WriteLine(y);
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception");
            }

            Split("Overflow in unchecked statement");
            unchecked
            {
                int z = int.MaxValue + 1;
                WriteLine(z); // this will output -2147483648
                z--;
                WriteLine(z); // this will output 2147483647
                z--;
                WriteLine(z); // this will output 2147483646
            }

        }
    }
}
