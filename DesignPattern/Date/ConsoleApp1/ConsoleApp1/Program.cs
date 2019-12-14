using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly int[] DaysToMonth366 = new int[13]
        {
            0,
            31,
            60,
            91,
            121,
            152,
            182,
            213,
            244,
            274,
            305,
            335,
            366
        };

        private static readonly int[] DaysToMonth365 = new int[13]
        {
            0,
            31,
            59,
            90,
            120,
            151,
            181,
            212,
            243,
            273,
            304,
            334,
            365
        };

        static void Main(string[] args)
        {
            var s = DateToTicks(2018, 02, 13);
            Console.WriteLine("Test1");
        }

        private static long DateToTicks(int year, int month, int day)
        {
            if (year >= 1 && year <= 9999 && (month >= 1 && month <= 12))
            {
                int[] numArray = DateTime.IsLeapYear(year) ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= numArray[month] - numArray[month - 1])
                {
                    int num = year - 1;
                    return (long)(num * 365 + num / 4 - num / 100 + num / 400 + numArray[month - 1] + day - 1) * 864000000000L;
                }
            }
            throw new ArgumentOutOfRangeException((string)null, "test");
        }
    }
}
