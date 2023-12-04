using LibFormatOutput;
using LibUserInput;

namespace CSharpProgrammingLogic.App.ArrayExercises
{
    internal class ArrayFunctions
    {
        internal static void Execute()
        {
            writeExecuteMessage();
            float[] arrFloat = generateTenItemsArray();

            float mean = arrFloat.Average();
            Console.WriteLine($"Média: {mean}");

            float max = arrFloat.Max();
            Console.WriteLine($"\nMáximo: {max}");

            float min = arrFloat.Min();
            Console.WriteLine($"\nMínimo: {min}");

        }

        static void writeExecuteMessage()
        {
            Print.HorizontalLine();
            Console.WriteLine("\nFUNÇÕES EM VETORES\n");
            Console.WriteLine("Você deverá informar os 10 números que irão compor o vetor.");
        }

        static float[] generateTenItemsArray()
        {
            float[] arr = new float[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Receive.FloatNumber();
            }

            writeMessageTenItemsArray(arr);
            return arr;
        }

        static void writeMessageTenItemsArray(float[] arr)
        {
            Print.HorizontalLine();
            Console.WriteLine("\nARRAY GERADO\n");
            Print.FloatArray(arr);
        }

        public static void PrintFunctions(int[] arr)
        {
            Console.WriteLine("Alguns Métodos e Propriedades:");
            Console.WriteLine($".Length {arr.Length}");
            Console.WriteLine($".Average(x => x) {arr.Average(x => x).ToString()}");
            Console.WriteLine($".Count() {arr.Count()}");
            Console.WriteLine($".Any() {arr.Any()}");
            Console.WriteLine($".Max() {arr.Max()}");
            Console.WriteLine($".Min() {arr.Min()}");
            Console.WriteLine($".ToList() {arr.ToList()}\n");
        }
    }
}