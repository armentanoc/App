

namespace LibFormatOutput
{
    public class Print
    {
        public static void IntArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
        }

        public static void FloatArray(float[] array)
        {
            foreach (float number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
        }

        public static void BidimensionalArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void HorizontalLine()
        {
            int lineWidth = Console.WindowWidth;
            char lineChar = '_';
            Console.WriteLine(new string(lineChar, lineWidth) + "\n");
        }

        public static void DictStrInt(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }

        public static void DictIntStr(Dictionary<int, string> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
