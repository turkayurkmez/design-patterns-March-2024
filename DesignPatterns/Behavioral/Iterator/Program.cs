// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 *  Bir koleksiyon içerisinde çeşitli yönlere doğru dinamik olarak (programatik) ilerlemek istiyorsanız bu desen işinize yarar!
 */

Iterator<News> news = new Iterator<News>()
{
    new(){ Title ="Haber1"},
    new(){ Title ="Haber2"},
    new(){ Title ="Haber3"},

};

var second = news.Next();
Console.WriteLine(second.Title);
Console.WriteLine(news.First().Title);
