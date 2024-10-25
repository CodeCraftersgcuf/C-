using System;

namespace MouldLibrary
{
    public class Mould
    {
        // Protected instance variable
        protected string color;

        // Public instance variable
        public int price;

        // Private instance variable for size
        private static int size;

        // Constructor to initialize the color and price
        public Mould(string color, int price)
        {
            this.color = color;
            this.price = price;
        }

        // Public method to set the size
        public void SetSize(int newSize)
        {
            size = newSize;
        }

        // Public method to get the price
        public virtual int GetPrice() // Made virtual for overriding
        {
            return price;
        }

        // Public method to read the color
        public virtual string ReadColor() // Made virtual for overriding
        {
            return color;
        }

        // Public method to get the size
        public static int GetSize()
        {
            return size;
        }

        // Method to show the size
        public string ShowSize()
        {
            return $"The current size is: {size}";
        }
    }
}
