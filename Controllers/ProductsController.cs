using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClothingStore.Data;
using ClothingStore.Models;

namespace ClothingStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(string name, string category, Size? size)
        {
            var products = _repo.GetAll(name, category, size);
            ViewBag.Name = name;
            ViewBag.Category = category;
            ViewBag.Size = size;
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _repo.GetById(id);
            if (product == null) return NotFound();
            return View(product);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid) return View(product);
            _repo.Add(product);
            TempData["Message"] = "Product added";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var product = _repo.GetById(id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            if (!ModelState.IsValid) return View(product);
            _repo.Update(product);
            TempData["Message"] = "Product updated";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var product = _repo.GetById(id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            TempData["Message"] = "Product deleted";
            return RedirectToAction(nameof(Index));
        }
    }
}