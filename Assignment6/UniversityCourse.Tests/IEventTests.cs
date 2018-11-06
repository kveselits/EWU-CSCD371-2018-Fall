using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTect.TestTools.Console;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class IEventTests
    {

        [TestMethod]
        public void Test_IEvent_Extension()
        {
            Event newEvent = new Event(DateTime.Today, DateTime.Now);
            string summaryUppercase = newEvent.ExtendSummaryInformation();
            string summaryUppercaseManual = newEvent.GetSummaryInformation().ToUpper();
            Assert.AreEqual(summaryUppercaseManual, summaryUppercase);
        }
    }
}