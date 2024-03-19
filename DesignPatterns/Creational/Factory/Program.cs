// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");

/*
 * Problem:
 *   Bir nesne düşünün. Bu nesne bellekte oluştuğu anda birkaç nesne ile birlikte oluşması gerekiyor. Nesne içinde nesne diyebileceğimiz bu ilişkiyi nasıl sağlarız?
 *   
 *   Senaryo:
 *   Bir mobil uygulama geliştirmektesiniz. Bu uygulama, turistler tarafından kullanılacak. Amacı, turistin gezmek istediği kategoriye göre (ibadet, kültür, eğlence) loasyonları işaretlemek.
 *   
 *   
 *   EglenceHaritasi map = new EglenceHaritasi();
 *   map.VisitPoints
 *   
 */

CultureMap cultureMap = new CultureMap();
cultureMap.VisitPoints.ForEach(vp => Console.WriteLine(vp.Name));