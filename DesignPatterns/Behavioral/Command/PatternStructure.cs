using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class DbCommandReceiver
    {
        public void CreateNewOrder(string customer)
        {
            Console.WriteLine($"{customer}, yeni bir sipariş oluşturdu");
        }

        public void UpdateStock(string products)
        {
            Console.WriteLine("Ürünlerin stokları güncellendi!");
        }
    }

    public class CreateCustomerCommand : ICommand
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public void Execute()
        {
            Console.WriteLine("Db'de müşteri oluşturuldu!");
        }

    }

    public class CreateOrderAndUpdateStockCommand : ICommand
    {

        private DbCommandReceiver commandReceiver;
        private string customer;
        private string products;

        public CreateOrderAndUpdateStockCommand(DbCommandReceiver commandReceiver, string customer, string products)
        {
            this.commandReceiver = commandReceiver;
            this.customer = customer;
            this.products = products;
        }

        public void Execute()
        {
            commandReceiver.CreateNewOrder(customer);
            commandReceiver.UpdateStock(products);
        }
    }

    public class CommandInvoker
    {
        /*
         * Komut geçmişini izlemek, Bir komutun maaliyetini hesaplamak (benchmark) için....
         * 
         */
        private Queue<ICommand> commands = new Queue<ICommand>();
        public void Add(ICommand command) => commands.Enqueue(command);
        public void Clear() => commands.Clear();
        public void ExecuteCommands()
        {
            while (commands.Count > 0)
            {
                commands.Dequeue().Execute();
            }
        }
    }
}
