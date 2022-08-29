using HandsOnAPIWithModels.Models;
using System.Collections.Generic;
namespace HandsOnAPIWithModels.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        void AddProduct(Product product);
    }
}
