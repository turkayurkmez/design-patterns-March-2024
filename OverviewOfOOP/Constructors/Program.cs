// See https://aka.ms/new-console-template for more information
using Constructors;

Console.WriteLine("Hello, World!");
Report report = new Report("C:\\test.xlsx");
report.ReportType = ReportType.HTML;
Console.WriteLine(report.ReportType);


//Report warning = new Report();