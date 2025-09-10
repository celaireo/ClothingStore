using System;
using System.Collections.Generic;
using System.Linq;
using ClothingStore.Models;

namespace ClothingStore.Data
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        private int _nextId = 4;

        public InMemoryProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Classic Tee", Category = "T-Shirts", Price = 19.99m, ReleaseDate = DateTime.Today.AddDays(-30), InStock = true, Size = Size.M },
                new Product { Id = 2, Name = "Denim Jacket", Category = "Jackets", Price = 59.99m, ReleaseDate = DateTime.Today.AddDays(-10), InStock = true, Size = Size.L },
                new Product { Id = 3, Name = "Summer Shorts", Category = "Shorts", Price = 24.99m, ReleaseDate = DateTime.Today.AddDays(-5), InStock = false, Size = Size.S }
            };
        }

        public IEnumerable<Product> GetAll(string? name = null, string? category = null, Size? size = null)
        {
            var query = _products.AsQueryable();
            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrWhiteSpace(category))
                query = query.Where(p => p.Category.Contains(category, StringComparison.OrdinalIgnoreCase));
            if (size.HasValue)
                query = query.Where(p => p.Size == size.Value);
            return query.ToList();
        }

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing == null) return;
            existing.Name = product.Name;
            existing.Category = product.Category;
            existing.Price = product.Price;
            existing.ReleaseDate = product.ReleaseDate;
            existing.InStock = product.InStock;
            existing.Size = product.Size;
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
                _products.Remove(product);
        }
    }
}