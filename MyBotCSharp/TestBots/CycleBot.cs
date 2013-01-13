using RockPaperScissorsPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperAzure.TestBots
{
    public class CycleBot : IRockPaperScissorsBot
    {
        public Move MakeMove(IPlayer you, IPlayer opponent, GameRules rules)
        {
            if (you.LastMove == Moves.Rock)
                return Moves.Paper;

            if (you.LastMove == Moves.Paper)
                return Moves.Scissors;

            if (you.LastMove == Moves.Scissors)
                if (you.HasDynamite)
                    return Moves.Dynamite;
                else
                    return Moves.WaterBalloon;

            if (you.LastMove == Moves.Dynamite)
                return Moves.WaterBalloon;

            return Moves.Rock;
        }
    }
}
