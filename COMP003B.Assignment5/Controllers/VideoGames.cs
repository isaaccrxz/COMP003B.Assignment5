﻿using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{
    public class VideoGames : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
