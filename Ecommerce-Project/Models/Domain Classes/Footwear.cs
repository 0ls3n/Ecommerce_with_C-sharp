using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Project.Models.Domain_Classes 
{
    public class Footwear : Product
    {
        [Required]
        public string Size { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        [Required]
        public bool IsWaterproof { get; set; }
        [Required]
        public Gender Gender { get; set; }

        public Footwear(string name, string description, decimal price, string brand, ProductCategory category, DateTime createdAt, int id, string size, string color, string material, bool isWaterproof, Gender gender) : base(name, description, price, brand, category, createdAt, id)
        {
            Size = size;
            Color = color;
            Material = material;
            IsWaterproof = isWaterproof;
            Gender = gender;
        }
    }
}