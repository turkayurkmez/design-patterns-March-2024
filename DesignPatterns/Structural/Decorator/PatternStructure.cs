using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IMail
    {
        void Send();
    }

    public class PromotionMail : IMail
    {
        public void Send()
        {
            Console.WriteLine("Yeni kampanyalar gönderildi");
        }
    }

    public class Newsletter : IMail
    {
        public void Send()
        {
            Console.WriteLine("Şirket haberleri gönderildi");
        }
    }


    public class SignedMail : IMail
    {
        private IMail mail;
        public SignedMail(IMail mail, string signedBy)
        {
            this.mail = mail;
            SignedBy = signedBy;
        }

        public string SignedBy { get; }


        public void Send()
        {
            if (!string.IsNullOrEmpty(SignedBy))
            {
                Console.WriteLine($"E-posta {SignedBy} tarafından imzalandı!");
            }
            mail.Send();
        }
    }

    public class CryptedEmail : IMail
    {
        private readonly IMail mail;

        public CryptedEmail(IMail mail)
        {
            this.mail = mail;
        }

        public void CryptoMailBody()
        {
            Console.WriteLine("Eposta metni şifrelendi!");
        }
        public void Send()
        {
            mail.Send();
        }
    }


}
