// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");
/*
 * Bir nesnenin her değişen parçası karmaşık işlemler ile oluşmaktadır. Bu parçalar kendi içlerinde değişiyorsa; ayrı ayrı nesneler tarafından oluşturulup birleştirilmesi tercih edilebilir. 
 * 
 * Örnek:
 * 
 *    Büyük bir şirketin tüm rapor ihtiyaçlarını karşılaycak bir uygulama düşünün.
 *        - Rapor başlığı 
 *        - Rapor verisi
 *        - Rapor Grafikleri
 *        
 *        
 *   ReportBuilder reportBuilder = new ReportBuilder();
 *   var report =  reportBuilder.Build();
 *   
 *   
 *   
 *        
 */

ReportBuilder reportBuilder = new ReportBuilder();

var report = reportBuilder.Build();
report.ShowReport();
