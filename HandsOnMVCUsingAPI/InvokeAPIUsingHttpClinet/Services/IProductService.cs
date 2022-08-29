using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvokeAPIUsingHttpClinet.Services;
using InvokeAPIUsingHttpClinet.Models;
namespace InvokeAPIUsingHttpClinet.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Get(int Id);
        void Add(Product item);
        void Update(Product item);
        void Delete(int Id);
    }
}
