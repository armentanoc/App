
using LibFormatOutput;

namespace csharp_programming_logic.ArrayExercises
{
    internal class ArraySum
    {
        internal static void Execute()
        {
            Console.WriteLine("\nSOMA DE VETORES");
            Print.HorizontalLine();

            Console.WriteLine("\n\nVETOR A");
            int[] arrayA = ArrayExercises.ArrayIntegers.Execute();
            Print.HorizontalLine();

            Console.WriteLine("\nVETOR B");
            int[] arrayB = ArrayExercises.ArrayIntegers.Execute();
            Print.HorizontalLine();

            ExecuteSum(arrayA, arrayB);
        }

        private static void ExecuteSum(int[] arrayA, int[] arrayB)
        {
            int maxLength = Math.Max(arrayA.Length, arrayB.Length);
            int[] arrayC = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                int valueA = (i < arrayA.Length) ? arrayA[i] : 0;
                int valueB = (i < arrayB.Length) ? arrayB[i] : 0;

                arrayC[i] = valueA + valueB;
            }

            Console.WriteLine("\nVETOR C (VETOR A + VETOR B)\n");
            Print.IntArray(arrayC);
        }
    }
}