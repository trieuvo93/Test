using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Product
    {
        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }

        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
}
