using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTect.TestTools.Console;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class IConsoleTests
    {
        [TestMethod]
        public void Test_Console_WriteLine()
        {
            string tempString = "Hello, how are you?";
            Program program = new Program();
            string view =
                @"<<Hello, how are you?
>>Hello, how are you?";
            ConsoleAssert.Expect(view, () => { program.WriteLine(tempString); });
        }
        [TestMethod]
        public void Test_Console_WriteLine_Blank()
        {
            string tempString = "";
            Program program = new Program();
            string view =
                @"<<
>>";
            ConsoleAssert.Expect(view, () => { program.WriteLine(tempString); });
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_Console_WriteLine_Null()
        {
            Program program = new Program();
            ConsoleAssert.Expect(null, () => { program.WriteLine(null); });
        }
        /*[TestMethod]
        public void Test_Console_ReadLine()
        {
            string tempString = "";
            Program program = new Program();
            string view =
                @"<<
>>";
            ConsoleAssert.Expect(view, () => { program.ReadLine(); });
        }*/
    }
}