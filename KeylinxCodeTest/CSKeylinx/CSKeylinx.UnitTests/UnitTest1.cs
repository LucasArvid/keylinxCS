using System;
using System.Threading.Tasks;
using NUnit.Framework;
using CSKeylinx.Controllers;
using CSKeylinx.Models;
using CSKeylinx.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CSKeylinx.Data;

namespace CSKeylinx.UnitTests
{
    public class Tests
    {
        private List<Matches> matches;
        private List<Clans> clans;
        private List<Players> players;

        [SetUp]
        public void Setup()
        {
            matches = new List<Matches>();
            clans = new List<Clans>();
            players = new List<Players>();

            SetupObjects();
        }

        [Test]
        public void TestClansDetail()
        {
            DataProcess _dataProcess = new DataProcess();
            var result =  _dataProcess.SortClans(matches, clans);
            Console.Write("S");
            Assert.IsAssignableFrom<List<RankingModel>>(result);

        }

        [Test]
        public void TestSortPlayers()
        {
            DataProcess _dataProcess = new DataProcess();
            var result = _dataProcess.SortPlayers(players);
            Assert.IsAssignableFrom<List<Players>>(result);

        }

        public void SetupObjects()
        {
            for (int i = 0; i <= 5; i++)
            {
                Matches match = new Matches();
                Clans clan = new Clans();
                Players player = new Players();

                clan.Id = i;
                clan.Name = "clan" + i;
                clan.Origin = "origin" + i;

                match.Id = i;
                match.ClanHomeId = i;
                match.ClanHomeScore = i;
                match.ClanAwayScore = i + 1;
                match.IsPlayed = true;

                player.Id = i;
                player.Age = i + 1;
                player.Score = i + 22;
                player.Name = "name" + i;

                matches.Add(match);
                clans.Add(clan);
                players.Add(player);

            }

            matches[0].ClanAwayId = 2;
            matches[1].ClanAwayId = 3;
            matches[2].ClanAwayId = 4;
            matches[3].ClanAwayId = 0;
            matches[4].ClanAwayId = 1;
        }
    }
}