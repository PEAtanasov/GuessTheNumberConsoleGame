using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsoleGame.Models.Levels
{
    internal class Expert : Level
    {
        private const int maxValue = 10000;

        public Expert() : base(maxValue)
        {
        }
    }

}
