using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { Name = "Mert" }, new Customer{ Name = "Ali" });
            foreach (var item in result2)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product : IEntity
    {
    }
    class Customer : IEntity
    {
        public string Name { get; set; }
    }
    class Student :IEntity
    {
    }
    interface IEntity
    {
    }
    interface IProductDal:IRepository<Product>
    {
    }
    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }
    interface IStudentDal : IRepository<Student>
    {
    }
    interface IRepository<T> where T : class, IEntity, new() //,struct değer tiplere karşılık gelir
        // T bir referans tip olmalı demektir,
        // IEntityden implement veya inherite edilmeli,
        // aynı zamanda newlenebilmeli(new en sona yazılmalı)
        // <...> Generic olmasını sağlar, genellikle T (Type) isimlendirmesi kullanılır
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
