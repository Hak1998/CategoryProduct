using Grdonam.Models;
using Grdonam.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication17.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServie _categoryService;
        public CategoryController(ICategoryServie categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryService.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryModel category)
        {
            _categoryService.Add(category);
            return Redirect("Index");
        }
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            CategoryModel category = _categoryService.Get(id);
            return View(category);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _categoryService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            CategoryModel category = _categoryService.Get(id);
            return View(category);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            CategoryModel category = _categoryService.Get(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(CategoryModel product)
        {
            _categoryService.Update(product);
            return RedirectToAction("Index");
        }
    }
}
