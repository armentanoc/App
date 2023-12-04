using LibFormatOutput;
using LibUserInput;

namespace CSharpProgrammingLogic.App.ArrayExercises
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

            for (int var = start; var <= end; var++)
            {
                resultArray[var - start] = var;
            }

            return resultArray;
        }
    }
}