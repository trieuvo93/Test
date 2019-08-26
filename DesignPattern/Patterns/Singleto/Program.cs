using System;

namespace Singleto
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonSample s = SingletonSample.GetInstance();

            s.IncreaseNumber();
            Console.WriteLine(s.GetNumber());

            s = SingletonSample.GetInstance();

            s.IncreaseNumber();
            Console.WriteLine(s.GetNumber());
            Console.ReadLine();
        }
    }
}
