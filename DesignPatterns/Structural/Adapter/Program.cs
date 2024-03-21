// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");

/*
 *  Bir kaynak (source) çıktı olarak XML verisi gönderiyor.
 *  Sizin uygulamanız ise (target) JSON ile çalışıyor.
 *  
 *  O halde XML'i JSON'a dönüştüren bir adaptör tasarlayın!
 */


CurrencyAdaptee currencyAdaptee = new CurrencyAdaptee();
XMLCurrencyProvider xml = new XMLCurrencyProvider();
JSONCurrencyProvider jSON = new JSONCurrencyProvider();
currencyAdaptee.GetCurrencies(xml).ForEach(c => Console.WriteLine(c.FromProvider));
currencyAdaptee.GetCurrencies(jSON).ForEach(c => Console.WriteLine(c.FromProvider));


