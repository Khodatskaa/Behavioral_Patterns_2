using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class StockMarket : IMarket
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly Dictionary<string, Stock> _stocks = new Dictionary<string, Stock>();

        public void AddStock(Stock stock)
        {
            _stocks[stock.Symbol] = stock;
        }

        public void UpdateStockPrice(string symbol, double newPrice)
        {
            if (_stocks.ContainsKey(symbol))
            {
                _stocks[symbol].SetPrice(newPrice);
                Notify(_stocks[symbol]);
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Stock stock)
        {
            foreach (var observer in _observers)
            {
                observer.Update(stock);
            }
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
