using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class CourseTests
    {
        public Course TestCourse { get; set; }

        [TestInitialize]
        public void Test_Startup()
        {

            TestCourse = new Course("CSCD 371", "Computing and Engineering Building", new Professor("Mark", "Michaelis"), 
                DateTime.Now, DateTime.Now.AddDays(1));
        }
        [TestMethod]
        public void Test_Check_FullName_Valid()
        {
            Assert.AreEqual("Mark Michaelis", TestCourse.ProfessorName.Name);
        }

        [TestMethod]
        public void Test_Check_FullName_NotValid()
        {
            Assert.AreNotEqual("John Doe", TestCourse.ProfessorName.Name);
        }
        [TestMethod]
        public void Test_Check_CourseName_Valid()
        {
            Assert.AreEqual("CSCD 371", TestCourse.Name);
        }
        [TestMethod]
        public void Test_Check_CourseName_NotValid()
        {
            Assert.AreNotEqual("CSCD 9001", TestCourse.Name);
        }
        [TestMethod]
        public void Test_Check_Schedule_Valid()
        {
            foreach (Event scheduleItem in TestCourse.CourseSchedule)
            {
                Assert.AreEqual(DateTime.Now.DayOfWeek, scheduleItem.StartTime.DayOfWeek);
            }
        }
        [TestMethod]
        public void Test_Check_Schedule_NotValid()
        {
            foreach (Event scheduleItem in TestCourse.CourseSchedule)
            {
                Assert.AreNotEqual(DateTime.Now.DayOfWeek, scheduleItem.EndTime.DayOfWeek);
            }
        }
        [TestMethod]
        public void Test_Add_Student_Successs()
        {
            TestCourse.AddPerson(new Person("Dave", "White"));
            bool containsStudent = false;
            foreach (Person student in TestCourse.StudentRoster)
            {
                if (student.Name.Equals("Dave White"))
                {
                    containsStudent = true;
                }
            }
            Assert.IsTrue(containsStudent);
            //There's probably a better way to test this.
        }
        [TestMethod]
        public void Test_Add_Student_Failure()
        {
            TestCourse.AddPerson(new Person("John", "Doe"));
            bool containsStudent = false;
            foreach (Person student in TestCourse.StudentRoster)
            {
                if (student.Name.Equals("Dave White"))
                {
                    containsStudent = true;
                }
            }
            Assert.IsFalse(containsStudent);
            //There's probably a better way to test this.
        }
        [TestMethod]
        public void Test_GetSummaryInformation()
        {
            Assert.AreEqual($"Name of course: {TestCourse.Name}{Environment.NewLine}" +
                            $"Name of Professor: {TestCourse.ProfessorName.Name}{Environment.NewLine}" +
                            $"Location of course: {TestCourse.Place}{Environment.NewLine}" +
                            $"{Environment.NewLine}Course Schedule: {Environment.NewLine}" +
                            $"{TestCourse.StartTime.DayOfWeek}: {TestCourse.StartTime} - " +
                            $"{TestCourse.EndTime}{Environment.NewLine}",
                            TestCourse.GetSummaryInformation());
        }
        [TestMethod]
        public void Test_Display_Method_Course_Match()
        {
            Course testCourse2 = new Course("Fake Class 101", "Nowhere", new Professor("Michael", "Jordan"),
                DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(Application.Display(testCourse2), testCourse2.GetSummaryInformation());
        }
        [TestMethod]
        public void Test_Instantiation_Count()
        {
            Assert.AreEqual(1, TestCourse.InstantiationCount);
            Event testEvent2 = new Event("Blah3", "Blah3", DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(2, TestCourse.InstantiationCount);
            Event testEvent3 = new Event("Blah4", "Blah4", DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(3, TestCourse.InstantiationCount);
            Event testEvent4 = new Event("Blah5", "Blah5", DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(4, TestCourse.InstantiationCount);
        }
        [TestCleanup]
        public void clear()
        {
            TestCourse.InstantiationCount = 0;
        }
    }
}