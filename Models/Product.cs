using System;
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Models
{
    public enum Size { XS, S, M, L, XL, XXL }

    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Category { get; set; }

        [Range(0.01, 10000)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public bool InStock { get; set; }

        [Required]
        public Size Size { get; set; }
    }
}