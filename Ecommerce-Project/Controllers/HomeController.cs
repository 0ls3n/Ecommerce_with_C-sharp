using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce_Project.Models;
using Ecommerce_Project.Models.Persistence;
using Ecommerce_Project.Models.Domain_Classes;

namespace Ecommerce_Project.Controllers;

public class HomeController : Controller
{
    private readonly IRepository<Product> _productRepo;

    private List<Product> products = new List<Product>();

    public HomeController(IRepository<Product> productRepo)
    {
        _productRepo = productRepo;
    }

    public async Task<IActionResult> Index()
    {
        #region Test
        //var clothing1 = new Clothing(
        //    "Classic Crew Neck T-Shirt",
        //    "A timeless, comfortable crew neck t-shirt.",
        //    19.99m,
        //    "Uniqlo",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "M",
        //    "White",
        //    "Cotton",
        //    Gender.Male
        //    , "https://ekco.dk/media/iopt/catalog/product/cache/b986d8995d3903ceabf8385dcf226f67/image/111191fcee/youbrands-1500-classic-t-shirt-sort.webp");

        //var clothing2 = new Clothing(
        //    "V-Neck Casual T-Shirt",
        //    "A casual v-neck t-shirt perfect for everyday wear.",
        //    22.50m,
        //    "H&M",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "L",
        //    "Black",
        //    "Polyester",
        //    Gender.Male,
        //    "https://tojkurven.dk/wp-content/uploads/2019/10/Casual-Friday-T-shirt-20503062-Night-Navy-front.jpg"
        //    );

        //var clothing3 = new Clothing(
        //    "Graphic Print Tee",
        //    "T-shirt with a cool graphic print design.",
        //    15.00m,
        //    "Zara",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "S",
        //    "Red",
        //    "Cotton",
        //    Gender.Male,
        //    "https://admin.kaufmannstatic.com/Images/192273_charcoal_01-T20240903111717.jpg?i=192273_charcoal_01-T20240903111717.jpg&w=850&h=850&bgcolor=f1f1f1"
        //    );

        //var clothing4 = new Clothing(
        //    "Slim Fit Tee",
        //    "A slim fit tee that hugs your body.",
        //    25.00m,
        //    "Nike",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "XL",
        //    "Blue",
        //    "Dri-FIT",
        //    Gender.Male,
        //    "https://www.toftshop.dk/shared/54/718/tommy-hilfiger-tommy-hilfiger-stretch-slim-fit-tee-t-shirt-classic-khaki_1420w.jpg"
        //    );

        //var clothing5 = new Clothing(
        //    "Long Sleeve T-Shirt",
        //    "A comfortable long sleeve t-shirt for cooler weather.",
        //    29.99m,
        //    "Adidas",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "M",
        //    "Green",
        //    "Cotton Blend",
        //    Gender.Male,
        //    "https://mackweldon.com/cdn/shop/products/LongSleeve_Black_Front_7f27fac8-8157-43e2-a366-5aeed7b36f43.png?v=1618909943"
        //    );

        //var clothing6 = new Clothing(
        //    "Pocket Tee",
        //    "T-shirt with a small front pocket.",
        //    18.99m,
        //    "Gap",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "L",
        //    "Gray",
        //    "Cotton",
        //    Gender.Male,
        //    "https://www.bfgcdn.com/1500_1500_90/216-2893-0211/patagonia-daily-pocket-tee-t-shirt.jpg");

        //var clothing7 = new Clothing(
        //    "Henley T-Shirt",
        //    "A henley style t-shirt with buttons at the neck.",
        //    24.99m,
        //    "Old Navy",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "M",
        //    "Navy",
        //    "Jersey",
        //    Gender.Male,
        //    "https://i.ebayimg.com/images/g/uPUAAOSwh1tkAZFN/s-l1200.jpg");

        //var clothing8 = new Clothing(
        //    "Raglan Sleeve Tee",
        //    "Raglan sleeve t-shirt for a sporty look.",
        //    26.50m,
        //    "Puma",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "XL",
        //    "Black/White",
        //    "Polyester",
        //    Gender.Male, 
        //    "https://cdn.clothingshoponline.com/Images/Color/46062_f_fl.jpg"
        //    );

        //var clothing9 = new Clothing(
        //    "Vintage Wash Tee",
        //    "Vintage wash t-shirt with a worn-in look.",
        //    21.00m,
        //    "Levi's",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "L",
        //    "Brown",
        //    "Cotton",
        //    Gender.Male,
        //    "https://www.unikclothing.co.uk/cdn/shop/files/BLACKWASHTEE_1445x.jpg?v=1701429124");

        //var clothing10 = new Clothing(
        //    "Muscle Fit Tee",
        //    "A fitted t-shirt for a muscular physique.",
        //    30.00m,
        //    "Reebok",
        //    ProductCategory.MensTShirts,
        //    DateTime.Now,
        //    "S",
        //    "Olive",
        //    "Spandex Blend",
        //    Gender.Male,
        //    "https://image.hm.com/assets/hm/29/ee/29eeec83869cd0589bdeed6008eb16b30d47437e.jpg?imwidth=2160");

        //await _productRepo.AddAsync(clothing1);
        //await _productRepo.AddAsync(clothing2);
        //await _productRepo.AddAsync(clothing3);
        //await _productRepo.AddAsync(clothing4);
        //await _productRepo.AddAsync(clothing5);
        //await _productRepo.AddAsync(clothing6);
        //await _productRepo.AddAsync(clothing7);
        //await _productRepo.AddAsync(clothing8);
        //await _productRepo.AddAsync(clothing9);
        //await _productRepo.AddAsync(clothing10);
        #endregion

        products = await _productRepo.GetAllAsync();



        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
