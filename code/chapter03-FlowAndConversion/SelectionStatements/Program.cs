using System;
using System.IO;
using static System.Console;
using static System.Convert;

namespace SelectionStatements
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
            
            Split("for loop");
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least 1 argument.");
            }

            // Pattern matching
            Split("for loop pattern matching");
            object o = "3";
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply");
            }

            // switch statement with a label that can be jumped to
            
            Split("Switch");
            A_label:
                var number = (new Random()).Next(1, 7);
                WriteLine($"My Random number is {number}");
                switch (number) {
                    case 1:
                        WriteLine("One");
                        break; // jumps to end of switch
                    case 2:
                        WriteLine("Two");
                        goto case 1;
                    case 3:
                    case 4:
                        WriteLine("Three or Four");
                        goto case 1;
                    case 5:
                        // go to sleep for half a second
                        System.Threading.Thread.Sleep(500);
                        goto A_label;
                    default:
                        WriteLine("Default");
                        break;
                } // end of switch statement

            // Pattern matching with switch
            Split("switch pattern matching");
            string path = Directory.GetCurrentDirectory();
            WriteLine($"{path}");
            path = "/home/michael/Desktop/CSharp/LearningCSharp/code/chapter03-FlowAndConversion"; // Ubuntu
            Stream s = File.Open(
                Path.Combine(path, "newfile.txt"),
                FileMode.OpenOrCreate
            );

            switch(s)
            {
                case FileStream writableFile when s.CanWrite:
                    WriteLine("The stream is to a file that I can write to.");
                    break;
                case FileStream readOnlyFile:
                    WriteLine("The stream is to a read-only file");
                    break;
                case MemoryStream ms:
                    WriteLine("The stream is to a memory address");
                    break;
                default: // always evalutated last despite position
                    WriteLine("The stream is some other type.");
                    break;
                case null:
                    WriteLine("The stream is null.");
                    break;

            }

            // Iterations
            Split("Iterations");
            
            Split("while");
            // While
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            // do
            Split("do");
            string password = string.Empty;
            uint attempts = 0;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempts++;
            } while (password != "" && attempts < 10);

            if (attempts == 11)
            {
                WriteLine("Too many attempts");
            }
            else
            {
                WriteLine("Correct!");
            }

            // for
            
            Split("for");
            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            // foreach, uses IEnumerable interface
            Split("foreach()");
            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

            /* converts code to
            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext())
            {
                string name = (string)e.Current; // Current is read-only
                WriteLine($"{name} has {name.Length} characters.");
            }
            */

            // casting
            // implicit
            Split("casting");
            int a = 1;
            double b = a; // this is safe.

            //explicit (unsafe)
            double c = 9.8;
            int d = (int)c; // becomes 9.

            // assignment of out of bounds value to inappropriate type
            // results in value of -1
            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");

            // Using conversions from System.Convert

            Split("Conversions");
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            // Conversion to String
            
            Split("string conversions");
            int num = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            Split("Convert to Base64");
            // convert to Base64
            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Object as bytes:");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X}");
            }
            WriteLine();

            // convert to base64 string
            string encoded = Convert.ToBase64String(binaryObject);

            WriteLine($"Binary Object as Base64: {encoded}");
        }
    }
}
