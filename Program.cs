using System;

namespace hello_console
{
     
    class Program
    {
         public struct DateRange
        {
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        
        }
        static void Main(string[] args)
        {
            DateTime start = new DateTime(2020, 12, 29);
            DateTime end = new DateTime(2021, 1, 3);
            DateTime [] holidays  = {new DateTime(2020, 12, 31), new DateTime(2021, 1, 1)};
            int count = CountWorkingDays(start, end, holidays);
            Console.WriteLine(count);
            DateRange range = new DateRange();
            range.Start = start;            
            range.End = end;
            count = CountWorkingDays(range, holidays);
            Console.WriteLine(count);
        }

        public static int CountWorkingDays (DateTime start, DateTime end, DateTime[] holidays)
        {
            int countWorkingDays = 0;
            while (start <= end){
               DateTime d = start.AddDays(1);
               //Console.WriteLine(start.AddDays(1));
                if(!Array.Exists(holidays, element => element == d) && d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday){
                    countWorkingDays++;
                }
                start = d;
            }
            return countWorkingDays;
        }

         public static int CountWorkingDays (DateRange range, DateTime[] holidays)
        {
            return CountWorkingDays(range.Start, range.End, holidays);
        }
    }
}
