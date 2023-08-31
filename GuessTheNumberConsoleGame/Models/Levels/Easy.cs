﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsoleGame.Models.Levels
{
    internal class Easy : Level
    {
        private const int maxValue = 10;

        public Easy() : base(maxValue)
        {
        }
    }
}
