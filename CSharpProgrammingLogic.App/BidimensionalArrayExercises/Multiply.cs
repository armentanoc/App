namespace CSharpProgrammingLogic.App.BidimensionalArrayExercises
{

    using LibFormatOutput;
    using System;
    internal class Multiply
    {
        internal static void Execute()
        {
            PrintTitle();

            int[,] matrixA = {
            {1, 2},
            {3, 4}
        };

            int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

            Console.WriteLine("\nMatriz A:");
            Print.BidimensionalArray(matrixA);

            Console.WriteLine("\nMatriz B:");
            Print.BidimensionalArray(matrixB);

            int[,] result = MultiplyMatrices(matrixA, matrixB);

            if (result != null)
            {
                Console.WriteLine("\nMatriz C:");
                Print.BidimensionalArray(result);
            }
            else
            {
                Console.WriteLine("\nAs matrizes não são compatíveis para multiplicação.");
            }
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nMULTIPLICAÇÃO DE MATRIZES");
            Print.HorizontalLine();
        }

        static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            if (AreMatricesCompatible(matrixA, matrixB))
            {
                return StandardMatrixMultiply(matrixA, matrixB);
            }
            else
            {
                return null; // Matrizes não são compatíveis para multiplicação
            }
        }

        /*Se A é uma matriz de dimensões m × n (onde m é o número de linhas e n é o número de colunas) 
        * e B é uma matriz de dimensões p × q, então A e B podem ser multiplicadas se e somente se n = p.*/
        static bool AreMatricesCompatible(int[,] matrixA, int[,] matrixB)
        {
            return matrixA.GetLength(1) == matrixB.GetLength(0);
        }

        static int[,] StandardMatrixMultiply(int[,] matrixA, int[,] matrixB) // O(n^3)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);

            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return result;
        }
    }
}