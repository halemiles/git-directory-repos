using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using git_stats.Models;
using LibGit2Sharp;
using System.IO;
using git_directory_repos.Interfaces;

namespace git_stats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGitStatusSummary _statusSummary;

        public HomeController(ILogger<HomeController> logger, IGitStatusSummary statusSummary)
        {   
            _logger = logger;
            _statusSummary = statusSummary;
        }

        public IActionResult Index()
        {
            string directoryUrl = "D:\\code\\work";
            var vm = _statusSummary.GetReposForFolder(directoryUrl);
            return View(vm);
            
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
