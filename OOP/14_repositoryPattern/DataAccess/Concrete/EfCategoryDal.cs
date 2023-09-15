using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _14_repositoryPattern.DataAccess.Abstract;
using _14_repositoryPattern.Entity;

namespace _14_repositoryPattern.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}