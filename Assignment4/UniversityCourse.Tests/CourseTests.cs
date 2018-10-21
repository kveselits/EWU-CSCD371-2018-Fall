using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class CourseTests
    {
        public Course testCourse { get; set; }

        [TestInitialize]
        public void Test_Startup()
        {

            testCourse = new Course("CSCD 371", "Computing and Engineering Building", new Professor("Mark", "Michaelis"), 
                DateTime.Now, DateTime.Now.AddDays(1));
        }
        [TestMethod]
        public void Test_Check_FullName_Valid()
        {
            Assert.AreEqual("Mark Michaelis", testCourse.ProfessorName.Name);
        }

        [TestMethod]
        public void Test_Check_FullName_NotValid()
        {
            Assert.AreNotEqual("John Doe", testCourse.ProfessorName.Name);
        }
        [TestMethod]
        public void Test_Check_CourseName_Valid()
        {
            Assert.AreEqual("CSCD 371", testCourse.Name);
        }
        [TestMethod]
        public void Test_Check_CourseName_NotValid()
        {
            Assert.AreNotEqual("CSCD 9001", testCourse.Name);
        }
        [TestMethod]
        public void Test_Check_Schedule_Valid()
        {
            foreach (Event scheduleItem in testCourse.CourseSchedule)
            {
                Assert.AreEqual(DateTime.Now.DayOfWeek, scheduleItem.StartTime.DayOfWeek);
            }
        }
        [TestMethod]
        public void Test_Check_Schedule_NotValid()
        {
            foreach (Event scheduleItem in testCourse.CourseSchedule)
            {
                Assert.AreNotEqual(DateTime.Now.DayOfWeek, scheduleItem.EndTime.DayOfWeek);
            }
        }
        [TestMethod]
        public void Test_Add_Student_Successs()
        {
            testCourse.AddPerson(new Person("Dave", "White"));
            bool containsStudent = false;
            foreach (Person student in testCourse.StudentRoster)
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
            testCourse.AddPerson(new Person("John", "Doe"));
            bool containsStudent = false;
            foreach (Person student in testCourse.StudentRoster)
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
            Assert.AreEqual($"Name of course: {testCourse.Name}{Environment.NewLine}" +
                            $"Name of Professor: {testCourse.ProfessorName.Name}{Environment.NewLine}" +
                            $"Location of course: {testCourse.Place}{Environment.NewLine}" +
                            $"{Environment.NewLine}Course Schedule: {Environment.NewLine}" +
                            $"{testCourse.StartTime.DayOfWeek}: {testCourse.StartTime} - " +
                            $"{testCourse.EndTime}{Environment.NewLine}",
                            testCourse.GetSummaryInformation());
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
            Assert.AreEqual(1, testCourse.InstantiationCount);
            Course testCourse1 = new Course("Blah3", "Blah3", new Professor("Michael", "Jordan"), DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(2, testCourse.InstantiationCount);
            Course testCourse2 = new Course("Blah4", "Blah4", new Professor("Michael", "Jordan"), DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(3, testCourse.InstantiationCount);
            Course testCourse3 = new Course("Blah5", "Blah5", new Professor("Michael", "Jordan"), DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(4, testCourse.InstantiationCount);
        }
        [TestCleanup]
        public void Test_Cleanup_Clear()
        {
            testCourse.InstantiationCount = 0;
        }
    }
}