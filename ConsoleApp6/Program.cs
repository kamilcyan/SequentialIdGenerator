using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            long temporary;
            char[] converted = new char[14];
            long ticks = DateTime.Now.Ticks;


            Console.Write(ticks.ToString());
            Console.Write("\n");

            // here we change number of ticks for alphanumerics
            for (int j = converted.Length - 3; j >= 0; j--)
            {
                temporary = ticks % 36;
                converted[j] = change(temporary);
                ticks = ticks / 36;
            }

            int addition = additions();

            // here we add 3 digit random number, change it for alphanumerics chars and add it at the end of our id number
            for (int i = converted.Length - 1; i>converted.Length-3; i--)
            {
                temporary = addition % 36;
                converted[i] = change(temporary);
                addition = addition / 36;
            }

            for (int i = 0; i < converted.Length; i++)
            {
                Console.Write(converted[i]);
            }

            Console.Read();
        }

        public static char change(long zn)
        {
            char znak;
            char[] chars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            znak = chars[zn];

            return znak;
        }

        public static int additions()
        {
            Random rand = new Random();
            int number = rand.Next(0, 999);

            return number;
        }
    }
}
