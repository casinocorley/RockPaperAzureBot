using RockPaperScissorsPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBotCSharpTests.Helpers
{
    public class BotMove
    {
        public IRockPaperScissorsBot Player { get; set; }

        public Move Move { get; set; }
    }
}
