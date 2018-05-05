namespace Ex02
{
    public class Shape
    {
        public virtual decimal Height { get; set; }
        public virtual decimal Width { get; set; }

        public Shape(decimal height, decimal width)
        {
            Height = height;
            Width = width;
        }

        public virtual decimal Area ()
        {
            return Height * Width;
        }
    }
}