using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSKeylinx.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSKeylinx.Data;
using CSKeylinx.Models;

namespace CSKeylinx.Controllers
{
    public class PlayersController : Controller
    {
        private readonly CSKeylinxContext _context;
        private readonly DataAccess _dataAccess;
        private readonly DataProcess _dataProcess;

        public PlayersController(CSKeylinxContext context)
        {
            _context = context;
            _dataAccess = new DataAccess(_context);
            _dataProcess = new DataProcess();
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            var players = await _dataAccess.GetPlayers();
            return View(_dataProcess.SortPlayers(players));
        }

    }
}
