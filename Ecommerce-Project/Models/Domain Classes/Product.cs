using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Ecommerce_Project.Models.Domain_Classes
{
    public class Product : Model
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }
        public string? Brand { get; set; }

        [Required]
        public ProductCategory Category { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product(string name, string description, decimal price, string brand, ProductCategory category, DateTime createdAt, int id)
        {
            Name = name;
            Description = description;
            Price = price;
            Brand = brand;
            Category = category;
            CreatedAt = createdAt;
            Id = id;
        }
    }
}
