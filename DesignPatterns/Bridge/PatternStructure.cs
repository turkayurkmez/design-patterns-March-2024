using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Report
    {
        //is a/has a
        public ReportFormat Format { get; set; }
    }

    public class SalesReport : Report
    {

    }

    public class PerformanceReport : Report
    {

    }

    public class ReportFormat
    {

    }

    public class PDFReportFormat : ReportFormat
    {

    }

    public class ExcelReportFormat : ReportFormat
    {

    }


    //public class ExcelSalesReport: SalesReport
    //{

    //}

    //public class PDFSalesReport: SalesReport
    //{

    //}

    //   public class ExcelPerformanceReport : PerformanceReport
    //   {

    //   }

    //   public class PDFPerformanceReport : PerformanceReport
    //   {

    //   }

}
