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
            return _context.Products.ToList();
        }

        public List<Product> GetByName(string prName)
        {
            var linq = from Product in _context.Products select Product;

            if (!string.IsNullOrWhiteSpace(prName))
                linq = linq.Where(x => x.Name.ToUpper().Contains(prName.ToUpper()));
            return linq.ToList();
        }

        public List<Product> Save(Product prProduct)
        {
            _context.Products.Add(prProduct);
            _context.SaveChanges();
            return prProduct;
        }

        public List<Product> Update(Product prProduct)
        {
            Product IProductFromDB = _context.Products.First(x => x.Id == prProduct.Id);
            _context.Entry(IProductFromDB).CurrentValues.SetValues(prProduct);
            _context.SaveChanges();
            return prProduct;
        }

        public void Delete(Product prProduct)
        {
            _context.Entry(prProduct).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

    }
}

