// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");

//Açık/Kapalı Prensibi
//Bir nesne .....gelişime.... açık ......değişime.... kapalı olmalıdır.

Customer customer = new Customer { Name = "Türkay", Card = new PremiumCard() };
OrderManagement orderManagement = new OrderManagement { Customer = customer };

Console.WriteLine(orderManagement.GetTotalPrice(1000));