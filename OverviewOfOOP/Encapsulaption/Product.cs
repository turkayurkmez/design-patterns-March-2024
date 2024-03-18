using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulaption
{
    public class Product
    {
        private double price;

        public void SetPrice(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }

            price = value;
        }

        public double GetPrice()
        {
            return price;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get; set; }

        public bool IsActive { get; private set; }

        public void ChangeStock(int newStock)
        {
            if (newStock < 5)
            {
                IsActive = false;
            }
        }

    }
}
