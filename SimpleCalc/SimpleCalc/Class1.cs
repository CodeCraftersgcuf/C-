using System;

namespace SimpleCalc
{
    public class Class1
    {
        public double Value { get; set; }

        // Default constructor
        public Class1() { }

        // Constructor to initialize the value
        public Class1(double value)
        {
            Value = value;
        }

        // Method overloading for Addition
        // Addition of two doubles
        public double Addition(double x, double y)
        {
            return x + y;
        }

        // Addition of two integers
        public int Addition(int x, int y)
        {
            return x + y;
        }

        // Addition of three doubles
        public double Addition(double x, double y, double z)
        {
            return x + y + z;
        }

        // Addition of a double and an integer
        public double Addition(double x, int y)
        {
            return x + y;
        }

        // Operator overloading for + (if you still need this)
        public static Class1 operator +(Class1 a, Class1 b)
        {
            return new Class1(a.Value + b.Value);
        }

        // Matrix addition using operator overloading
        public static double[,] operator +(double[,] matrixA, double[,] matrixB)
        {
            // Check if both matrices have the same dimensions
            if (matrixA.GetLength(0) != matrixB.GetLength(0) || matrixA.GetLength(1) != matrixB.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions for addition.");
            }

            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return result;
        }

        // Overriding ToString() to display value
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
