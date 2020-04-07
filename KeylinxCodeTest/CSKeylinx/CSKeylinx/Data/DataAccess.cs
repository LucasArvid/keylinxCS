using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using CSKeylinx.Models;
using CSKeylinx.BusinessLogic;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace CSKeylinx.Data
{
    public class DataAccess
    {

        private readonly CSKeylinxContext _context;
        private readonly DataProcess _dataProcess;

        public DataAccess(CSKeylinxContext context)
        {
            _context = context;
            _dataProcess = new DataProcess();
        }

        public async Task<Clans> GetClanById(int id)
        {
            Clans clan =  new Clans();
            try
            {
                clan = await _context.Clans.FirstOrDefaultAsync(m => m.Id == id);
            }
            catch (DbException ex)
            {
                Console.Write(ex);
            }

            if (clan == null)
            {
                return null;
            }
            return clan;

        }

        public async Task<bool> AddClans(Clans clan)
        {
            try
            {
                _context.Add(clan);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.Write(ex);
                return false;
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Clans> GetClansById(int id)
        {
            var clans = await _context.Clans.FindAsync(id);
            if (clans == null)
            {
                return null;
            }

            return clans;
        }

        public async Task<Players> EditPlayerById(int playerId, int newPlayerScore)
        {

            var player = await _context.Players.FirstAsync(x => x.Id == playerId);
            player.Score = newPlayerScore;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return player;

        }

        public async Task<bool> DeleteClanById(int id)
        {
            var clans = await _context.Clans.FindAsync(id);
            try
            {
                _context.Clans.Remove(clans);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.Write(ex);
                return false;
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<RankingModel>> GetSortedClans()
        {
            List<Matches> matches = await GetPlayedMatches();
            List<Clans> clans = await GetClans();
            return _dataProcess.SortClans(matches, clans);
        }

        public async Task<List<Matches>> GetPlayedMatches()
        {
            List<Matches> data = new List<Matches>();
            try
            {
                data = await _context.Matches.Where(x => x.IsPlayed).ToListAsync();

            }
            catch (DbException ex)
            {
                Console.Write(ex);
            }

            return data;
        }

        public async Task<List<Clans>> GetClans()
        {
            List<Clans> data = new List<Clans>();
            try
            {
                data = await _context.Clans.ToListAsync();

            }
            catch (DbException ex)
            {
                Console.Write(ex);
            }
            return data;
        }

        public async Task<List<Players>> GetPlayersById(int id)
        {
            List<Players> data = new List<Players>();
            try
            {
                data = await _context.Players.Where(x => x.ClanId == id).ToListAsync();

            }
            catch (DbException ex)
            {
                Console.Write(ex);
            }

            return data;
        }

        public async Task<bool> UpdateClans(Clans clan)
        {
            try
            {
                _context.Update(clan);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.Write(ex);
                return false;
            }

            return true;
        }

        public async Task<List<Players>> GetPlayers()
        {
            List <Players> data  = new List<Players>();
            try
            {
                data = await _context.Players.Include(p => p.Clan).ToListAsync();
            }
            catch (DbException ex)
            {
                Console.Write(ex);
            }

            return data;
        }

        public async Task<List<Matches>> GetMatches()
        {
            List <Matches> data = new List<Matches>();
            try
            {
                data = await _context.Matches.Include(m => m.ClanAway).Include(m => m.ClanHome).ToListAsync();
            }
            catch (DbException ex)
            {
                Console.Write(ex);
            }

            return data;
        }





    }
}
