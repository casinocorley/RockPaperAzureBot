using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperAzure;
using RockPaperScissorsPro;
using MyBotCSharpTests.Helpers;
using RockPaperAzure.TestBots;

namespace MyBotCSharpTests.HelpersTests
{
    [TestClass]
    public class GameEmulatorTests
    {
        [TestMethod]
        public void RockBeatsScissorsTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Rock };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Scissors };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void PaperBeatsRockTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Paper };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Rock };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void ScissorsBeatsPaperTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Scissors };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Paper };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void DynamiteBeatsRockTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Dynamite };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Rock };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void DynamiteBeatsPaperTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Dynamite };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Paper };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void DynamiteBeatsScissorsTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Dynamite };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Scissors };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void WaterBalloonBeatsDynamiteTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.WaterBalloon };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Dynamite };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void RockBeatsWaterBalloonTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Rock };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.WaterBalloon };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void PaperBeatsWaterBalloonTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Paper };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.WaterBalloon };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void ScissorsBeatsWaterBalloonTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Scissors };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.WaterBalloon };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.AreSame(me, winner1);
            Assert.AreSame(me, winner2);
        }

        [TestMethod]
        public void RockTiesRockTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Rock };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Rock };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.IsNull(winner1);
            Assert.IsNull(winner2);
        }

        [TestMethod]
        public void PaperTiesPaperTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Paper };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Paper };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.IsNull(winner1);
            Assert.IsNull(winner2);
        }

        [TestMethod]
        public void ScissorsTiesScissorsTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Scissors };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Scissors };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.IsNull(winner1);
            Assert.IsNull(winner2);
        }

        [TestMethod]
        public void DynamiteTiesDynamiteTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.Dynamite };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.Dynamite };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.IsNull(winner1);
            Assert.IsNull(winner2);
        }

        [TestMethod]
        public void WaterBalloonTiesWaterBalloonTest()
        {
            // Arrange
            var me = new MyBot();
            var randomBot = new RandomBot();

            var myMove = new BotMove { Player = me, Move = Moves.WaterBalloon };
            var theirMove = new BotMove { Player = randomBot, Move = Moves.WaterBalloon };

            // Act
            var winner1 = new GameEmulator().DetermineWinner(myMove, theirMove);
            var winner2 = new GameEmulator().DetermineWinner(theirMove, myMove);

            // Assert
            Assert.IsNull(winner1);
            Assert.IsNull(winner2);
        }
    }
}
