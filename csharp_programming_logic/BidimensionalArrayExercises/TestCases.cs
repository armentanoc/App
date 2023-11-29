using LibFormatOutput;

namespace csharp_programming_logic.BidimensionalArrayExercises
{
    internal class TestCases
    {
        public static int[,] RealIdentityMatrix()
        {
            int[,] matrizIdentidade = {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            return matrizIdentidade;

        }

        public static int[,] MatrizAntiDiagonal()
        {
            int[,] matrizAntiDiagonal = {
                {0, 0, 1},
                {0, 1, 0},
                {1, 0, 0}
            };

            return matrizAntiDiagonal;

        }

        public static int[,] MatrizDiagonalNao1()
        {
            int[,] matrizDiagonalNao1 = {
                {1, 0, 0},
                {0, 2, 0},
                {0, 0, 1}
            };

            return matrizDiagonalNao1;
        }
        public static int[,] MatrizNaoDiagonalNao0()
        {
            int[,] matrizNaoDiagonalNao0 = {
                {1, 0, 0},
                {0, 1, 7},
                {0, 0, 1}
            };

            return matrizNaoDiagonalNao0;
        }
        
        public static int[,] MatrizNaoQuadrada()
        {
            int[,] matrizNaoQuadrada = {
                {1, 0},
                {0, 1},
                {0, 0}
            };

            return matrizNaoQuadrada;
        }

        public static void TestIdentity(int[,] matrix)
        {
            Print.BidimensionalArray(matrix);
            Console.WriteLine("\nÉ uma matriz identidade: " + Identity.CheckIdentityMatrix(matrix) + "\n");
        }
    }
}