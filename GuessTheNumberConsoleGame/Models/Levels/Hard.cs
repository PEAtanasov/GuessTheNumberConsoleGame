using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsoleGame.Models.Levels
{
    internal class Hard : Level
    {
        private const int maxValue = 1000;

        public Hard() : base(maxValue)
        {

        }      
    }
}
