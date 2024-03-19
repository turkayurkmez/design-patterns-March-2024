using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public enum CardType
    {
        Standard,
        Silver,
        Gold
    }
    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }
    }

    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public double GetTotalPrice(double price)
        {
            switch (Customer.Card)
            {
                case CardType.Standard:
                    return price * 0.95;
                case CardType.Silver:
                    return price * 0.90;
                case CardType.Gold:
                    return price * 0.85;
                default:
                    return price;

            }
        }
    }
}
