using System;
using System.Collections.Generic;
using System.Linq;

int correctNumber = new Random().Next(0, 999);

Console.WriteLine("Guess the secret number.");
Console.WriteLine("------------------------");

Console.WriteLine("Select a difficulty.");
Console.WriteLine(@"1. Easy, 2. Difficult, 3. Impossible, 4. Baby Time ");

int difficulty = Int32.Parse(Console.ReadLine());

Dictionary<int, int> difficultySelection = new Dictionary<int, int>() {
    {1, 10},
    {2, 5},
    {3, 1},
    {4, int.MaxValue}
};

int levelTries = difficultySelection[difficulty];
int counter = levelTries;

for (int i = 1; i <= counter; i++)
{

Console.Write($"Guess {i} out of {counter}:  ");

string guess = Console.ReadLine();
int guessInt;
Int32.TryParse(guess, out guessInt);

    if (guess == correctNumber.ToString())
    {
        Console.Write("Congrats! You got it!");
        return;
    }
    else if (i < counter)
    {
        if (guessInt > correctNumber)
        {
            Console.WriteLine("Incorrect! Your guess was too high!");
        }
        else if (guessInt < correctNumber)
        {
            Console.WriteLine("Incorrect! Your guess was too low!");
        }
        
    }
    else
    {
        Console.Write($"You failed! The correct number was {correctNumber}");
    }
}