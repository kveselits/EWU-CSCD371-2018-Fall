using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class EnumerableTests
    {
        [TestMethod]
        public void Randomize_Returns_RandomizedList()
        {
            IEnumerable<string> inventorList = PatentDataAnalyzer.InventorNames();
            IEnumerable<string> randomizedList = inventorList.Randomize();
            Assert.IsFalse(inventorList.SequenceEqual(randomizedList));
        }
        [TestMethod]
        public void Randomize_Returns_RandomizedList_3Invocations()
        {
            IEnumerable<string> inventorList = PatentDataAnalyzer.InventorNames();
            for (int i = 0; i < 3; i++)
            {
                IEnumerable<string> randomizedList = inventorList.Randomize();
                Assert.IsFalse(randomizedList.SequenceEqual(inventorList));
            }
        }
    }
}