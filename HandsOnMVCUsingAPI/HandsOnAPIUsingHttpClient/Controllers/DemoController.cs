using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingHttpClient.Models;
using HandsOnAPIUsingHttpClient.Services;
namespace HandsOnAPIUsingHttpClient.Controllers
{
    public class DemoController : Controller
    {
        private ProductService _service;
        public DemoController()
        {
            _service = new ProductService();
        }
        public IActionResult Index()
        {
            try
            {
                List<Product> list = _service.GetAll();
                return View(list);
            }
            catch(Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel() { Message = ex.Message };
                return View("Error",error);
            }
        }
        public IActionResult Details(int id)
        {
            try
            {
                Product item = _service.Get(id);
                return View(item);
            }
            catch (Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel() { Message = ex.Message };
                return View("Error", error);
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product item)
        {
           try
            {
                if (ModelState.IsValid)
                {
                   string result= _service.Add(item);
                    ViewData["result"] = result;
                    return View();
                   // return RedirectToAction("Index");
                }
                else
                    return View();
            }
            catch(Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel() { Message = ex.Message };
                return View("Error", error);
            }
        }
        public IActionResult Delete(int id)
        {
            try
            {
                string result = _service.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel() { Message = ex.Message };
                return View("Error", error);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_service.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Product item)
        {
            try
            {
                _service.Update(item);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ErrorViewModel error = new ErrorViewModel() { Message = ex.Message };
                return View("Error", error);
            }
        }
    }
}
