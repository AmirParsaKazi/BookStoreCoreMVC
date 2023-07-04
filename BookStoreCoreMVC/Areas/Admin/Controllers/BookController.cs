using BookStoreCoreMVC.Models.ViewModels.Category;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreCoreMVC.Areas.Admin.Controllers;

[Area("Admin")]
public class BookController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
      
        return View();
    }
}

