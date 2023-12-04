
using LibFormatOutput;

namespace CSharpProgammingLogic.App.BidimensionalArrayExercises
{
    internal class SumElements
    {
        internal static void Execute()
        {

            PrintTitle();

            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Print.BidimensionalArray(matrix);

            try
            {
                int sum = CalculateMatrixSum(matrix);
                Console.WriteLine($"\nA soma dos elementos da matriz é: {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nSOMA DE ELEMENTOS DA MATRIZ");
            Print.HorizontalLine();
        }
        static int CalculateMatrixSum(int[,] matrix)
        {
            ValidateMatrix(matrix);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        static void ValidateMatrix(int[,] matrix)
        {
            if (matrix is null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            {
                throw new ArgumentException($"{nameof(matrix)} deve ser uma matriz não nula com pelo menos uma linha e coluna.");
            }
        }
    }
}
