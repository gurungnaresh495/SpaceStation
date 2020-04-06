using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    public class SpaceStation : Subject
    {
        private int stationId { get; set; }

        private List<Product> products { get; set; }

        private List<Observer> dockedSpaceShips { get; set; }

        public int StationId
        {
            get { return this.stationId; }
            set { this.stationId = value; }
        }

        public List<Product> Products
        {
            get { return this.products; }
            set { this.products = value;
                notifyObservers();
            }
        }

        public List<Observer> DockedSpaceShips
        {
            get { return this.dockedSpaceShips; }
            set { this.dockedSpaceShips = value; }
        }

        public void notifyObservers()
        {
            foreach (var i in dockedSpaceShips)
            {
                i.updatePrice(products);
            }
        }

        public void RegisterObserver(Observer o)
        {
            this.dockedSpaceShips.Add(o);
            o.Location = this.stationId;
            notifyObservers();
        }

        public void UnregisterObserver(Observer o)
        {
            this.dockedSpaceShips.Remove(o);
            o.Location = -1;
        }
    }
}
