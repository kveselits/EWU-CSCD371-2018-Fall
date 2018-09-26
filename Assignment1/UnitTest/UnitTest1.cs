using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string myValue = "Kris Veselits";
            string expectedOutput = $@">>Hello, what is your name?
<<{myValue}
>>Hello {myValue}!";
            //@symbol expects multiple lines until semicolon. <<Veselits: this will be passed into your program.
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment1.UserInput.Main);
        }
    }
}
