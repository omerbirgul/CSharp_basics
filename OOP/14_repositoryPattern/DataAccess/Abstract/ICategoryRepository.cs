using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _14_repositoryPattern.Entity;

namespace _14_repositoryPattern.DataAccess.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
     Category[] GetCategories();   
    }
}