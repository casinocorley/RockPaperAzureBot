using RockPaperScissorsPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBotCSharpTests.Helpers
{
    internal class TestPlayer : IPlayer
    {

        public int DynamiteRemaining { get; set; }

        public bool HasDynamite { get; set; }

        public Move LastMove { get; set; }

        public IGameLog Log { get; set; }

        public int NumberOfDecisions { get; set; }

        public int Points { get; set; }

        public string TeamName { get; set; }

        public TimeSpan TotalTimeDeciding { get; set; }
    }
}
