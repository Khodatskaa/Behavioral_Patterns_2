using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class Stock
    {
        public string Symbol { get; }
        public double Price { get; private set; }

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }

        public void SetPrice(double newPrice)
        {
            Price = newPrice;
        }
    }
}
