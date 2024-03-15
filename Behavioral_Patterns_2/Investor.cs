using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class Investor : IObserver
    {
        private readonly string _name;
        private readonly string _interestedSymbol;

        public Investor(string name, string interestedSymbol)
        {
            _name = name;
            _interestedSymbol = interestedSymbol;
        }

        public void Update(Stock stock)
        {
            if (stock.Symbol == _interestedSymbol)
            {
                Console.WriteLine($"Notification to {_name}: {stock.Symbol} price updated to {stock.Price}");
            }
        }
    }
}
