using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using todolistapp.Models;

namespace todolistapp.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ISession _session;
        public UserController(AppDbContext context, IHttpContextAccessor httpContext)
        {
            _session = httpContext.HttpContext.Session;
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] Users user)
        {
            var get_user = _context.users.FirstOrDefault(u => u.login == user.login && u.password == user.password);
            if(get_user != null)
            {
                _session.SetString("userName", get_user.name);
                return RedirectToAction("Index", "Home", get_user);
            }
            else
            {
                return View("Home/Error");
            }
        }
    }
}