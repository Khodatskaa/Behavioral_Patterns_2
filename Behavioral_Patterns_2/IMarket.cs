using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_2
{
    public interface IMarket
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
