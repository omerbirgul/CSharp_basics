using _14_repositoryPattern.DataAccess.Abstract;
using _14_repositoryPattern.DataAccess.Concrete;
using _14_repositoryPattern.Entity;

namespace _14_repositoryPattern;


class ProductManager : IProductRepository
{
    IProductRepository _repo;
    public ProductManager(IProductRepository repo)
    {
        _repo = repo;
    }
    public void Create(Product entity)
    {
        _repo.Create(entity);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Product[] GetPopulerProducts()
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

class Program
{
    static void Main(string[] args)
    {
       var productDal = new ProductManager(new EFProductDal());
       productDal.Create(new Product()); 
    }
}
