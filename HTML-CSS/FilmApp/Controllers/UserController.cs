using System;
using FilmApp.Data;
using FilmApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace FilmApp.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index(){
            return View(await _context.Users.ToListAsync());
        }
        
        public IActionResult Create(){
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(User model){
            _context.Users.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("List");
        }
        
        public async Task<IActionResult> List(){
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
    }
}