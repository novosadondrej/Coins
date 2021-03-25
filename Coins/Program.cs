using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik peněz musíte zaplatit?: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kolika penězi platíte?: ");
            int cash = Convert.ToInt32(Console.ReadLine());
            int result = cash - price;

            int[] coins = { 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < coins.Length; i++)
            {
                int count = result / coins[i];
                if (count != 0)
                {
                    Console.WriteLine($"Vrátíme Vám {count}x {coins[i]}Kč");
                }
                result %= coins[i];
            }

        }

    }
}
