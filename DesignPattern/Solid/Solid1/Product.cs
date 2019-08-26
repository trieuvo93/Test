namespace Solid1
{
    public class Product: BaseObject
    {
        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }

        public string Name { get; set; }
        public Size Size { get; set; }

        public override string ToString()
        {
            return $"- {Name} - {Color} - {Size}";
        }
    }
}
