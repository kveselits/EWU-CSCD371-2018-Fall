using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityCourse.Tests
{
    [TestClass]
    public class EventTests
    {
        public Event testEvent { get; set; }

        [TestInitialize]
        public void Test_Startup()
        {
            testEvent = new Event("Career Fair", "EWU", DateTime.Now, DateTime.Now.AddDays(1));
        }
        [TestMethod]
        public void Test_Check_EventName_Valid()
        {
            Assert.AreEqual("Career Fair", testEvent.Name);
        }

        [TestMethod]
        public void Test_Check_FullName_NotValid()
        {
            Assert.AreNotEqual("John Doe", testEvent.Name);
        }
        [TestMethod]
        public void Test_Check_EventLocation_Valid()
        {
            Assert.AreEqual("EWU", testEvent.Place);
        }
        [TestMethod]
        public void Test_Check_CourseName_NotValid()
        {
            Assert.AreNotEqual("Mars", testEvent.Place);
        }
        [TestMethod]
        public void Test_Check_Schedule_Valid()
        {
            Assert.AreEqual(DateTime.Now.DayOfWeek, testEvent.StartTime.DayOfWeek);
        }
        [TestMethod]
        public void Test_Check_Schedule_NotValid()
        {
            Assert.AreNotEqual(DateTime.Now.DayOfWeek, testEvent.EndTime.DayOfWeek);
        }
        [TestMethod]
        public void Test_GetSummaryInformation()
        {
            Assert.AreEqual($"Name of event: {testEvent.Name}{Environment.NewLine}" +
                            $"Location of event {testEvent.Place}{Environment.NewLine}" +
                            $"Start time: {testEvent.StartTime}{Environment.NewLine}" +
                            $"End time: {testEvent.EndTime}", 
                            testEvent.GetSummaryInformation());
        }

    }
}