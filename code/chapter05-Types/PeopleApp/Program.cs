using System;
using Packt.CS7;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");

            var p2 = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 17)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:d MMM yy}");
        
            // without flags - one only
            p1.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientWonder}");

            // p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | 
            //    WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");

            // Add people to chlidren list
            p1.Children.Add(new Person("Alfred"));
            p1.Children.Add(new Person("Zoe"));
            WriteLine($"{p1.Name} has {p1.Children.Count} children:");
            for (int child = 0; child < p1.Children.Count; child++)
            {
                WriteLine($"    {p1.Children[child].Name}");
            }
        
            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} Interest.");
            var ba2 = new BankAccount {
                AccountName = "Ms. Gerrier",
                Balance = 98
            };
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} Interest.");
        
            WriteLine($"{p1.Name} is a {Person.Species}");

            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instantiated at {p4.Instantiated:hh:mm:ss} on {p4.Instantiated:dddd, d MMMM yyyy}");

            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            Tuple<string, int> fruit4 = p1.GetFruitCS4();
            WriteLine($"There are {fruit4.Item2} {fruit4.Item1}.");

            (string, int) fruit7 = p1.GetFruitCS7();
            WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are.");
            
            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}?");

            // Inferring tuple names
            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children");
            var thing2 = (p1.Name, p1.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children");

            // YOu can deconstruct Tuples
            (string fruitName, int fruitNumber) = p1.GetFruitCS7();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
            
            // say hello
            WriteLine(p1.SayHello());
            WriteLine(p1.SayHello("Emily"));

            // optional parameters
            WriteLine(p1.OptionalParameters());
            // pass parameters in order
            WriteLine(p1.OptionalParameters("Jump!", 98.5));
            // use named parameters to negate requirement for order
            WriteLine(p1.OptionalParameters(number: 52.7, command: "Hide!"));
            // skip paramters using named arguments
            WriteLine(p1.OptionalParameters(command: "Poke!", active: false));

            // passing parameters
            int a = 10;
            int b = 20;
            // value a is recreated in method and not returned.
            // reference to b is passed - which is why it can change
            // c is created in the method and so anything passed in is lost.
            WriteLine($"Before: a = {a}, b = {b}, c isn't created yet!");
            p1.PassingParameters(a, ref b, out int c);
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            
            // Using partial Person class
            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            // using getters and setters
            sam.FavouriteIceCream = "Chocolate Fudge";
            WriteLine($"Sam's favourite ice-cream flavour is {sam.FavouriteIceCream}.");
            sam.FavouritePrimaryColor = "Red";
            WriteLine($"Sam's favourite primary color is {sam.FavouritePrimaryColor}.");
            try
            {
                sam.FavouritePrimaryColor = "Yellow";
                WriteLine($"Sam's favourite primary color is {sam.FavouritePrimaryColor}.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}
