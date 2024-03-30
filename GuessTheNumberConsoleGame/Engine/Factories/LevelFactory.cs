using GuessTheNumberConsoleGame.Models.Levels;
using GuessTheNumberConsoleGame.Models.Levels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsoleGame.Engine.Factories
{
    public class LevelFactory
    {
        public ILevel CreateLevel(string LevelDificulty)
        {
            ILevel level;
            if (LevelDificulty=="Easy")
            {
                level = new Easy();
            }
            else if (LevelDificulty == "Normal")
            {
                level = new Normal();
            }
            else if (LevelDificulty == "Hard")
            {
                level = new Hard();
            }
            else if (LevelDificulty == "Expert")
            {
                level = new Expert();
            }
            else
            {
                level= new Expert();
            }

            return level;
        }
            
    }
}
