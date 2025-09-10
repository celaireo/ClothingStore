using System.Collections.Generic;
using ClothingStore.Models;

namespace ClothingStore.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll(string? name = null, string? category = null, Size? size = null);
        Product? GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}