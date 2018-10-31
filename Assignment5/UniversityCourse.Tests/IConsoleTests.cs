using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTect.TestTools.Console;

namespace UniversityCourse.Tests
{

    [TestClass]
    public class IConsoleTests
    {
        private RealConsole console { get; } = new RealConsole();

        [TestMethod]
        public void Test_Console_WriteLine()
        {
            string tempString = "Hello, how are you?";
            string view =
                @"<<Hello, how are you?
>>Hello, how are you?";
            ConsoleAssert.Expect(view, () => { console.WriteLine(tempString); });
        }
        [TestMethod]
        public void Test_Console_WriteLine_Blank()
        {
            string tempString = "";
            string view =
                @"<<
>>";
            ConsoleAssert.Expect(view, () => { console.WriteLine(tempString); });
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_Console_WriteLine_Null()
        {
            ConsoleAssert.Expect(null, () => { console.WriteLine(null); });
        }
        [TestMethod]
        public void Test_Console_ReadLine()
        {
            string testString = "Hello World.";
            Assert.AreEqual(testString, console.ReadLine());
        }
    }
}