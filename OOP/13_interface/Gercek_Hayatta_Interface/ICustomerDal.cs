using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gercek_Hayatta_Interface
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            System.Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            System.Console.WriteLine("SQL Deleted");
        }

        public void Update()
        {
            System.Console.WriteLine("SQL Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            System.Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            System.Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            System.Console.WriteLine("Oracle Updated");;
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
             customerDal.Add();
        }
        public void Delete(ICustomerDal customerDal)
        {
             customerDal.Delete();
        }
        public void Update(ICustomerDal customerDal)
        {
             customerDal.Update();
        }
    }
}