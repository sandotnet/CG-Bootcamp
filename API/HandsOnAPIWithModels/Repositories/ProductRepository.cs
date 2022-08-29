using HandsOnAPIWithModels.Models;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnAPIWithModels.Repositories
{
    public class ProductRepository:IProductRepository
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Mouse",Stock=10,Price=500},
            new Product(){ProductId=2,ProductName="Keyboard",Stock=10,Price=500}
        };

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            Product product= products.SingleOrDefault(p => p.ProductId == id);
            products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.SingleOrDefault(p => p.ProductId == id);
        }

        public void UpdateProduct(Product product)
        {
           for(int i=0;i<products.Count;i++)
            {
                if(products[i].ProductId == product.ProductId)
                {
                    products[i].Price = product.Price;
                    products[i].Stock = product.Stock;
                }
            }
        }
    }
}
