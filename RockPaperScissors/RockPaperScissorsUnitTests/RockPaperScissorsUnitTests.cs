using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RockPaperScissors
{
    [TestClass]
    public class RockPaperScissorsUnitTests
    {
        ValueTuple<int, int> tempTuple = ValueTuple.Create(100, 100);

        [TestMethod]
        public void TestCalculateDamageRockRock()
        {
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "rock", "rock");
            Assert.AreEqual((100,100), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamageRockPaper()
        {
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "rock", "paper");
            Assert.AreEqual((90, 100), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamageRockScissors()
        {
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "rock", "scissors");
            Assert.AreEqual((100, 80), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamagePaperRock()
        {
            
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "paper", "rock");
            Assert.AreEqual((100, 90), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamagePaperPaper()
        {
            
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "paper", "paper");
            Assert.AreEqual((100, 100), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamagePaperScissors()
        {
            
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "paper", "scissors");
            Assert.AreEqual((85, 100), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamageScissorsRock()
        {
            
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "scissors", "rock");
            Assert.AreEqual((80, 100), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamageScissorsPaper()
        {
            
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "scissors", "paper");
            Assert.AreEqual((100, 85), testTuple);
        }
        [TestMethod]
        public void TestCalculateDamageScissorsScissors()
        {
            
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, "scissors", "scissors");
            Assert.AreEqual((100, 100), testTuple);
        }
        /*[TestMethod]
        public void TestWinnerFullHealth()
        {

            string expectedOutput = $@">>Please choose a move: 'rock', 'paper', or 'scissors': 
<<rock
>>You chose 'rock'";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expectedOutput, Program.DetermineWinner);
        }*/
    }
}
