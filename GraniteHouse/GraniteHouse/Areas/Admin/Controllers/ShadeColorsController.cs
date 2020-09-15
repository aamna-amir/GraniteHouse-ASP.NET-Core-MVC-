using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using GraniteHouse.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace GraniteHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class ShadeColorsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ShadeColorsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var shades = _db.ShadeColors.ToList();
            return View(shades);
        }

        // Create
        public IActionResult Create()
        {
            return View();
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsNameValid(string Name)
        {
            var shadeColor = _db.ShadeColors.Where(x => x.Name == Name).FirstOrDefault();
            if (shadeColor == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"{Name} already exist.");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShadeColors shadeColors)
        {
            if(ModelState.IsValid)
            {
                var shadeColor = _db.ShadeColors.Where(x => x.Name == shadeColors.Name).FirstOrDefault();
                if(shadeColor!=null)
                {
                    return View(shadeColors);
                }
                else
                {
                    _db.ShadeColors.Add(shadeColors);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }
            return View(shadeColors);
        }

        // Edit
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var shadeColor = _db.ShadeColors.Where(x => x.Id == id).FirstOrDefault();
            if (shadeColor == null)
            {
                return NotFound();
            }
            return View(shadeColor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ShadeColors shadeColors)
        {
            if(id != shadeColors.Id)
            {
                return NotFound();
            }
            if(shadeColors != null)
            {
                _db.ShadeColors.Update(shadeColors);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nameof(Index));
        }

        // Details
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var shadeColor = await _db.ShadeColors.FindAsync(id);
            if(shadeColor == null)
            {
                return NotFound();
            }
            return View(shadeColor);
        }

        // Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shadeColor = _db.ShadeColors.Where(x => x.Id == id).FirstOrDefault();
            if (shadeColor == null)
            {
                return NotFound();
            }
            return View(shadeColor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var shadeColor = _db.ShadeColors.Where(x => x.Id == id).FirstOrDefault();
            if (shadeColor != null)
            {
                _db.ShadeColors.Remove(shadeColor);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nameof(Index));
        }

    }
}
