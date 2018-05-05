using System;

namespace Ex02
{
    public class Circle : Shape
    {
        private decimal width;
        private decimal height;
        public override decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                height = value;
            }
        }
        public override decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                width = value;
                height = value;
            }
        }
        public Circle(decimal value) : base (value, value)
        {
            width = value;
            height = value;
        }

        public override decimal Area()
        {
            return ( (decimal)Math.PI * (decimal)(Math.Pow((double)( Width / 2 ), 2)) );
        }
    }
}