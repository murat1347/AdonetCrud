//using System;
//using System.Collections.Generic;

//namespace Generics
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Utilities  utilities = new Utilities();
//            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "İstanbul");
//        }
//    }

//    class Product
//    {

//    }

//    class Customer
//    {


//        interface IProductDal : IRepository<Product>
//        {


//        }
//        interface ICustomerDal : IRepository<Customer>
//        {
//            void Custom();

//        }

//        interface IRepository<T>
//        {
//            List<T> GetAll();
//            T Get(int id);
//            void Add(T entity);
//            void Delete(T customer);
//            void Update(T customer);
//        }

//        class ProductDal : ICustomerDal
//        {
//            public void Add(Customer entity)
//            {
//                throw new NotImplementedException();
//            }

//            public void Custom()
//            {
//                throw new NotImplementedException();
//            }

//            public void Delete(Customer customer)
//            {
//                throw new NotImplementedException();
//            }

//            public Customer Get(int id)
//            {
//                throw new NotImplementedException();
//            }

//            public List<Customer> GetAll()
//            {
//                throw new NotImplementedException();
//            }

//            public void Update(Customer customer)
//            {
//                throw new NotImplementedException();
//            }
//        }

//        class CustomerDal : ICustomerDal
//        {
//            public void Add(Customer entity)
//            {
//                throw new NotImplementedException();
//            }

//            public void Delete(Customer customer)
//            {
//                throw new NotImplementedException();
//            }

//            public Customer Get(int id)
//            {
//                throw new NotImplementedException();
//            }

//            public List<Customer> GetAll()
//            {
//                throw new NotImplementedException();
//            }

//            public void Update(Customer customer)
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }
//} 
