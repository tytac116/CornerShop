using System;
namespace CornerShop.Model.Entities
{
    public class ProductService : IProductService
    {
        public AppDataContext _context { get; set; }

        public ProductService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }

        public List<Product> GetAll()
        {
            return null;
        }

        public List<Product> GetByName(string prName)
        {
            return null;
        }

        public List<Product> Save(Product prProduct)
        {
            return null;
        }

        public List<Product> Update(Product prProduct)
        {
            return null;
        }

        public void Delete(Product prProduct)
        {

        }

    }
}

