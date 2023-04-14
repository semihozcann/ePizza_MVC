﻿using ePizza.UI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.UI.Areas.User.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(IUserAccessor userAccessor) : base(userAccessor)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
