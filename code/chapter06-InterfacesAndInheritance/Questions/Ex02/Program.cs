using System;
using static System.Console;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Let's play with some shapes");

            Shape s1 = new Shape(2M, 2M);
            WriteLine(s1.ToString());
            WriteLine(s1.Height);
            WriteLine(s1.Width);
            
            Square sq1 = new Square(3M, 3M);
            WriteLine(sq1.ToString());
            WriteLine(sq1.Height);
            WriteLine(sq1.Width);
            WriteLine(sq1.Area());
            
            Rectangle r = new Rectangle(4M, 4M);
            WriteLine(r.ToString());
            WriteLine(r.Height);
            WriteLine(r.Width);
            WriteLine(r.Area());

            Circle c = new Circle(3M);
            WriteLine(c.ToString());
            WriteLine(c.Height);
            WriteLine(c.Width);
            WriteLine(c.Area());
        }
    }
}
