using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    public class Product
    {
        private int productId;
        private string productName;
        private double productPrice;

        //constructor
        public Product(int pId, string pName, double pPrice)
        {
            this.productId = pId;
            this.productName = pName;
            this.productPrice = pPrice;
        }

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public double ProductPrice
        {
            get { return this.productPrice; }
            set { this.productPrice = value; }
        }

        public override string ToString()
        {
            return "ProductId: " + this.productId + ", Name: " + this.productName +
                ", price: " + productPrice; 
        }
    }
}
