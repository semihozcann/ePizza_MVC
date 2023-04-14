﻿using ePizza.Entities.Concrete;
using ePizza.Services.Interfaces;
using ePizza.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ePizza.UI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _authenticationService.AuthenticateUser(model.Email, model.Password);
                if (user != null)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    if (user.Roles.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }
                    else if (user.Roles.Contains("User"))
                    {
                        return RedirectToAction("GetAllProducts", "Products", new { area = "User" });
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Eposta Adresiniz veya Şifreniz Yanlış");
                    ViewBag.Error = "Eposta Adresiniz veya Şifreniz Yanlış";
                    return View("Login");
                }
            }
            else
            {
                ModelState.AddModelError("", "Eposta Adresiniz veya Şifreniz Yanlış");

            }
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name,
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                };
                bool result = _authenticationService.CreateUser(user, model.Password);
                if (result)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _authenticationService.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogOutComplete()
        {
            return View();
        }
        public IActionResult Unauthorize()
        {
            return View();
        }
    }
}
