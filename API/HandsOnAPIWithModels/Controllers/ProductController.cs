using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIWithModels.Models;
using HandsOnAPIWithModels.Repositories;
using System.Collections.Generic;
namespace HandsOnAPIWithModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        [HttpGet,Route("GetAllProducts")]
        public List<Product> GetAll()
        {
            return _productRepository.GetAllProducts();
        }
        [HttpGet,Route("GetProductById/{id}")]
        public Product GetProduct(int id)
        {
            return _productRepository.GetProductById(id);
        }
        [HttpPost,Route("AddProduct")]
        public string AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return "Product Added";
        }
        [HttpPut,Route("EditProduct")]
        public string EditProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
            return "Product Edited";
        }
        [HttpDelete,Route("DeleteProduct/{id}")]
        public string DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return "Record is Deleted";
        }

    }
}
