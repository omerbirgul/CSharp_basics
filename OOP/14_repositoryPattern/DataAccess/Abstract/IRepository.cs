using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_repositoryPattern.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);

        void Update(TEntity entity);


        void Create(TEntity entity);

        void Delete(int id);
    }
}