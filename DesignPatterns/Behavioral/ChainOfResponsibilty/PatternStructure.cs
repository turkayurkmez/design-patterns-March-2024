using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    public class Reservation
    {
        public string Owner { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public int ParticipantsCount { get; set; }
        public string City { get; set; }
    }

    /*
     * 1. Owner boş olamaz
     * 2. CheckIn tarihi, Out tarihinden küçük olmalı
     * 3. Eğer uygunsa db'ye kaydet
     */
    public abstract class Responsible
    {
        public Responsible Next { get; set; }

        public Responsible()
        {

        }

        public Responsible(Responsible next)
        {
            Next = next;
        }
        public abstract void Handler(Reservation reservation);
    }

    public class CheckOwnerResponsible : Responsible
    {
        public CheckOwnerResponsible()
        {

        }

        public CheckOwnerResponsible(Responsible next) : base(next)
        {

        }
        public override void Handler(Reservation reservation)
        {
            if (string.IsNullOrEmpty(reservation.Owner))
            {
                throw new ArgumentException("rezervasyon kimin adına?");
            }
            Next.Handler(reservation);
        }
    }

    public class CheckInAndOutDateResponsible : Responsible
    {
        public CheckInAndOutDateResponsible()
        {

        }

        public CheckInAndOutDateResponsible(Responsible responsible) : base(responsible)
        {

        }
        public override void Handler(Reservation reservation)
        {
            if (reservation.CheckIn > reservation.CheckOut)
            {
                throw new ArgumentException("tarihler hatalı");
            }
            //Burada yapılması gereken işleri yap...
            Next.Handler(reservation);
        }
    }

    public class CompleteAndSaveToDatabaseResponsible : Responsible
    {
        public CompleteAndSaveToDatabaseResponsible()
        {
        }

        public CompleteAndSaveToDatabaseResponsible(Responsible next) : base(next)
        {
        }

        public override void Handler(Reservation reservation)
        {
            Console.WriteLine($"{reservation.Owner} tarafından talep edilen {reservation.CheckIn.ToLongDateString()} girişli rezervasyonunuz kaydedilmiştir.");
        }
    }
}
