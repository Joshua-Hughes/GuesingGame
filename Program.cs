using System;
using System.Collections.Generic;
using System.Linq;

//Correct Number to guess
int correctNumber = new Random().Next(0, 999);

//Number of guesses the user gets
int tries = 4;

//Starting prompt
Console.WriteLine("Guess the secret number.");
Console.WriteLine("------------------------");

//Logic to handle user input
for (int i = 1; i <= tries; i++)
{

Console.Write($"Guess {i} out of 4:  ");

string guess = Console.ReadLine();


    if (guess == correctNumber.ToString())
    {
        Console.Write("Congrats! You got it!");
        return;
    }
    else if (i < tries)
    {
        if (Int32.Parse(guess) > correctNumber)
        {
            Console.WriteLine("Incorrect! Your guess was too high!");
        }
        else if (Int32.Parse(guess) < correctNumber)
        {
            Console.WriteLine("Incorrect! Your guess was too low!");
        }
        
    }
    else
    {
        Console.Write($"You failed! The correct number was {correctNumber}");
    }
}