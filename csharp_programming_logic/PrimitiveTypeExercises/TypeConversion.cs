
namespace csharp_programming_logic.PrimitiveTypeExercises
{

    using LibUserInput;
    using LibFormatOutput;

    internal class TypeConversion
    {
        internal static void Execute()
        {
            PrintTitle();

            decimal inputNumber = Receive.Decimal();
            int intNumber = Convert.ToInt32(inputNumber);
            double doubleNumber = Convert.ToDouble(inputNumber);
            float floatNumber = Convert.ToSingle(inputNumber);

            Console.WriteLine($"\nDecimal: {inputNumber}");
            Console.WriteLine($"Int: {intNumber}");
            Console.WriteLine($"Double: {doubleNumber}");
            Console.WriteLine($"Float: {floatNumber}");
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\nCONVERSÃO DE TIPOS");
            Print.HorizontalLine();
        }
    }
}