
namespace CSharpProgammingLogic.App.BidimensionalArrayExercises
{
    using LibFormatOutput;
    using System;

    internal class Identity
    {
        internal static void Execute()
        {

            PrintTitle();

            TestCases.TestIdentity(TestCases.RealIdentityMatrix());
            TestCases.TestIdentity(TestCases.MatrizAntiDiagonal());
            TestCases.TestIdentity(TestCases.MatrizDiagonalNao1());
            TestCases.TestIdentity(TestCases.MatrizNaoDiagonalNao0());
            TestCases.TestIdentity(TestCases.MatrizNaoQuadrada());
        }

        public static bool CheckIdentityMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                return false; // Já retorna falso e nao analisa linhas e colunas se a matriz nao for quadrada
            }

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, i] != 1)
                {
                    return false; // Elemento diagonal nao é 1
                }

                for (int j = 0; j < cols; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        return false; // Elemento nao diagonal nao é 0
                    }
                }
            }

            return true; 
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nVERIFICAÇÃO DE MATRIZ IDENTIDADE");
            Print.HorizontalLine();
        }
    }
}

/*
 Anti-Diagonal

 Console.WriteLine();

            int n = matrizAntiDiagonal.GetLength(0) - 1;

            for (int i = 0; i < n+1; i++)
            {
                int row = i;
                int col = n - i;
                Console.WriteLine($"({row}, {col}) => {matrizAntiDiagonal[row, col]}");
            }

 */