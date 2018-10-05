using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            Random randomNum = new Random();
            var num1 = randomNum.Next(int.MinValue / 2, int.MaxValue / 2);
            var num2 = randomNum.Next(int.MinValue / 2, int.MaxValue / 2);
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}+{num2}
>>{num1 + num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestAddNegativeThenNegative()
        {
            int num1 = -10;
            int num2 = -5;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}+{num2}
>>{num1 + num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestAddPositiveThenNegative()
        {
            int num1 = 10;
            int num2 = -5;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}+{num2}
>>{num1 + num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestAddNegativeThenPositive()
        {
            int num1 = -10;
            int num2 = 5;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}+{num2}
>>{num1 + num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestSubtract()
        {
            Random randomNum = new Random();
            var num1 = randomNum.Next(int.MinValue / 2, int.MaxValue / 2);
            var num2 = randomNum.Next(int.MinValue / 2, int.MaxValue / 2);
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}-{num2}
>>{num1 - num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestSubtractZero()
        {
            int num1 = 1;
            int num2 = 0;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}-{num2}
>>{num1 - num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestSubtractNegativeThenNegative()
        {
            int num1 = -10;
            int num2 = -5;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}-{num2}
>>{num1 - num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestSubtractNegativeThenPositive()
        {
            int num1 = -10;
            int num2 = 5;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}-{num2}
>>{num1 - num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestSubtractPositiveThenNegative()
        {
            int num1 = 10;
            int num2 = -5;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}-{num2}
>>{num1 - num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestDivide()
        {
            int num1 = 10;
            int num2 = 2;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}/{num2}
>>{num1/num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestDivideByZero()
        {
            int num1 = 10;
            int num2 = 0;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}/{num2}
>>Error: division by zero not allowed.";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestDivideDecimal()
        {
            Random randomNum = new Random();
            decimal num1 = 10.5M;
            decimal num2 = 2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}/{num2}
>>{num1 / num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestDivideDecimalNegativeThenNegative()
        {
            Random randomNum = new Random();
            decimal num1 = -10.5M;
            decimal num2 = -2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}/{num2}
>>{num1 / num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestDivideDecimalNegativeThenPositive()
        {
            Random randomNum = new Random();
            decimal num1 = -10.5M;
            decimal num2 = 2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}/{num2}
>>{num1 / num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestDivideDecimalPositiveThenNegative()
        {
            Random randomNum = new Random();
            decimal num1 = 10.5M;
            decimal num2 = -2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}/{num2}
>>{num1 / num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestMultiply()
        {
            Random randomNum = new Random();
            int num1 = randomNum.Next(0, 100);
            int num2 = randomNum.Next(0, 100);
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}*{num2}
>>{num1*num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestMultiplyDecimal()
        {
            decimal num1 = 10.5M;
            decimal num2 = 2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}*{num2}
>>{num1 * num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestMultiplyDecimalNegativeThenNegative()
        {
            decimal num1 = -10.5M;
            decimal num2 = -2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}*{num2}
>>{num1 * num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestMultiplyDecimalNegativeThenPositive()
        {
            decimal num1 = -10.5M;
            decimal num2 = 2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}*{num2}
>>{num1 * num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
        [TestMethod]
        public void TestMultiplyDecimalPositiveThenNegative()
        {
            decimal num1 = 10.5M;
            decimal num2 = -2.5M;
            string expectedOutput = $@">>Please enter a mathematical operation: 
<<{num1}*{num2}
>>{num1 * num2}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Assignment2.Program.Main);
        }
    }
    [TestClass]
    public class StringUnitTests
    {
        [TestMethod]
        public void TestLength()
        {
            Assert.AreEqual(4, "Kris".Length);
            Assert.AreEqual(0, "".Length);
        }
        [TestMethod]
        public void TestContains()
        {
            string testString = "GetOffMyLawn";
            Assert.AreEqual(true, testString.Contains("Off") );
            Assert.AreEqual(false, testString.Contains("Dog"));
        }
        [TestMethod]
        public void TestSplit()
        {
            string expression = "Left side of string|Right side of string";
            string[] split = expression.Split("|");
            Assert.AreEqual("Left side of string", split[0]);
            Assert.AreEqual("Right side of string", split[1]);
        }
        [TestMethod]
        public void TestCopy()
        {
            string original = "one two three four";
            string copy = String.Copy(original);
            string falseCopy = String.Copy($"{original} ");
            Assert.AreEqual(original, copy);
            Assert.AreNotEqual(original, falseCopy);
        }
    }
}
