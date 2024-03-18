using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractANDInterface
{
    public abstract class Document
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public void Copy(string from, string to)
        {
            //yazıldığını düşünün 
        }

        public void Move(string from, string to)
        {
            //yazıldığını düşünün 

        }

        public abstract void Save(string path);
        public abstract void Open(string path);


    }

    public interface IPrintable
    {
        void Print();
    }

    public class ExcelDocument : Document, IPrintable
    {


        public override void Open(string path)
        {
            Console.WriteLine($"{GetType().Name} açıldı");
        }

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} çıktı alındı");
        }

        public override void Save(string path)
        {
            Console.WriteLine($"{GetType().Name} dosyası kaydedildi");

        }
    }

    public class PDFDocument : Document
    {
        public override void Open(string path)
        {
            Console.WriteLine($"{GetType().Name} dosyası açıldı");

        }



        public override void Save(string path)
        {
            Console.WriteLine($"{GetType().Name} dosyası kaydedildi");

        }
    }



    public class WordDocument : Document, IPrintable
    {
        public override void Open(string path)
        {
            Console.WriteLine($"{GetType().Name} dosyası açıldı");

        }

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} çıktı alındı");

        }

        public override void Save(string path)
        {
            Console.WriteLine($"{GetType().Name} dosyası kaydedildi");

        }
    }


    public class PrintComponent
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }

}
