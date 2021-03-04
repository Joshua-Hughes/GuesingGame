using System;
using System.Collections.Generic;
using System.Linq;

string correctNumber = "42";

int tries = 4;

Console.WriteLine("Guess the secret number.");
Console.WriteLine("------------------------");


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