using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Space stations 
            SpaceStation aSpaceStation1 = new SpaceStation(101);
            SpaceStation aSpaceStation2 = new SpaceStation(102);
            SpaceStation aSpaceStation3 = new SpaceStation(103);
            SpaceStation aSpaceStation4 = new SpaceStation(104);
            SpaceStation aSpaceStation5 = new SpaceStation(105);
            SpaceStation aSpaceStation6 = new SpaceStation(106);
            SpaceStation aSpaceStation7 = new SpaceStation(107);
            SpaceStation aSpaceStation8 = new SpaceStation(108);
            SpaceStation aSpaceStation9 = new SpaceStation(109);
            SpaceStation aSpaceStation10 = new SpaceStation(110);

            List<SpaceStation> aListOfStations = new List<SpaceStation> { aSpaceStation1, aSpaceStation2,
                                aSpaceStation3, aSpaceStation4, aSpaceStation5, aSpaceStation6,
                                aSpaceStation7, aSpaceStation8, aSpaceStation9,aSpaceStation10};
            List<String> aListOfNames = new List<string> { "Space Stone" , "Reality Stone" , "Power Stone"
                                , "Mind Stone", "Time Stone" };
            //Space Ships
            SpaceShip aSpaceShip1 = new SpaceShip(1001 );
            SpaceShip aSpaceShip2 = new SpaceShip(1002);
            SpaceShip aSpaceShip3 = new SpaceShip(1003);
            SpaceShip aSpaceShip4 = new SpaceShip(1004);
            SpaceShip aSpaceShip5 = new SpaceShip(1005);

            List<SpaceShip> aListOfSpaceShips = new List<SpaceShip> { aSpaceShip1, aSpaceShip2,
                                    aSpaceShip3, aSpaceShip4, aSpaceShip5};

            

            //products in ships
            List<Product> aListOfProducts = new List<Product>();
            aListOfProducts.Add(new Product(1, "Space Stone", 0));
            aListOfProducts.Add(new Product(2, "Reality Stone", 1));
            aListOfProducts.Add(new Product(3, "Power Stone", 2));
            aListOfProducts.Add(new Product(4, "Mind Stone", 3));
            aListOfProducts.Add(new Product(5, "Time Stone", 4));

            //counter for id
            int idCounter = 6;
            //counter for price
            int pCounter = 11;
            
            foreach (var i in aListOfStations)
            {
                
   
                for (int j = 0; j <5; j++)
                {
                    i.Products.Add(new Product(idCounter, aListOfNames[j], pCounter));
                    pCounter++;
                    idCounter++;
                }
                pCounter += 6;
            }


            foreach (var i in aListOfSpaceShips)
            {


                for (int j = 0; j < 5; j++)
                {
                    i.LocalPrices.Add(new Product(idCounter, aListOfNames[j], 99999.99));
                    pCounter++;
                    idCounter++;
                }
            }


            aSpaceStation1.RegisterObserver(aSpaceShip1);
            aSpaceStation6.RegisterObserver(aSpaceShip5);
            Console.ReadKey();
        }
    }
}
