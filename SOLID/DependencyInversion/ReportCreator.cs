using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{

    public interface ISender
    {
        void Send();
    }
    public class ReportCreator
    {

        private readonly ISender sender;

        public ReportCreator(ISender mailSender)
        {
            sender = mailSender;
        }

        //public MailSender Sender { get; set; }
        public void Notify()
        {
            //MailSender sender = new MailSender();
            sender.Send();
        }
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");

        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram ile gönderildi");

        }
    }
}
