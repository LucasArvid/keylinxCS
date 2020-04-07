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
    public class MatchesController : Controller
    {
        private readonly CSKeylinxContext _context;
        private readonly DataAccess _dataAccess;

        public MatchesController(CSKeylinxContext context)
        {
            _context = context;
            _dataAccess = new DataAccess(_context);
        }

        // GET: Matches
        public async Task<IActionResult> Index()
        {
            return View(await _dataAccess.GetMatches());
        }
    }
}
