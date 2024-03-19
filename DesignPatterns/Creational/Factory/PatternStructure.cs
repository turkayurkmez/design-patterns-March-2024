using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    //1. Fabrikanın üreteceği ürünü tasarla:
    public interface IVisitPoint
    {
        public string Name { get; set; }

    }
    public class Mosquee : IVisitPoint
    {
        public string Name { get; set; }
    }

    public class Museum : IVisitPoint
    {
        public string Name { get; set; }
    }

    public class Pub : IVisitPoint
    {
        public string Name { get; set; }
    }

    public abstract class MapBase
    {
        public List<IVisitPoint> VisitPoints { get; set; } = new List<IVisitPoint>();
        public MapBase()
        {
            //bellekte harita olabilmesi için ziyaret noktalarının da olması gerek
            getAndShowVisitPoints();
        }

        protected abstract void getAndShowVisitPoints();

    }

    public class CultureMap : MapBase
    {
        protected override void getAndShowVisitPoints()
        {
            VisitPoints.Add(new Museum() { Name = "Topkapı Müzesi" });
            VisitPoints.Add(new Museum() { Name = "Yerebatan Sarnıcı" });



        }
    }


    public class ReligionMap : MapBase
    {
        protected override void getAndShowVisitPoints()
        {
            VisitPoints.Add(new Museum() { Name = "Ayasofya" });
            VisitPoints.Add(new Museum() { Name = "Eyüp Sultan" });


        }
    }


}
