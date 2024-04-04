using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskForge.Data;
using TaskForge.Models;

namespace TaskForge.Controllers;

public class HomeController(AppDbContext dbContext, UserManager<AppUser> userManager) : Controller {

    public IActionResult Index() {
        return View();
    }

    public IActionResult Privacy() {
        return View();
    }
    
    [Route("Home/Users/{id}")]
    public IActionResult Users(string id) {
        var user = dbContext.Users
            .Include(u => u.Services)
            .FirstOrDefault(u => u.Id == id);
        return View("User", user);
    }

    [Authorize]
    [HttpGet]
    public IActionResult Publish() {
        return View();
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Publish(ServiceModel serviceModel) {
        var user = await userManager.GetUserAsync(User);
        var newService = new Service { 
            Title = serviceModel.Title,
            Description = serviceModel.Description,
            Price = serviceModel.Price,
            EstimatedTime = serviceModel.EstimatedTime,
            Provider = user
        };

        dbContext.Services.Add(newService);
        dbContext.SaveChanges();

        int i = 0;
        List<string> imgNames = [];
        if (serviceModel.Images != null && serviceModel.Images.Any()) {
            foreach (var image in serviceModel.Images) {
                if (image != null && image.Length > 0) {
                    var fileName = $"s{newService.ServiceId}_img{i}{Path.GetExtension(image.FileName)}";
                    var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/user-services", userManager.GetUserId(User)!);
                    
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                    var filePath = Path.Combine(folderPath, fileName);

                    using var stream = new FileStream(filePath, FileMode.Create);
                    await image.CopyToAsync(stream);

                    imgNames.Add(fileName);
                    i++;
                }
            }
        }

        newService.Images = string.Join('*', imgNames);
        dbContext.SaveChanges();

        return RedirectToAction("Service", new { id = newService.ServiceId });
    }

    public IActionResult Service(int id) {
        var service = dbContext.Services
            .Include(s => s.Provider)
            .FirstOrDefault(s => s.ServiceId == id);
        return View("Service", service);
    }

    public IActionResult Browse(string q) {
        if (q is null) return View(dbContext.Services.Include(s => s.Provider));

        q = q.ToLower();
        var services = dbContext.Services
            .Include(s => s.Provider)
            .Where(s =>
                (s.Title != null && s.Title.ToLower().Contains(q)) ||
                (s.Description != null && s.Description.ToLower().Contains(q)) ||
                (s.Provider != null && s.Provider.UserName!.ToLower().Contains(q)) // Forse
            );

        return View(services);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
