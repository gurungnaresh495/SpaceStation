using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    public class SpaceShip : Observer
    {
        private int shipId;
        private int location;
        private List<Product> localPrices;

        //getter and setters
        public int ShipId 
        {
            get { return this.shipId; }
            set { this.shipId = value; }
        }

        public int Location 
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public List<Product> LocalPrices
        {
            get { return this.localPrices; }
            set { this.localPrices = value; }
        }

        public void updatePrice(List<Product> prodList)
        {
            localPrices = prodList;
            displayData();
        }

        public void displayData()
        {
            Console.WriteLine("\nShip Id:" + this.shipId);
            Console.WriteLine("Location:" + this.location);
            Console.WriteLine("\nThe products in the ship:\n-----------------------------");
            
            foreach (var i in localPrices)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
