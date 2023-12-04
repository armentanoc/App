using LibFormatOutput;

namespace CSharpProgrammingLogic.App.DictionaryExercises
{
    internal class CountNumbers
    {
        internal static void Execute()
        {
            PrintTitle();

            int[] arrayDeInteiros = new int[] { 1, 1, 8, 8, 0, 5, 5, 5, 8, 3, 8, 3, 10 };

            Dictionary<int, int> occurrences = arrayDeInteiros
                .GroupBy(n => n) //O método GroupBy em LINQ é usado para agrupar elementos de uma sequência com base em uma chave comum
                .ToDictionary(g => g.Key, g => g.Count()); //

            Console.WriteLine("Array\n");
            foreach (int numero in arrayDeInteiros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine("\n\nNúmero de ocorrências\n");
            foreach (var entry in occurrences)
            {
                Console.WriteLine($"Chave {entry.Key} => Valor {entry.Value}");
            }
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nCONTAGEM DE NÚMEROS VIA DICIONÁRIO");
            Print.HorizontalLine();
        }
    }
}
