using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMath
    {
        double Add(double x, double y);
    }

    public class Math : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

    }

    public class MathProxy : IMath
    {

        private Math math;
        public MathProxy(Math math)
        {
            this.math = math;
        }


        public double Add(double x, double y)
        {
            //1. Cache'e arma
            //2. Log tutma
            //3. Denetleme:

            if (x > 0 && y > 0)
            {
                return math.Add(x, y);
            }

            throw new ArgumentException("Değerler negatif olamaz!");

        }
    }
}
