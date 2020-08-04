using System;

namespace hello_console
{
    class Program
    {
        public struct DateRange
        {
            DateTime Start { get; set; }
            DateTime End { get; set; }
        
        }
        static void Main(string[] args)
        {
            DateTime [] holidays  = {new DateTime(2020, 12, 31), new DateTime(2021, 1, 1)};
            int count = CountWorkingDays(new DateTime(2020, 12, 29), new DateTime(2021, 1, 2), holidays);
            Console.WriteLine(count);
        }

        public static int CountWorkingDays (DateTime start, DateTime end, DateTime[] holidays)
        {
            int countWorkingDays = 0;
            while (start <= end){
               DateTime d = start.AddDays(1);
               //Console.WriteLine(start.AddDays(1));
                if(!Array.Exists(holidays, element => element == d)){
                    countWorkingDays++;
                }
                start = d;
            }
            return countWorkingDays;
        }

         public static int CountWorkingDays (DateRange range, DateTime[] holidays)
        {
            return 0;
        }
    }
}
