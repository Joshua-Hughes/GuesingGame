using System;
using System.Collections.Generic;
using System.Linq;

string correctNumber = "42";

Console.WriteLine("Guess the secret number.");
Console.WriteLine("------------------------");
Console.Write(">");

string guess = Console.ReadLine();

if (guess == correctNumber)
{
    Console.WriteLine("You guessed correctly!");
}
else
{
    Console.WriteLine("Incorrect!");
};