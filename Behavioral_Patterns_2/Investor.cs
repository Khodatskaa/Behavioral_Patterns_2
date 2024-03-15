using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public class Investor : IObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(double stockPrice)
        {
            Console.WriteLine($"Notification for {_name}: Stock price updated to {stockPrice}");
        }
    }
}
