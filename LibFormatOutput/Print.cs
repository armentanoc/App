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
        public static void HorizontalLine()
        {
            int lineWidth = Console.WindowWidth;
            char lineChar = '_';
            Console.WriteLine(new string(lineChar, lineWidth) + "\n");
        }
    }
}
