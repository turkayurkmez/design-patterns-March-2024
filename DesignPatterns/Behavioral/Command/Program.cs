// See https://aka.ms/new-console-template for more information
using Command;

/*
 * Bir uygulamada, gerçekleşen bütün olaylar (geçmişte olan ve uygulamanın tepki vermesi gereken her şey. Örnek: Ürün fiyatı GÜNCELLENDİ), komutlar ile tetiklenir. 
 * 
 * Command bu komutları temsil eder. Yani uygulamada kullanılan her komutu bir arada değerlendirmek ve sistemin hakimiyet kurmasını sağlamak için bu pattern tercih edilir.
 */
Console.WriteLine("Hello, World!");

CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.Add(new CreateCustomerCommand());


DbCommandReceiver commandReceiver = new DbCommandReceiver();
commandInvoker.Add(new CreateOrderAndUpdateStockCommand(commandReceiver, "Türkay", "test"));
commandInvoker.ExecuteCommands();