using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsoleGame.Models.Levels.Interfaces
{
    public interface ILevel
    {
        public void PlayTheLevel();
        public string LevelInfo();
    }
}
