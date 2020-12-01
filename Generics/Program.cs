using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
        }             
    }
    class Urun
    {

    }
    interface IUrunDal:IRepository<Urun>
    {

    }
    class Customer
    {

    }
    interface ICustomerDal:IRepository<Customer>
    {
    }

    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int Id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class UrunDal : IUrunDal
    {
        public void Add(Urun entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Urun entity)
        {
            throw new NotImplementedException();
        }

        public Urun Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Urun> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Urun entity)
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

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int Id)
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
