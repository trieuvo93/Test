using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Date
    {
        private static readonly List<int> DaysToMonth365 = new List<int>
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
        private static readonly List<int> DaysToMonth366 = new List<int>
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
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        private int _days => DateToTicks(Year, Month, Day);

        private static int DateToTicks(int year, int month, int day)
        {
            if (year >= 1 && year <= 9999 && (month >= 1 && month <= 12))
            {
                var numArray = DateTime.IsLeapYear(year) ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= numArray[month] - numArray[month - 1])
                {
                    int num = year - 1;
                    return (num * 365) + (num / 4) - (num / 100) + (num / 400) + numArray[month - 1] + day - 1;
                }
            }
            throw new ArgumentOutOfRangeException((string)null, "test");
        }

    }
}
