using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaskForge.Data;
using TaskForge.Models;

namespace TaskForge.Controllers;

public class HomeController(AppDbContext dbContext) : Controller {

    public IActionResult Index() {
        return View();
    }

    public IActionResult Privacy() {
        return View();
    }
    
    [Route("Home/Users/{id}")]
    public IActionResult Users(string id) {
        var user = dbContext.Users.FirstOrDefault(u => u.Id == id);
        return View("User", user);
    }

    public IActionResult Services(int id) {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
