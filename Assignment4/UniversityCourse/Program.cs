using System;

namespace UniversityCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Event newEvent = new Event("monday", "2");
            Console.WriteLine(newEvent.ScheduleDayOfWeek);
            Console.WriteLine(newEvent.ScheduleTimeOfDay);
            Event newEvent2 = new Event("tuesday", "4");
            Console.WriteLine(newEvent2.ScheduleDayOfWeek);
            Console.WriteLine(newEvent2.ScheduleTimeOfDay);
            Event newEvent3 = new Event("wednesday", "6");
            Console.WriteLine(newEvent3.ScheduleDayOfWeek);
            Console.WriteLine(newEvent3.ScheduleTimeOfDay);
            Event newEvent4 = new Event("thursday", "8");
            Console.WriteLine(newEvent4.ScheduleDayOfWeek);
            Console.WriteLine(newEvent4.ScheduleTimeOfDay);
            Event newEvent5 = new Event("friday", "10");
            Console.WriteLine(newEvent5.ScheduleDayOfWeek);
            Console.WriteLine(newEvent5.ScheduleTimeOfDay);
            Event newEvent6 = new Event("saturday", "12");
            Console.WriteLine(newEvent6.ScheduleDayOfWeek);
            Console.WriteLine(newEvent6.ScheduleTimeOfDay);
            Event newEvent7 = new Event("sunday", "14");
            Console.WriteLine(newEvent7.ScheduleDayOfWeek);
            Console.WriteLine(newEvent7.ScheduleTimeOfDay);
        }
    }
}
