using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Final.Models;

namespace Final.Controllers;

public class HomeController : Controller
{
    //If its private need an underscore context (_context)
    private IRepo _repo { get; set; }

    //Constructor
    public HomeController(IRepo temp)
    {
        _repo = temp;
    }
    //The list will be pasted to the view
    public IActionResult Index()
    {
        var x = _repo.Movies.ToList();
        return View(x);
    }


}

