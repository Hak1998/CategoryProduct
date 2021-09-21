using Grdonam.Models;
using Grdonam.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
namespace WebApplication17.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServie _productService;
        public ProductController(IProductServie productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Index(int count)
        {
            var products = _productService.GetAll();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            _productService.Add(product);
            return Redirect("Index");
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            ProductModel product = _productService.Get(id);
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            ProductModel product = _productService.Get(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            ProductModel product = _productService.Get(id);
            return View(product);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
