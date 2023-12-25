using System;
using FilmApp.Data;
using FilmApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmApp.Controllers
{
    public class FilmController : Controller
    {
        private readonly DataContext _context;
        public FilmController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(){
            return View(await _context.Films.ToListAsync());
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Film model){
            _context.Films.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<int> Like([FromBody]LikeWatchModel model){
            var film = await
            _context.Films.FindAsync(model.FilmId);
            if (model.IsLike)
            {
                film.LikeCount++;
            }
            else
            {
                film.WatchList++;
            }
            await _context.SaveChangesAsync();

             return model.IsLike ? film.LikeCount: film.WatchList;           
        }
        
    }
}
