// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
    }
}
