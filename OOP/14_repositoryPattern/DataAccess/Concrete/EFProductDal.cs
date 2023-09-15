using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _14_repositoryPattern.DataAccess.Abstract;
using _14_repositoryPattern.Entity;

namespace _14_repositoryPattern.DataAccess.Concrete
{
    public class EFProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}