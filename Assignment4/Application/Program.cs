using System;

namespace UniversityCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime[] array = new DateTime[7];
            Event newEvent = new Event("monday", "12");
            Console.WriteLine(newEvent.ToString());
        }
    }
}
