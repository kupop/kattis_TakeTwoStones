using System;

namespace kattis_TakeTwoStones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStones = Convert.ToInt32(Console.ReadLine());
            if (numberOfStones%2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}
