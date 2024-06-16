using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models;

namespace ShopOnline.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var listProduct = new List<Product>();

        for (var i = 0; i <= 6; i++)
        {
            var product = new Product()
            {
                Imgage = "Image/imgdemo.jpg",
                Title = "Tiêu đề " + i,
                Content = "Nội dung " + i,
                Detail = "Detail" + i,
                Price = i,
                Quantity = i
            };
            listProduct.Add(product);
        }
        
        return View(listProduct);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}