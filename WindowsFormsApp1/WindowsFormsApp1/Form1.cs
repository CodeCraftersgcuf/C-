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

        // Method for matrix addition
        public double[,] MatrixAddition(double[,] matrixA, double[,] matrixB)
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
    }
}
