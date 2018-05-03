namespace Packt.CS7
{
    public partial class Person
    {
        // property defined using C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => (int)(System.DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25);

        // using getters and setters
        public string FavouriteIceCream { get; set; } // auto syntax

        private string favouritePrimaryColor;
        public string FavouritePrimaryColor
        {
            get
            {
                return favouritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color. Please choose from: red, blue, green");
                }
            }
        }

        // Defining Indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }
        // overloaded indexer
        /*public Person this[string name]
        {
            get..
            set...
        }*/

        // indexers rarely add much value.
    }
}