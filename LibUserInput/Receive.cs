
namespace LibUserInput
{
    public class Receive
    {

        public static int IntNumber()
        {
            int number;

            while (true)
            {
                Console.Write("\nInforme um número: ");
                if (int.TryParse(Console.ReadLine(), out number)) { break; }
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido (inteiro).");
            }

            return number;
        }

        public static float FloatNumber()
        {
            float number;

            while (true)
            {
                Console.Write("\nInforme um número: ");
                if (float.TryParse(Console.ReadLine(), out number)) { break; }
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido (float).");
            }

            return number;
        }
    }
}
