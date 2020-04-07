using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSKeylinx.Data;
using CSKeylinx.Models;

namespace CSKeylinx.Controllers
{
    public class AdminController : Controller
    {
        private readonly CSKeylinxContext _context;
        private readonly DataAccess _dataAccess;

        public AdminController(CSKeylinxContext context)
        {
            _context = context;
            _dataAccess = new DataAccess(_context);
            
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            return View(await _dataAccess.GetClans());
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Origin")] Clans clans)
        {
            if (ModelState.IsValid)
            {
                await _dataAccess.AddClans(clans);
                return RedirectToAction(nameof(Index));
            }
            return View(clans);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clans = await _dataAccess.GetClanById(id);
            if (clans == null)
            {
                return NotFound();
            }
            return View(clans);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Origin")] Clans clans)
        {
            if (id != clans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _dataAccess.UpdateClans(clans);
                return RedirectToAction(nameof(Index));
            }
            return View(clans);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clans = await _dataAccess.GetClansById(id);
            if (clans == null)
            {
                return NotFound();
            }

            return View(clans);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _dataAccess.DeleteClanById(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ClansExists(int id)
        {
            return _context.Clans.Any(e => e.Id == id);
        }
    }
}
