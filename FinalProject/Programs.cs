using System;

namespace SkillCheck2
{
    class Functions
    {
        public static void print(string x)
        {
            Console.WriteLine(x);
        }

        public static string input(string x)
        {
            x = Console.ReadLine();

            return x;

        }
        public static int input(int y)
        {
            y = int.Parse(Console.ReadLine());

            return y;
        }
    }
}
