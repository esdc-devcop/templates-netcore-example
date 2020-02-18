using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreMVCDemo.Models;
using GoC.WebTemplate.CoreMVC.Controllers;
using GoC.WebTemplate.Components.Core.Services;

namespace CoreMVCDemo.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ModelAccessor modelAccessor)
            : base(modelAccessor)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            WebTemplateModel.Breadcrumbs.Add(
                new GoC.WebTemplate.Components.Entities.Breadcrumb
                {
                    Title = "Welcome"
                });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
