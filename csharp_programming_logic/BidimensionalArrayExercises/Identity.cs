
namespace csharp_programming_logic.BidimensionalArrayExercises
{
    using LibFormatOutput;
    internal class Identity
    {
        internal static void Execute()
        {

            PrintTitle();

            int[,] matrizIdentidade = {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            int[,] matrizAntiDiagonal = {
                {0, 0, 1},
                {0, 1, 0},
                {1, 0, 0}
            };

            int[,] matrizDiagonalNao1 = {
                {1, 0, 0},
                {0, 2, 0},
                {0, 0, 1}
            };

            int[,] matrizNaoDiagonalNao0 = {
                {1, 0, 0},
                {0, 1, 7},
                {0, 0, 1}
            };

            int[,] matrizNaoQuadrada = {
                {1, 0},
                {0, 1},
                {0, 0}
            };

            Print.BidimensionalArray(matrizIdentidade);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizIdentidade) + "\n");

            Print.BidimensionalArray(matrizAntiDiagonal);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizAntiDiagonal) + "\n");

            Print.BidimensionalArray(matrizDiagonalNao1);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizDiagonalNao1) + "\n");

            Print.BidimensionalArray(matrizNaoDiagonalNao0);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizNaoDiagonalNao0) + "\n");

            Print.BidimensionalArray(matrizNaoQuadrada);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizNaoQuadrada) + "\n");

        }

        static bool CheckIdentityMatrix(int[,] matriz)
        {
            int rows = matriz.GetLength(0);
            int cols = matriz.GetLength(1);

            if (rows != cols)
            {
                return false; // Já retorna falso e nao analisa linhas e colunas se a matriz nao for quadrada
            }

            for (int i = 0; i < rows; i++)
            {
                if (matriz[i, i] != 1)
                {
                    return false; // Elemento diagonal nao é 1
                }

                for (int j = 0; j < cols; j++)
                {
                    if (i != j && matriz[i, j] != 0)
                    {
                        return false; // Elemento nao diagonal nao é 0
                    }
                }
            }

            return true; 
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nVERIFICAÇaO DE MATRIZ IDENTIDADE");
            Print.HorizontalLine();
        }
    }
}
    
