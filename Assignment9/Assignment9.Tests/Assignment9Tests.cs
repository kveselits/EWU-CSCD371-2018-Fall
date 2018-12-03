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
        public void InventorNames_Returns_List_Specified_Country()
        {
            List<String> inventorNames = PatentDataAnalyzer.InventorNames("UK");
            string expectedOutput = "George Stephenson";
            Assert.AreEqual(inventorNames.ElementAt(0), expectedOutput);

        }
    }
}
