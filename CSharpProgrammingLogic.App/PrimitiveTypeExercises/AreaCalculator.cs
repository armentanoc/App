using LibFormatOutput;
using LibUserInput;

namespace CSharpProgrammingLogic.App.PrimitiveTypeExercises
{
    internal class AreaCalculator
    {
        internal static void Execute()
        {
            PrintTitle();
            Console.WriteLine("Informe o raio do círculo");

            double PI = 3.1416F;
            double raio = Receive.FloatNumber();
            double area;

            try
            {
                area = PI * Math.Pow(raio, 2) / 2;
                Console.WriteLine($"A área do círculo é igual a {area}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }

        static void PrintTitle()
        {
            Console.WriteLine("\nÁREA DO CÍRCULO");
            Print.HorizontalLine();
        }
    }
}