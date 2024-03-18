// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

DomatesCorbasi domatesCorbasi = new DomatesCorbasi() { PismeSuresi = 20 };
Bezelye bezelye = new Bezelye() { PismeSuresi = 30 };

Sekerpare sekerpare = new Sekerpare() { PismeSuresi = 45 };

Asci asci = new Asci();

asci.Pisir(domatesCorbasi);
asci.Pisir(bezelye);
asci.Pisir(sekerpare);