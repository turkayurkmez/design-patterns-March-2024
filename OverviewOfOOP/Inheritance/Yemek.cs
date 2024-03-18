using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public double Fiyat { get; set; }
        public List<string> Malzemeler { get; set; }
        public string Tarif { get; set; }

        public int PismeSuresi { get; set; }

        public void Pisir()
        {
            Console.WriteLine($" {GetType().Name} isimli yemek {PismeSuresi} dakikada  pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yanında pilavla birlikte servis edildi");
        }

    }

    public class Corba : Yemek
    {
        public bool LimonVarMi { get; set; }
    }

    public class DomatesCorbasi : Corba
    {
        public bool KasarliMi { get; set; }
        public override void SunumYap()
        {
            base.SunumYap();
            Console.WriteLine("Yanında kıtır ekmek ile....");
        }
    }

    public class SebzeYemegi : Yemek
    {
        public bool ZeytinYağli { get; set; }
    }

    public class Bezelye : SebzeYemegi
    {

    }

    public class Tatlı : Yemek
    {

    }

    public class Sekerpare : Tatlı
    {
        public override void SunumYap()
        {

            Console.WriteLine($" {GetType().Name} Yanında dondurma ile sunuldu!");
        }
    }



}
