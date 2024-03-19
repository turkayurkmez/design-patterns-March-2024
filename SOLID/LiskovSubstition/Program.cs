// See https://aka.ms/new-console-template for more information
using LiskovSubstition;

Console.WriteLine("Hello, World!");
//Liskov yer değiştirme prensibi: A sınıfı, B sınıfından türemiş ise, B nesnesinin kullanıldığı her yerde (metot parametresi ya da dönüş değeri vs) A nesnesini de kullanabiliyor olmalısınız. Eğer A sınıfı B'nın DAVRANIŞINI değiştiriyorsa miras yanlıştır!

var rect = Geometry.GetRectangle(10, 4);


Console.WriteLine(rect.GetArea());