using System;
using System.Globalization;

namespace Code_Challenge_Day_26_Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");

            DateTime returnedDate = Convert.ToDateTime(Console.ReadLine(),cultureInfo);
            DateTime expectedDate = Convert.ToDateTime(Console.ReadLine(),cultureInfo);

            if(returnedDate < expectedDate)
            {
                Console.WriteLine(0);
            }
            else if(returnedDate.Year > expectedDate.Year)
            {
                Console.WriteLine(10000);
            }

            else if(returnedDate.Month >expectedDate.Month)
            {
                Console.WriteLine(500 *(returnedDate.Month-expectedDate.Month));
            }

            else if(returnedDate.Day > expectedDate.Day)
            {
                Console.WriteLine(15 *(returnedDate.Day - expectedDate.Day));
            }
        }
    }
}
