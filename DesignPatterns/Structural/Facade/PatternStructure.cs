using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantiy { get; set; }
    }

    public class Order
    {
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderService
    {
        public int CreateOrder(Customer customer, DateTime dateTime)
        {
            Console.WriteLine($"{customer.Name}, {dateTime.ToLongDateString()} tarihinde sipariş verdi");
            return 1;
        }


    }

    public class OrderDetailsService
    {
        public void CreateOrderItems(int orderId, List<OrderItem> orderItems)
        {
            Console.WriteLine($"{orderId} nuramalı siparişte satın alınan ürünler:");
            orderItems.ForEach(oi => Console.WriteLine($"{oi.ProductName} isimli üründen {oi.Quantiy} adet alındı"));
        }
    }

    public class OrderFacade //Facade sınıfının adında Facade olması elbette şart değil!
    {
        OrderService orderService = new OrderService();
        OrderDetailsService detailsService = new OrderDetailsService();

        public void CreateOrder(Customer customer, List<OrderItem> orderItems)
        {
            var orderId = orderService.CreateOrder(customer, DateTime.Now);
            detailsService.CreateOrderItems(orderId, orderItems);

        }
    }




}
