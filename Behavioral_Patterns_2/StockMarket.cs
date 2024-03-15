using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class StockMarket : IMarket
    {
        private List<IObserver> _observers = new List<IObserver>();
        private double _stockPrice;

        public double StockPrice
        {
            get { return _stockPrice; }
            set
            {
                _stockPrice = value;
                Notify(); 
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

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(StockPrice);
            }
        }
    }
}
