using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.CS7
{
    public partial class Person : Object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public List<Person> Children = new List<Person>();
        public WondersOfTheAncientWorld BucketList;
        public const string Species = "Homosapien";
        // readonly preferred to const
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person(string initialName = "Unknown")
        {
            // set default values for fields
            // including readonly fields
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        // the old C#4 and .NET 4.0 System.Tuple type
        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apples", 4);
        }

        // the new C# 7 syntax and new System.ValueTuple type 
        public (string, int) GetFruitCS7()
        {
            return ("Apples", 7);
        }

        // You can explicitly name tuples
        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        // Defining and passing parameters
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true
        ) {
            return $"command is {command}, number is {number}, active is {active}";
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out paramters cannot have a default
            // AND must be initialised inside the method.
            z = 99;

            // increment each parameter
            x++;
            y++;
            z++;
        }
    }
}
