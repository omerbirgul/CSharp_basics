using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_repositoryPattern.Entity
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}