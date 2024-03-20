using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IReportBuilder
    {
        void BuildHeader();
        void BuildContent();
        void BuildSign();
    }

    public class Report
    {
        //Raporu oluşturan header, content ve sign parçalarının her biri string bir değer:
        List<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void ShowReport()
        {
            parts.ForEach(part => Console.WriteLine(part));
        }



    }

    public class ReportBuilder : IReportBuilder
    {

        private Report report = new Report();
        public void BuildContent()
        {
            report.Add("Raporun içeriği oluşturuldu....");
        }

        public void BuildHeader()
        {
            report.Add("Başlık oluşturuldu");
        }

        public void BuildSign()
        {
            report.Add("İmzalar eklendi");

        }

        public Report Build()
        {
            BuildHeader();
            BuildContent();
            BuildSign();

            return report;
        }

    }


}
