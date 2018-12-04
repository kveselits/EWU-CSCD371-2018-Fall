using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class Assignment9Tests
    {
        [TestMethod]
        public void InventorNames_Returns_List_Specified_Country_Success()
        {
            List<String> inventorNames = PatentDataAnalyzer.InventorNames("UK");
            string expectedOutput = "George Stephenson";
            Assert.AreEqual(inventorNames.ElementAt(0), expectedOutput);

        }
        [TestMethod]
        public void InventorNames_Returns_List_Specified_Country_Failure()
        {
            List<String> inventorNames = PatentDataAnalyzer.InventorNames("USA");
            string expectedOutput = "George Stephenson";
            Assert.AreNotEqual(inventorNames.ElementAt(0), expectedOutput);

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void InventorNames_Null_Exception()
        {
            List<String> inventorNames = PatentDataAnalyzer.InventorNames(null);

        }

        [TestMethod]
        public void InventorLastNames_Returns_Different_Sequence()
        {
            List<String> inventorLastNames = PatentDataAnalyzer.InventorLastNames();
            List<String> inventorNames = PatentDataAnalyzer.InventorNames();
            bool equals = inventorLastNames.SequenceEqual(inventorNames);
            Assert.IsFalse(equals);
        }
        [TestMethod]
        public void LocationsWithInventor_Returns_String_Success()
        {
            string locationsWithInventors = PatentDataAnalyzer.LocationsWithInventors();
            string[] locationsAra = locationsWithInventors.Split(',');
            Assert.AreEqual("PA-USA", locationsAra.First());
            Assert.AreEqual("IL-USA", locationsAra.Last());
        }
    }
}
