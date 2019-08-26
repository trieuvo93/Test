using System;
using System.Collections.Generic;

namespace Solid1
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Red, Size.Small);
            var mango = new Product("Mango", Color.Green, Size.Medium);
            var watermelon = new Product("Watermelon", Color.Red, Size.Huge);

            var listProducts = new List<Product> { apple, mango, watermelon };

            var filter = new FilterByColor();

            var result = filter.Filter(listProducts, new FilterColor(Color.Red));

            foreach (var value in result)
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}
