using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Red, Size.Small);
            var mango = new Product("Mango", Color.Green, Size.Medium);
            var watermelon = new Product("Watermelon", Color.Green, Size.Huge);

            var fruits = new List<Product> { apple, mango, watermelon };

            var filter = new FilterProductByColor();
            var result = filter.Filter(fruits, new FilterColor(Color.Green));
            foreach (var product in result)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
