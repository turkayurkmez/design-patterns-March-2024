using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class CardType
    {
        public abstract double GetDiscountedPrice(double price);
    }

    public class StandartCard : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .95;
        }
    }

    public class SilverCard : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .90;
        }
    }

    public class GoldCard : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .85;
        }
    }

    public class PremiumCard : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .8;
        }
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
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:
            //        return price * 0.95;
            //    case CardType.Silver:
            //        return price * 0.90;
            //    case CardType.Gold:
            //        return price * 0.85;
            //    case CardType.Premium:
            //        return price * 0.8;
            //    default:
            //        return price;

            //}

            return Customer.Card.GetDiscountedPrice(price);
        }
    }
}
