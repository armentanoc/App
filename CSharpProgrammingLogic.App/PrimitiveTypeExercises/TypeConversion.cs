namespace CSharpProgrammingLogic.App.PrimitiveTypeExercises
{

    using LibUserInput;
    using LibFormatOutput;
    using System.Numerics;

    internal class TypeConversion
    {
        internal static void Execute()
        {
            PrintTitle();

            decimal inputNumber = Receive.Decimal();
            int intNumber;
            double doubleNumber;
            float floatNumber;

            if (int.TryParse(inputNumber.ToString(), out var intValue))
            {
                intNumber = intValue;
                Console.WriteLine($"Int: {intNumber}");
            }
            else
            {
                Console.WriteLine("Não foi possível converter em int.");
            }

            if (double.TryParse(inputNumber.ToString(), out var doubleValue))
            {
                doubleNumber = doubleValue;
                Console.WriteLine($"Double: {doubleNumber}");
            }
            else
            {
                Console.WriteLine("Não foi possível converter em double.");
            }

            if (float.TryParse(inputNumber.ToString(), out var floatValue))
            {
                floatNumber = floatValue;
                Console.WriteLine($"Float: {floatNumber}");
            }
            else
            {
                Console.WriteLine("Não foi possível converter em float.");
            }
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nCONVERSÃO DE TIPOS");
            Print.HorizontalLine();
        }
    }
}