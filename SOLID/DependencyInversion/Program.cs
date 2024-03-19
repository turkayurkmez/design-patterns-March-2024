// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
//Küçük sistemler (bilgisayar) büyük sistemlere (elektrik) bağlı olmamalı!! Eğer böyle bir bağımlılık varsa bu bağımlılık TERSİNE ÇEVRİLMELİ 

MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();
ReportCreator reportCreator = new ReportCreator(telegramSender);
reportCreator.Notify();