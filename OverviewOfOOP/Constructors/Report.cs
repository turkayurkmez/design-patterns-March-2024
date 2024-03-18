using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{

    public enum ReportType
    {
        PDF,
        HTML,
        CustomFormat
    }
    public class Report
    {
        public string ExcelFilePath { get; set; }

        public ReportType ReportType { get; set; }

        public Report(string path)
        {
            ExcelFilePath = path;
            ReportType = ReportType.PDF;
        }


    }
}
