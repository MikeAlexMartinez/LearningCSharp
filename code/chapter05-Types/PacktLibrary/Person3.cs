using System;

namespace Packt.CS7
{
    public partial class Person // Chapter06 work
    {
        // methods to "multiply"
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // factorial function with local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // delegate example code
        public int MethodIWantToCall(string input)
        {
            return input.Length; // this is irrelevant
        }

        // event
        public event EventHandler Shout;

        // field
        public int AngerLevel;

        // method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening
                /*if (Shout != null)
                {
                    // ...then raise the event
                    Shout(this, EventArgs.Empty);
                }*/
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}