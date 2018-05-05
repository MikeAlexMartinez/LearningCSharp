using System;
using Packt.CS7;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Chapter05()
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

        static void Chapter06()
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // call instance method
            var baby1 = mary.ProcreateWith(harry);

            // call static method
            var baby2 = Person.Procreate(harry, jill);

            var baby3 = harry * mary;

            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{jill.Name} has {jill.Children.Count} children");
            WriteLine($"{mary.Name}'s first child is named \"{mary.Children[0].Name}\".");

            // factorial with local function
            WriteLine($"5! is {Person.Factorial(5)}");

            // Delegate example code
            var p1 = new Person("Delegate");
            
            // normal way
            int answer = p1.MethodIWantToCall(p1.Name);

            // assign defined delegate function to variable
            var d = new DelegateWithMatchingSignature(p1.MethodIWantToCall);
            int delegatedAnswer = d("Frog");
            WriteLine($"Delegated Answer: {delegatedAnswer}");

            // delegate example
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            // Demonstrating Interfaces
            Person[] people = 
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"}
            };

            WriteLine("Initial List of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            // Using Custom IComparer implementation
            WriteLine("Use PersonComparers IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            // not using generics - generates warning - comparison not valid
            var t = new Thing();
            t.Data = 42;
            WriteLine($"Thing: {t.Process("42")}");

            // using generics - define type in <brackets>
            var gt = new GenericThing<int>();
            gt.Data = 42;
            WriteLine($"GenericThing: {gt.Process("42")}");

            // using generic methods in non-generic class
            string number1 = "4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

            byte number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");

            // Using Structs
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            // Using Employee (inheriting from Person)
            Employee e1 = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };
            e1.WriteToConsole();

            e1.EmployeeCode = "JJ001";
            e1.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");

            // uses System.Object.ToString() until overriden.
            WriteLine(e1.ToString());

            // demonstrate difference between polymorphism and non-polymorphism
            // "<blank> new" = non-polymorhpic
            // "virtual override" = polymorphic
            Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode = "AA123" };
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            // doesn't use the WriteToConsole override
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            // still uses overriden method in Employee Class
            WriteLine(aliceInPerson.ToString());

            // checking class is type we expect it to be.
            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an employee");
                Employee e2 = (Employee)aliceInPerson;
                // do something with e2
            }

            // or, convert is possible, if unavailable as returns null
            Employee e3 = aliceInPerson as Employee;
            if (e3 != null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
            }

            // use custom exception
            try
            {
                e1.TimeTravel(new DateTime(1999, 12, 31));
                e1.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            // adding methods to string
            string email1 = "pamela@test.com";
            string email2 = "pamela&test.com";

            WriteLine($"{email1} is a valid e-mail address: {email2.IsValidEmail()}");
            WriteLine($"{email2} is a valid e-mail address: {email1.IsValidEmail()}");
        }

        private static void Harry_Shout(object sender, System.EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

        // define delegate
        delegate int DelegateWithMatchingSignature(string s);

        /* 
            Two predefined delgates from Microsoft 
            
            public delegate void EventHandler(object sender, EventArgs e);
            public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
        */

        static void Main(string[] args)
        {
            // Chapter05();
            Chapter06();
        }
    }
}
