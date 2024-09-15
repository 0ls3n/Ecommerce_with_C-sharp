using Ecommerce_Project.Models.Domain_Classes;
using Ecommerce_Project.Models.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Project.Controllers
{
    public class ExploreProductsController : Controller
    {

        private readonly IRepository<Product> _productRepo;

        public ExploreProductsController(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productRepo.GetAllAsync());
        }
    }
}
