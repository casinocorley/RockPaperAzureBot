using RockPaperScissorsPro;
using System;

namespace RockPaperAzure
{

    public class MyBot : IRockPaperScissorsBot
    {
        protected MoveTracker MyTracker { get; set; }
        protected MoveTracker OpponentTracker { get; set; }

        // Random sample implementation
        public Move MakeMove(IPlayer you, IPlayer opponent, GameRules rules)
        {
            var numberOfDecisions = you.NumberOfDecisions;

            if (numberOfDecisions <=1)
                return Moves.GetRandomMove();

            return Moves.GetRandomMove();
        }
    }

    public struct MoveTracker
    {
        public int RockThrow { get; set; }
        public int Paperhrow { get; set; }
        public int ScissorsThrow { get; set; }
    }

    

}
