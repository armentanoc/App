using LibFormatOutput;

namespace CSharpProgammingLogic.App.ArrayExercises
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

/*

Obs.: Gauss sum would be more appropriate
 
 static void Execute()
    {
        int n = 100;
        int result = GaussSum(n);

        Console.WriteLine($"A soma dos {n} primeiros números naturais é: {result}");
    }

    static int GaussSum(int n)
    {
        return n * (n + 1) / 2;
    }
 
 */
