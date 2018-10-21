using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Test_Add_New_Course()
        {
            Course newCourse = new Course("CSCD 371", "University Building", new Professor("Mark", "Michaelis"), DateTime.Now, DateTime.UtcNow);
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.Add(new Event(DateTime.Now, DateTime.UtcNow));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.Add(new Event(DateTime.Now, DateTime.UtcNow));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.Add(new Event(DateTime.Now, DateTime.UtcNow));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.AddPerson(new Person("John", "Doe"));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.AddPerson(new Person("Mark", "Francis"));
            Console.WriteLine(newCourse.GetSummaryInformation());
            newCourse.AddPerson(new Person("James", "Dean"));
        }
    }
}