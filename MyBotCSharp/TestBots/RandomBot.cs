using RockPaperScissorsPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperAzure.TestBots
{
    public class RandomBot : IRockPaperScissorsBot
    {
        // Random sample implementation
        public Move MakeMove(IPlayer you, IPlayer opponent, GameRules rules)
        {
            return Moves.GetRandomMove();
        }
    }
}
