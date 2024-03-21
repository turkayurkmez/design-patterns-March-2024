// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");
/*
 * Miras kaosu olarak bilinen (pek de sevilmeyen) bir durumla mücadele edebilmek için kullanılan bir pattern.
 * 
 */

SalesReport salesReport = new SalesReport { Format = new PDFReportFormat() };
SalesReport salesReport1 = new SalesReport { Format = new ExcelReportFormat() };
PerformanceReport report1 = new PerformanceReport { Format = new ExcelReportFormat() };
PerformanceReport report2 = new PerformanceReport { Format = new PDFReportFormat() };