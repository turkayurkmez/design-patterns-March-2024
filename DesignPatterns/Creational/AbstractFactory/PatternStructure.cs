using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    public interface IDbConnection
    {
        void Connect();
    }
    public class SQLConnection : IDbConnection
    {
        public void Connect()
        {
            Console.WriteLine("SQL'e bağlandım");
        }
    }

    public class OracleConnection : IDbConnection
    {
        public void Connect()
        {
            Console.WriteLine("Oracle'a bağlandım");

        }

    }

    public interface IDbCommand
    {
        void Execute();
    }
    public class SqlCommand : IDbCommand
    {
        public void Execute()
        {
            Console.WriteLine("SQL'den sorgu çektim");

        }
    }
    public class OracleCommand : IDbCommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle'den sorgu çektim");

        }
    }

    public interface IAbstractDataToolsFactory
    {
        public IDbConnection CreateConnection();
        public IDbCommand CreateCommand();
    }

    public class OracleDataToolsFactory : IAbstractDataToolsFactory
    {
        public IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }

    public class SqlDataToolsFactory : IAbstractDataToolsFactory
    {
        public IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public IDbConnection CreateConnection()
        {
            return new SQLConnection();
        }
    }

    public class DataTools<T> where T : IAbstractDataToolsFactory, new()
    {
        private T factory = new T();
        public void GetData()
        {
            var connection = factory.CreateConnection();
            var command = factory.CreateCommand();

            connection.Connect();
            command.Execute();
        }

    }
}
