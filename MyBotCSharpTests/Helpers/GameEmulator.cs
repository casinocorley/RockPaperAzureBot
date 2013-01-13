using System;
using RockPaperAzure;
using RockPaperScissorsPro;

namespace MyBotCSharpTests.Helpers
{
    internal class GameEmulator
    {
        public IRockPaperScissorsBot DetermineWinner(BotMove player1, BotMove player2)
        {
            var winningMove = DetermineWinningMove(player1.Move, player2.Move);

            if (winningMove == null)
                return null;

            return player1.Move == winningMove ? player1.Player : player2.Player;
            
        }

        private Move DetermineWinningMove(Move move1, Move move2)
        {
            if (move1 == move2)
                return null;

            if (
                (move1 == Moves.Rock && (move2 == Moves.Scissors || move2 == Moves.WaterBalloon)) ||
                (move1 == Moves.Paper && (move2 == Moves.Rock || move2 == Moves.WaterBalloon)) ||
                (move1 == Moves.Scissors && (move2 == Moves.Paper || move2 == Moves.WaterBalloon)) ||
                (move1 == Moves.Dynamite && move2 != Moves.WaterBalloon) ||
                (move1 == Moves.WaterBalloon && move2 == Moves.Dynamite)
            )
                    return move1;

            return move2;
        }

        public TestPlayer PlayMatch(TestPlayer player1, IRockPaperScissorsBot player1Bot, TestPlayer player2, IRockPaperScissorsBot player2Bot)
        {
            var rules = new StandardGameRules();

            InitializeTestPlayer(player1);
            InitializeTestPlayer(player2);

            var tiePoints = 0;
            var decisions = 0;
            var pointsToWin = rules.PointsToWin;

            while (
                player1.Points >= pointsToWin ||
                player2.Points >= pointsToWin ||
                decisions <= rules.MaximumGames)
            {
                var player1Move = player1Bot.MakeMove(player1, player2, null);
                var player2Move = player2Bot.MakeMove(player1, player2, null);

                var winnerBot = DetermineWinner(
                    new BotMove() { 
                        Player = player1Bot, 
                        Move = player1Move
                    },
                    new BotMove() {
                        Player = player2Bot,
                        Move = player2Move
                    });

                if (winnerBot == null)
                    tiePoints++;
                else
                {
                    TestPlayer winningPlayer = winnerBot == player1Bot ? player1 : player2;

                    winningPlayer.Points += 1 + tiePoints;
                    tiePoints = 0;
                }

                UpdatePlayerLastMove(player1, player1Move);
                UpdatePlayerLastMove(player2, player2Move);

                decisions++;
            }

            if (player1.Points == player2.Points)
                return null;
            else
                return player1.Points > player2.Points ? player1 : player2;
        }

        private void InitializeTestPlayer(TestPlayer player)
        {
            player.Points = 0;
        }

        private void UpdatePlayerLastMove(TestPlayer player, Move move)
        {
            player.LastMove = move;
        }
    }

    
}
