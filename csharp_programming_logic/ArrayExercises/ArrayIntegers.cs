using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFormatOutput;
using LibUserInput;

namespace csharp_programming_logic.ArrayExercises
{
    public class ArrayIntegers
    {
        public static int[] Execute()
        {

            Console.WriteLine("\nARRAY DE INTEIROS\n\nVocê deverá informar o primeiro e o último números de um array sequencial de inteiros.");

            int start = Receive.IntNumber();
            int end = Receive.IntNumber();
            int[] numbersArray = GenerateIntArray(start, end);

            Console.WriteLine("\nArray de Inteiros:");
            Print.IntArray(numbersArray);

            return numbersArray;

        }

        public static int[] GenerateIntArray(int start, int end)
        {
            int[] resultArray = new int[end - start + 1];

            for (int i = start; i <= end; i++)
            {
                resultArray[i - start] = i;
            }

            return resultArray;
        }
    }
}