using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsoleGame.Models.Levels.Interfaces
{

    abstract class Level : ILevel
    {
        private const int maxValue = int.MaxValue;
       // private const int minValue = 0;
        public Level(int max)
        {
            MaxValue = max;
        }
        public int MaxValue { get; private set; }

        public string LevelInfo()
        {
            throw new NotImplementedException();
        }

        public virtual void PlayTheLevel()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, MaxValue);

            int numberSugestion = int.Parse(Console.ReadLine());

            int tryCount = 1;

            /*string command = Console.ReadLine();

            while (command != "End")
            {

                if (command == "Start")
                {

                }
            }*/

            while (randomNumber != numberSugestion)
            {
                if (numberSugestion > randomNumber)
                {
                    Console.WriteLine($"{numberSugestion} is high! Try with lower number");
                }
                else if (numberSugestion < randomNumber)
                {
                    Console.WriteLine($"{numberSugestion} is low! Try with higher number");
                }
                tryCount++;

                numberSugestion = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            //Console.Beep();
            //Console.WriteLine($"Congrats!!! You guesed the number from the {tryCount} times");

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                Console.Beep();
                Console.WriteLine($"Congrats!!! You guesed the number from the {tryCount} times");
            }

        }
    }
}
