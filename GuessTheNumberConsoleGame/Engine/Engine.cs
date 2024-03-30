using GuessTheNumberConsoleGame.Engine.Factories;
using GuessTheNumberConsoleGame.Models.Levels;
using GuessTheNumberConsoleGame.Models.Levels.Interfaces;

namespace GuessTheNumberConsoleGame.Engine
{
    internal class Engine : IEngine
    {
        private LevelFactory levelFactory;

        public Engine()
        {
            levelFactory = new LevelFactory();
        }
        public void Run()
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            Console.WriteLine("Please choose mode to play: \n\r Campaign or Quick Game");

            string iputMode = Console.ReadLine();

            if (iputMode == "Campaign")
            {
                List<ILevel> allLevels = new List<ILevel>();
                ILevel easy = new Easy();
                ILevel normal = new Normal();
                ILevel hard = new Hard();
                ILevel expert = new Expert();
                

                allLevels.Add(easy);
                allLevels.Add(normal);
                allLevels.Add(hard);
                allLevels.Add(expert);

                foreach (var level1 in allLevels)
                {
                    level1.PlayTheLevel();
                }

            }
            else if (iputMode == "Quick Game")
            {
                Console.WriteLine("Please choose the level dificulty you want to play:");
                Console.WriteLine("Easy, Normal, Hard or Expert");
                string desiredLevel = Console.ReadLine();

                ILevel level = levelFactory.CreateLevel(desiredLevel);

                level.PlayTheLevel();
            }    
        }
    }
}
