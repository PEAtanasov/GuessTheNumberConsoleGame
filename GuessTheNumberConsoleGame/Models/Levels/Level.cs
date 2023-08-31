using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumberConsoleGame.Models.Levels.Interfaces;

namespace GuessTheNumberConsoleGame.Models.Levels
{

    abstract class Level : ILevel
    {
        public Level(int max)
        {
            MaxValue = max;
        }
        public int MaxValue { get; private set; }

        public string LevelInfo()
        {
            throw new NotImplementedException();
        }

        public void PlayTheLevel()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, MaxValue);

            Console.WriteLine($"Please enter number between 0 and {MaxValue}");
            int numberSugestion = int.Parse(Console.ReadLine());

            int tryCount = 1;

            while (randomNumber != numberSugestion)
            {
                if (numberSugestion > MaxValue || numberSugestion < 0)
                {
                    Console.WriteLine($"number must be between 0 and {MaxValue}");
                    Console.WriteLine("Please enter valid number");
                    numberSugestion = int.Parse(Console.ReadLine());

                    continue;
                }
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
                Console.WriteLine($"Congrats!!! You guesed the number on the {tryCount} try");
            }

        }
    }
}
