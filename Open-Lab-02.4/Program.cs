using System;

namespace Open_Lab_02._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much chickens do you have on your farm?");
            int chickens = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much cows do you have on your farm?");
            int cows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much pigs do you have on your farm?");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int legs = GetLegsCount(chickens, cows, pigs);

            Console.WriteLine($"There are {legs} legs on zour farm.");
        }
        private static int GetLegsCount(int chickens, int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4;
        }

    }
}
