using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskForge.Data;
using TaskForge.Models;

namespace TaskForge.Controllers;

public class AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager) : Controller {
    public IActionResult Register() {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(Register model) {
        if (ModelState.IsValid) {
            AppUser user = new() {
                Name = model.Name,
                Surname = model.Surname,
                UserName = model.Username,
                Email = model.Email,
                Gender = Enum.GetName(typeof(Gender), model.Gender)!,
                DateOfBirth = model.DateOfBirth,
                Nationality = Enum.GetName(typeof(Nationality), model.Nationality)!,
                Languages = string.Join(',', model.Languages),
                ProfilePicture = "default.png"
            };

            var result = await userManager.CreateAsync(user, model.Password!);

            if (result.Succeeded) {
                await userManager.AddToRoleAsync(user, "User");

                await signInManager.PasswordSignInAsync(user, model.Password!, false, false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors) {
                ModelState.AddModelError("", error.Description); // Whatever error it may be e.g. Username already taken, Password error etc.
            }
        }
        return View(model);
    }

    public IActionResult Login() {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(Login model) {
        if (ModelState.IsValid) {
            var result = await signInManager.PasswordSignInAsync(model.Username!, model.Password!, model.RememberMe, false);

            if (result.Succeeded) {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid login attempt");
            return View(model);
        }
        return View(model);
    }

    public async Task<IActionResult> Logout() {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index","Home");
    } 

    public IActionResult Profile() {
        return View();
    }
}