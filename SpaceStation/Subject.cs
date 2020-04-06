using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void UnregisterObserver(Observer o);
        void notifyObservers();
    }

}
