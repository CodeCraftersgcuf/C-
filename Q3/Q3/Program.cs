using System;

namespace MouldStatueApp
{
    // Base class
    public class Mould
    {
        protected string color;    // Protected instance variable
        public int price;          // Public instance variable
        protected static int size; // Changed from private to protected

        public Mould(string color, int price)
        {
            this.color = color;    // Initialize the color
            this.price = price;    // Initialize the price
        }

        // Method to change the size
        public void SetSize(int newSize)
        {
            size = newSize; // Change the size
        }

        // Method to get the price (mark as virtual)
        public virtual int GetPrice()
        {
            return price;
        }

        // Method to read the color (mark as virtual)
        public virtual string ReadColor()
        {
            return color;
        }

        // Method to get the size
        public virtual int GetSize()
        {
            return size; // Now accessible since it's protected
        }
    }

    // Derived class
    public class Statue : Mould
    {
        public Statue(string color, int price) : base(color, price)
        {
        }

        // Overriding the method for getting the price
        public override int GetPrice()
        {
            return price + 100; // Adding a surcharge for statues
        }

        // Overriding the method for reading the color
        public override string ReadColor()
        {
            return $"Statue color is: {color}";
        }

        // Shadowing method for getting the size
        public new int GetSize()
        {
            return size; // Accessing the protected variable directly
        }

        // Shadowing method for setting size
        public new void SetSize(int newSize)
        {
            size = newSize; // Modify the protected variable
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
            Console.WriteLine($"Mould Color: {mould.ReadColor()}");
            Console.WriteLine($"Mould Price: {mould.GetPrice()}");
            Console.WriteLine($"Mould Size: {mould.GetSize()}");

            // Create a Statue object
            Statue statue = new Statue("Red", 300);
            statue.SetSize(100);
            Console.WriteLine($"Statue Color: {statue.ReadColor()}");
            Console.WriteLine($"Statue Price: {statue.GetPrice()}");
            Console.WriteLine($"Statue Size: {statue.GetSize()}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
