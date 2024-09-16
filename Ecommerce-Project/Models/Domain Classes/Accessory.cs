using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Project.Models.Domain_Classes 
{
    public class Accessory : Product
    {
        public string? Material { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public Gender Gender { get; set; }
        public Accessory(string name, string description, decimal price, string brand, ProductCategory category, DateTime createdAt, string material, string type, Gender gender, string imagePath) : base(name, description, price, brand, category, createdAt, imagePath)
        {
            Material = material;
            Type = type;
            Gender = gender;
        }
    }
}