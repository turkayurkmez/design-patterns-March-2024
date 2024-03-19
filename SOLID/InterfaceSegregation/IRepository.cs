using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRepository<T>
    {

        T Get(int id);
        void Create(T entity);


    }

    public interface ISearchable<TEntity>
    {
        IEnumerable<TEntity> Search(string name);
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateOnly OrderDate { get; set; }
    }


    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Search(string name)
        {
            return new List<Product>() { new Product { Id = 1 } };
        }
    }

    public class OrderRepository : IRepository<Order>
    {
        public void Create(Order entity)
        {

        }

        public Order Get(int id)
        {
            return new Order { Id = id };
        }


    }


    public class SearchableComponent<T>
    {
        public IEnumerable<T> Search(string name, ISearchable<T> searchable)
        {
            return searchable.Search(name);
        }
    }
}
