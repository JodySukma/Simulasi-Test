using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rumah_Idaman.Data;

namespace Rumah_Idaman.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _enviroment;

        public UserController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _enviroment = environment;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locations.ToListAsync());
        }
    }
}