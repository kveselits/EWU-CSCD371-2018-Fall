using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void TestAddition()
        {
           
            string operation = ("1 + 2");
  
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(operation, Assignment2.Program.Main);
        }
    }
}
