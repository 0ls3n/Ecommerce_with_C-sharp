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
        products = await _productRepo.GetAllAsync();

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
