using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PriceChangedEventArgs:EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice,decimal newPrice)
        {
            this.LastPrice = lastPrice;
            this.NewPrice = newPrice;
        }

    }
}
