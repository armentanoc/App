
using LibFormatOutput;
using LibUserInput;
using System.Linq.Expressions;

namespace csharp_programming_logic.ArrayExercises
{
    internal class DynamicArray
    {
        internal static void Execute()
        {
            int i = 0;
            float[] arrFloat = new float[i];

            Print.HorizontalLine();
            Console.WriteLine("\nARRAY DINÂMICO (DIGITE 0 PARA ENCERRAR)");

            while (true)
            {
                float number = Receive.FloatNumber();
                if (number == 0) break; 
                i++;
                arrFloat = ResizeArray(arrFloat, i);
                arrFloat[i - 1] = number;
            }

            showArrInformation(arrFloat);

        }

        static void showArrInformation(float[] arrFloat )
        {
            Print.HorizontalLine();
            Console.WriteLine("\nARRAY DINÂMICO:");
            Print.FloatArray(arrFloat);
            Console.WriteLine($"Números lidos: " + arrFloat.Length);
            Console.WriteLine($"\nSoma: " + arrFloat.Sum());
            Console.WriteLine($"\nQtd de pares: " + calculateEvenNumbers(arrFloat));
        }

        static int calculateEvenNumbers(float[] arr)
        {
            int evenNumbers = 0;
            foreach (float number in arr)
            {
                evenNumbers += (number % 2 == 0) ? 1 : 0;
            }
            return evenNumbers;
        }

        static float[] ResizeArray(float[] oldArray, int newSize)
        {
            float[] newArray = new float[newSize];
            Array.Copy(oldArray, newArray, Math.Min(oldArray.Length, newSize));
            return newArray;
        }
    }
}