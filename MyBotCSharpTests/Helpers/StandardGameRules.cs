using RockPaperScissorsPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBotCSharpTests.Helpers
{
    public class StandardGameRules 
    {
        public StandardGameRules() { }

        public int PointsToWin { get { return 1000; } }

        public int MaximumGames { get { return 5000; } }

        public int StartingDynamite { get { return 100; } }
    }
}
