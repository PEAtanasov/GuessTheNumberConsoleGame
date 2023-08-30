using System.Data;

Random random = new Random();

int minValue = 0;
int maxValue = 100;

int randomNumber = random.Next(minValue, maxValue);

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
    if (numberSugestion> randomNumber)
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
    if (i%2==0)
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

