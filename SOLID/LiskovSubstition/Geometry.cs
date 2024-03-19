using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstition
{
    public static class Geometry
    {
        public static IAreaCalcutable GetRectangle(int unit1, int? unit2 = null)
        {
            //bir sürü parametreyi değerlendirdikten sonra bu metodun sonu:
            if (unit2 == null)
            {
                return new Square { EdgeLength = unit1 };
            }
            return new Rectangle { Width = unit1, Height = unit2.Value };
        }
    }

    public interface IAreaCalcutable
    {
        public int GetArea();
    }
    public class Rectangle : IAreaCalcutable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int GetArea() => Width * Height;
    }

    public class Square : IAreaCalcutable
    {
        public int EdgeLength { get; set; }
        public int GetArea() => EdgeLength * EdgeLength;
    }
}
