using RockPaperScissorsPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperAzure.TestBots
{
    public class BigBangBot : IRockPaperScissorsBot
    {
        // BigBang sample implementation
        public Move MakeMove(IPlayer you, IPlayer opponent, GameRules rules)
        {
            if (you.NumberOfDecisions < 5)
                return Moves.Dynamite;
            else
                return Moves.GetRandomMove();
        }
    }
}
