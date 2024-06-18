using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models;

namespace ShopOnline.Controllers;

public class DetailController : Controller
{
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
}