namespace CornerShop.Model.Entities
{
    public interface IProductService
    {
        void Delete(Product prProduct);
        List<Product> GetAll();
        List<Product> GetByName(string prName);
        List<Product> Save(Product prProduct);
        List<Product> Update(Product prProduct);
    }
}