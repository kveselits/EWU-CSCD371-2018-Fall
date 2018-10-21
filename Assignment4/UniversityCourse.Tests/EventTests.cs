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
        [TestMethod]
        public void Test_Display_Method_Event_Match()
        {
            Assert.AreEqual(Application.Display(testEvent), testEvent.GetSummaryInformation());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Display_Method_Event_Match_Null_Exception()
        {
            Assert.AreNotEqual(Application.Display(null), testEvent.GetSummaryInformation());
        }
        [TestMethod]
        public void Test_Instantiation_Count()
        {
            Assert.AreEqual(1, testEvent.InstantiationCount);
            Event testEvent2 = new Event("Blah", "Blah", DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(2, testEvent.InstantiationCount);
            Event testEvent3 = new Event("Blah2", "Blah2", DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(3, testEvent.InstantiationCount);
            Event testEvent4 = new Event("Blah3", "Blah3", DateTime.Now, DateTime.Now.AddDays(1));
            Assert.AreEqual(4, testEvent.InstantiationCount);
        }
    }
}