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
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCalculateDamageNull()
        {
            ValueTuple<int, int> testTuple = Program.CalculateHealth(tempTuple, null, "scissors");
        }
        [TestMethod]
        public void TestDetermineWinnerHumanWins()
        {
            ValueTuple<int, int> health = ValueTuple.Create(100, 0);
            string whoWins = Program.DetermineWinner(health);
            Assert.AreEqual($"You win! {health.ToString()}", whoWins);

        }
        [TestMethod]
        public void TestDetermineWinnerComputerWins()
        {
            ValueTuple<int, int> health = ValueTuple.Create(0, 100);
            string whoWins = Program.DetermineWinner(health);
            Assert.AreEqual($"Sorry, you lost. {health.ToString()}", whoWins);

        }
        [TestMethod]
        public void TestDetermineWinnerDraw()
        {
            ValueTuple<int, int> health = ValueTuple.Create(0, 0);
            string whoWins = Program.DetermineWinner(health);
            Assert.AreEqual($"It's a draw. {health.ToString()}", whoWins);

        }
        [TestMethod]
        public void TestDetermineWinnerNoWinner()
        {
            ValueTuple<int, int> health = ValueTuple.Create(15, 45);
            string whoWins = Program.DetermineWinner(health);
            Assert.AreEqual($"No winner yet. {health.ToString()}", whoWins);

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
