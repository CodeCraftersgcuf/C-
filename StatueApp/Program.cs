using System;
using MouldLibrary;

namespace StatueApp
{
    public class Statue : Mould
    {
        // Constructor calling the base class constructor
        public Statue(string color, int price) : base(color, price)
        {
        }

        // Overriding the method to get the price
        public override int GetPrice()
        {
            return price + 50; // Adding extra charge for statues
        }

        // Overriding the method to get the color
        public override string ReadColor()
        {
            return $"Statue color is: {color}";
        }

        // Shadowing method for setting size
        public new void SetSize(int newSize)
        {
            base.SetSize(newSize); // Call the base class method to store the size
            Console.WriteLine($"Setting size for statue: {newSize}");
        }

        // Shadowing method to show the size
        public new string ShowSize()
        {
            return $"The size of the statue is: {GetSize()}";
        }
    }

    // Main method to test the classes
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Mould object
            Mould mould = new Mould("Blue", 200);
            mould.SetSize(50);

            // Set text color to Blue for Mould details
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Mould Color: {mould.ReadColor()}");
            Console.WriteLine($"Mould Price: {mould.GetPrice()}");
            Console.WriteLine($"Mould Size: {Mould.GetSize()}"); // Updated to access static size

            // Reset console color to default
            Console.ResetColor();

            // Create a Statue object
            Statue statue = new Statue("Red", 300);
            statue.SetSize(100);

            // Set text color to Red for Statue details
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Statue Color: {statue.ReadColor()}");
            Console.WriteLine($"Statue Price: {statue.GetPrice()}");
            Console.WriteLine(statue.ShowSize());

            // Reset console color to default
            Console.ResetColor();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
