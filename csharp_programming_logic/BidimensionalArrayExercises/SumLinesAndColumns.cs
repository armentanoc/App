
using LibFormatOutput;

namespace csharp_programming_logic.BidimensionalArrayExercises
{
    internal class SumLinesAndColumns
    {
        internal static void Execute()
        {
            PrintTitle();

            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Matriz Original:");
            Print.BidimensionalArray(matrix);

            Dictionary<string, int> rowSum = SumRows(matrix);
            Dictionary<string, int> columnSum = SumColumns(matrix);

            Console.WriteLine("\nSoma de cada linha:");
            Print.Dict(rowSum);

            Console.WriteLine("\nSoma de cada coluna:");
            Print.Dict(columnSum);
        }
        static Dictionary<string, int> SumRows(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            var rowSum = new Dictionary<string, int>();

            for (int i = 0; i < numRows; i++)
            {
                int sum = 0;
                for (int j = 0; j < numCols; j++)
                {
                    sum += matrix[i, j];
                }
                rowSum.Add($"L{i + 1}", sum);
            }

            return rowSum;
        }

        static Dictionary<string, int> SumColumns(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            var columnSum = new Dictionary<string, int>();

            for (int j = 0; j < numCols; j++)
            {
                int sum = 0;
                for (int i = 0; i < numRows; i++)
                {
                    sum += matrix[i, j];
                }
                columnSum.Add($"C{j + 1}", sum);
            }

            return columnSum;
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nSOMA DE LINHAS E COLUNAS DE UMA MATRIZ");
            Print.HorizontalLine();
        }
    }
}