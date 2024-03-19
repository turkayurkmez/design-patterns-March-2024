using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class MailSender
    {
        public void SendInfoMail(string to, string message)
        {
            //mail gönderdiniz....
            MessageBox.Show(message);
        }
    }
}
