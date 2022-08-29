using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InvokeAPIUsingHttpClinet.Models;
using InvokeAPIUsingHttpClinet.Services;
namespace InvokeAPIUsingHttpClinet.Controllers
{
    public class ProductController : Controller
    {
        IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [Route("Product/GetAll")]
        public IActionResult Index() //Get All Products
        {
            
            return View(service.GetAll());
        }
        [Route("Details/{Id}")]
        public IActionResult Details(int Id)
        {
          
            return View(service.Get(Id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product item)
        {
            service.Add(item);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(service.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Product item)
        {
            service.Update(item);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
