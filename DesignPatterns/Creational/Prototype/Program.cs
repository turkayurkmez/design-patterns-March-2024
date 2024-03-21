// See https://aka.ms/new-console-template for more information


using Prototype;

Console.WriteLine("Hello, World!");

var vendors = new string[] { "Renault", "Toyota", "VolksWagen" };//5 saniye
var cloneOfVendors = (IEnumerable<string>)vendors.Clone();//0 saniye
foreach (var item in cloneOfVendors)
{
    Console.WriteLine(item);
}

Color black = new Color();
Console.WriteLine(black);
Color red = (Color)black.Clone();
red.R = 255;
red.G = 0;
red.B = 0;
Console.WriteLine(red);
Color green = (Color)black.Clone();
green.R = 0;
green.G = 255;
green.B = 0;
Console.WriteLine(green);


