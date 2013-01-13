using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperAzure;
using RockPaperScissorsPro;
using MyBotCSharpTests.Helpers;
using RockPaperAzure.TestBots;

namespace MyBotCSharpTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RandomBotShouldEvenlyDistributeThrowsTest()
        {
            // Arrange
            var randomBot = new RandomBot();
            var totalRockThrows = 0;
            var totalPaperThrows = 0;
            var totalScissorsThrows = 0;

            // Act
            for (int i = 0; i < 1000; i++)
            {
                var botMove = randomBot.MakeMove(null, null, null);
                if (botMove == Moves.Rock)
                    totalRockThrows++;
                else if (botMove == Moves.Paper)
                    totalPaperThrows++;
                else if (botMove == Moves.Scissors)
                    totalScissorsThrows++;
            }


            // Assert
            Assert.IsTrue(totalRockThrows / 10 >= 28,
                "Results: " +
                "Rock - " + totalRockThrows + " times. " +
                "Paper - " + totalPaperThrows + " times. " +
                "Scissors - " + totalScissorsThrows + " times.");
            Assert.IsTrue(totalRockThrows /10 <= 38,
                "Results: " +
                "Rock - " + totalRockThrows + " times." +
                "Paper - " + totalPaperThrows + " times." +
                "Scissors - " + totalScissorsThrows + " times.");

            Assert.IsTrue(totalPaperThrows / 10 >= 28,
                "Results: " +
                "Rock - " + totalRockThrows + " times. " +
                "Paper - " + totalPaperThrows + " times. " +
                "Scissors - " + totalScissorsThrows + " times.");
            Assert.IsTrue(totalPaperThrows / 10 <= 38,
                "Results: " +
                "Rock - " + totalRockThrows + " times. " +
                "Paper - " + totalPaperThrows + " times. " +
                "Scissors - " + totalScissorsThrows + " times.");

            Assert.IsTrue(totalScissorsThrows / 10 >= 28,
                "Results: " +
                "Rock - " + totalRockThrows + " times. " +
                "Paper - " + totalPaperThrows + " times. " +
                "Scissors - " + totalScissorsThrows + " times.");
            Assert.IsTrue(totalScissorsThrows / 10 <= 38,
                "Results: " +
                "Rock - " + totalRockThrows + " times. " +
                "Paper - " + totalPaperThrows + " times. " +
                "Scissors - " + totalScissorsThrows + " times.");
        }

        [TestMethod]
        public void MyBotShouldWinAgainstRandomBotTest()
        {
            // Arrange
            var me = new TestPlayer();
            var randomPlayer = new TestPlayer();

            var myBot = new MyBot();
            var randomBot = new RandomBot();

            // Act
            var winner = new GameEmulator().PlayMatch(me, myBot, randomPlayer, randomBot);

            // Assert
            Assert.AreSame(me, winner);
        }
    }
}
