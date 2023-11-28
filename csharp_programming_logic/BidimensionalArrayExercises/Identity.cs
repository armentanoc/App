
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

            int[,] matrizDiagonalNão1 = {
                {1, 0, 0},
                {0, 2, 0},
                {0, 0, 1}
            };

            int[,] matrizNãoDiagonalNão0 = {
                {1, 0, 0},
                {0, 1, 7},
                {0, 0, 1}
            };

            Print.BidimensionalArray(matrizIdentidade);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizIdentidade) + "\n");

            Print.BidimensionalArray(matrizDiagonalNão1);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizDiagonalNão1) + "\n");

            Print.BidimensionalArray(matrizNãoDiagonalNão0);
            Console.WriteLine("\nÉ uma matriz identidade: " + CheckIdentityMatrix(matrizNãoDiagonalNão0) + "\n");
        }

        static bool CheckIdentityMatrix(int[,] matriz)
        {
            int rows = matriz.GetLength(0);
            int cols = matriz.GetLength(1);

            // Verifica se a matriz é quadrada
            if (rows != cols)
            {
                return false; // Já retorna falso e não analisa linhas e colunas
            }

            // Verifica se os elementos diagonais são iguais a 1 e os não diagonais são iguais a 0
            for (int i = 0; i < rows; i++)
            {
                if (matriz[i, i] != 1)
                {
                    return false; // Elemento diagonal não é 1
                }

                for (int j = 0; j < cols; j++)
                {
                    if (i != j && matriz[i, j] != 0)
                    {
                        return false; // Elemento não diagonal não é 0
                    }
                }
            }

            return true; // A matriz passou em todas as verificações
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nVERIFICAÇÃO DE MATRIZ IDENTIDADE");
            Print.HorizontalLine();
        }
    }
}
    
