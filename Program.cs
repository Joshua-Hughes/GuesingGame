using System;
using System.Collections.Generic;
using System.Linq;

//Correct Number to guess
string correctNumber = "42";

//Number of guesses the user gets
int tries = 4;

//Starting prompt
Console.WriteLine("Guess the secret number.");
Console.WriteLine("------------------------");

//Logic to handle user input
for (int i = 1; i <= tries; i++)
{

Console.Write(">");

string guess = Console.ReadLine();


    if (guess == correctNumber)
    {
        Console.Write("Congrats! You got it!");
        return;
    }
    else if (i < tries)
    {
        Console.WriteLine("Incorrect! Try Again!");
        
    }
    else
    {
        Console.Write("You failed!");
    }
}