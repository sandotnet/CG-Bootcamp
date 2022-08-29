using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingHttpClient.Models;
namespace HandsOnAPIUsingHttpClient.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int id);
        string Add(Product item);
        string Delete(int id);
        string Update(Product item);
    }
}
