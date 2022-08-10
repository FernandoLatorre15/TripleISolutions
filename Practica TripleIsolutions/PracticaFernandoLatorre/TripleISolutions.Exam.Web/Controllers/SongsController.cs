using Microsoft.AspNetCore.Mvc;
//using Oracle.ManagedDataAccess.Client;
using Microsoft.EntityFrameworkCore.SqlServer;
using TripleISolutions.Exam.Web.Data;
using TripleISolutions.Exam.Web.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace TripleISolutions.Exam.Web.Controllers
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SongsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CatSongs> songs = _db.CatSongs;
            return View(songs);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CatSongs catSongs)
        {
                _db.CatSongs.Add(catSongs);
                _db.SaveChanges();
                return RedirectToAction("Index");
        }

        public IActionResult Edit(int? songId)
        {
            if (songId == null || songId == 0)
                return NotFound();
            CatSongs? entityDb = _db.CatSongs.Find(songId);
            if (entityDb == null)
                return NotFound();
            return View(entityDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CatSongs catSongs)
        {
            if (ModelState.IsValid) {
                //if (catSongs.LaunchYear>=1900 || catSongs.LaunchYear<=) { }
                    _db.CatSongs.Update(catSongs);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? songId)
        {
            if (songId == null || songId == 0)
                return NotFound();
            CatSongs? entityDb = _db.CatSongs.Find(songId);
            if (entityDb == null)
                return NotFound();
            else
            {
                _db.CatSongs.Remove(entityDb);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}

