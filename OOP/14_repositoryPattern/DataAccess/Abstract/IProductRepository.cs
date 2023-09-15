using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _14_repositoryPattern.Entity;

namespace _14_repositoryPattern.DataAccess.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);

        void Update(Product entity);


        void Create(Product entity);

        public void Delete(int id);

        Product[] GetProductsByCategory(int id);
    }
}