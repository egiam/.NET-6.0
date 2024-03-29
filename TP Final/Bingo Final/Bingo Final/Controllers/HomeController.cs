﻿using Bingo_Final.Models;
using Bingo_Final.Rules;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bingo_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var rule = new BingoRule(_configuration);
            var cartones = rule.GetCuatroCartonesRandom();
            return View(cartones);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}