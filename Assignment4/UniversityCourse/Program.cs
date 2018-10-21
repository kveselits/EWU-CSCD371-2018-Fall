using System;
using System.Collections.Generic;

namespace UniversityCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Course newCourse = new Course("CSCD 371", "University Building", DateTime.Now, DateTime.UtcNow);
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.Add(new Event(DateTime.Now, DateTime.UtcNow));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.Add(new Event(DateTime.Now, DateTime.UtcNow));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.Add(new Event(DateTime.Now, DateTime.UtcNow));
            Console.WriteLine(newCourse.GetSummaryInformation());
        }
    }
}
