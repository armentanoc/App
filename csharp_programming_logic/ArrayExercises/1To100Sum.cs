using LibFormatOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming_logic.ArrayExercises
{
    internal class _1To100Sum
    {
        internal static void Execute()
        {
            int[] arr1To100 = ArrayIntegers.GenerateIntArray(1, 100);

            Console.WriteLine("\nArray de 1 a 100\n");
            Print.IntArray(arr1To100);
            Print.HorizontalLine();

            int sum = arr1To100.Sum();
            Console.WriteLine($"\nSoma de todos os valores: {sum}");
        }
    }
}
