// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
/*
 * Façade:
 *   Karmaşık (ve karışık) işlemleri istemciden uzaklaştırtmak yani karmaşayı arka tarafa itmek için kullanılan pattern 
 */

OrderFacade orderFacade = new OrderFacade();


Customer customer = new Customer() { Name = "Türkay" };
OrderItem item1 = new OrderItem { ProductName = "MateBook", Quantiy = 1 };
OrderItem item2 = new OrderItem { ProductName = "Keyboard", Quantiy = 1 };

var items = new List<OrderItem> { item1, item2 };

orderFacade.CreateOrder(customer, items);