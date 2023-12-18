using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using todolistapp.Models;

namespace todolistapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var tasks = _context.tasks.ToList();
            ViewBag.Tasks = tasks;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost("CreateTask")]
        public async Task<string> CreateTask([FromForm] Tasks task)
        {
            _context.tasks.Add(task);
            await _context.SaveChangesAsync();
            return "Successfully saved";
        }
    }
}
