using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Ecommerce_Project.Models.Domain_Classes
{
    public class Product : Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }

        public Product(string name, string description, int price, string brand, int id)
        {
            Name = name;
            Description = description;
            Price = price;
            Brand = brand;
            Id = id;
        }
    }
}
