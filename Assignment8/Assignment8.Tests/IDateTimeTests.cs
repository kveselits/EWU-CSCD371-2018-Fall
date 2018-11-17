using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment8.Tests
{
    [TestClass]
    public class IDateTimeTests
    {
        [TestMethod]
        public void Create_IDateTimeInterface()
        {
            IDateTime dateInterface = new TimeManager.Time();
        }
    }
}
