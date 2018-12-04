using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class PatentDataAnalyzerTests
    {
        [TestMethod]
        public void InventorNames_Returns_List_Specified_Country_Success()
        {
            List<string> inventorNames = PatentDataAnalyzer.InventorNames("UK");
            string expectedOutput = "George Stephenson";
            Assert.AreEqual(inventorNames.ElementAt(0), expectedOutput);

        }
        [TestMethod]
        public void InventorNames_Returns_List_Specified_Country_Failure()
        {
            List<string> inventorNames = PatentDataAnalyzer.InventorNames("USA");
            string expectedOutput = "George Stephenson";
            Assert.AreNotEqual(inventorNames.ElementAt(0), expectedOutput);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InventorNames_Null_Exception()
        {
            List<string> inventorNames = PatentDataAnalyzer.InventorNames(null);

        }

        [TestMethod]
        public void InventorLastNames_Returns_Different_Sequence()
        {
            List<string> inventorLastNames = PatentDataAnalyzer.InventorLastNames();
            List<string> inventorNames = PatentDataAnalyzer.InventorNames();
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
