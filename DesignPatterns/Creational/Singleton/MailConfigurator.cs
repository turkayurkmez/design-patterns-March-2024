using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public interface IMailConfigurator
    {
        string From { get; set; }
        string Host { get; set; }

        static string Subject { get; set; }
    }
    public class MailConfigurator : IMailConfigurator
    {
        public string From { get; set; }
        public string Host { get; set; }

        private MailConfigurator()
        {

        }

        private static MailConfigurator instance;
        public static MailConfigurator Create()
        {
            if (instance == null)
            {
                instance = new MailConfigurator();
            }

            return instance;
        }
    }

    //public sealed class Config : IMailConfigurator
    //{
    //    public static string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public static string Host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public static string Subject { get; set; }
    //}


    //public static class staticmailconfigurator : IMailConfigurator
    //{
    //    public static string from { get; set; }

    //    public static void send()
    //    {

    //    }
    //}
}
