using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSKeylinx.Data;
using CSKeylinx.Models;
using CSKeylinx.BusinessLogic;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace CSKeylinx.Controllers
{
    public class ClansController : Controller
    {
        private readonly CSKeylinxContext _context;
        private DataAccess _dataAccess;

        public ClansController( CSKeylinxContext context)
        {
            _context = context;
            _dataAccess = new DataAccess(_context);
        }

        // GET: Clans
        public async Task<IActionResult> Index()
        {
            return View(await _dataAccess.GetSortedClans());

        }

        // GET: Clans/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var clans = await _dataAccess.GetClanById(id);
            if (clans == null)
            {
                return NotFound();
            }
            ViewBag.Clan = clans.Name;
            return View(await _dataAccess.GetPlayersById(id));
        }

        // POST: Clans/Edit/5
        // Reached by Ajax call from Clans/Details
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("PlayerId, PlayerScore")] int PlayerId, int PlayerScore)
        {
            if (ModelState.IsValid)
            {
                await _dataAccess.EditPlayerById(PlayerId, PlayerScore);
                return Json("");
            }

            return View();

        }

    }
}
