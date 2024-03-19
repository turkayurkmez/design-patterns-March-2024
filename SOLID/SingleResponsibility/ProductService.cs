using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {


        public void CreateProduct(string name, decimal price)
        {
            //db'ye eklenen kodlar....
            //SendInfoMail("info@sales.com", $"Yeni ürün eklendi: {name}");
            MailSender mailSender = new MailSender();
            mailSender.SendInfoMail("info@sales.com", $"Yeni ürün eklendi: {name} ");
        }
    }
}
