
using LibFormatOutput;
using LibUserInput;
using System.Numerics;

namespace csharp_programming_logic.PrimitiveTypeExercises
{
    internal class StringManipulation
    {

       /* 5 - Manipulação de Strings:
Solicite ao usuário para inserir seu nome completo.
Utilize variáveis de string para exibir o nome em maiúsculas, minúsculas e o comprimento da string.*/
        internal static void Execute()
        {
            PrintTitle();
            string name = Receive.Name();

            string lowercaseName = name.ToLower();
            string uppercaseName = name.ToUpper();
            int lengthName = name.Length;

            PrintNameInformation(name, lowercaseName, uppercaseName, lengthName);
        }

        private static void PrintNameInformation(string name, string lowercaseName, string uppercaseName, int lengthName)
        {
            Print.HorizontalLine();
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Minúsculo: {lowercaseName}");
            Console.WriteLine($"Maiúsculo: {uppercaseName}");
            Console.WriteLine($"Tamanho da String: {lengthName}");
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nMANIPULAÇÃO DE STRINGS");
            Print.HorizontalLine();
        }
    }
}