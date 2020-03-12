using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("WHAT");
            stock.Price = 222m;
            stock.PriceChanged += stock_PriceChanged;
            stock.Price = 333m;
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) > 0.1m)
            {
                Console.WriteLine("改变的比较大");
            }
        }
    }
}
