/*Exercício de Dicionário 3 - Analise os métodos dentro de um dicionário*/


using LibFormatOutput;

namespace CSharpProgammingLogic.App.DictionaryExercises
{
    internal class ExploringMethods
    {
        internal static void Execute()
        {
            PrintTitle();
            var dict = new Dictionary<int, string> { [1] = "Olá", [2] = "Mundo" };

            Console.WriteLine("\ndict.Remove(0);");
            dict.Remove(0);
            Print.DictIntStr(dict);

            Console.WriteLine("\ndict.Add(3, \"Novo\");");
            dict.Add(3, "Novo");
            Print.DictIntStr(dict);

            Console.WriteLine("\ndict.Add(3, \"Novo\");");

            bool wasItSuccesfull = dict.TryAdd(3, "Novo");
            Console.WriteLine($"dict.TryAdd(3, \"Novo\"); foi bem sucedido? {wasItSuccesfull}");

            wasItSuccesfull = dict.TryAdd(4, "Teste");
            Console.WriteLine($"dict.TryAdd(4, \"Teste\"); foi bem sucedido? {wasItSuccesfull}\n");

            Print.DictIntStr(dict);

            Console.WriteLine("\ndict.Clear();");
            dict.Clear();
            Print.DictIntStr(dict);
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nEXPLORANDO MÉTODOS");
            Print.HorizontalLine();
        }
    }
}