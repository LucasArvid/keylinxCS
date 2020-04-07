using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CSKeylinx.Data;
using CSKeylinx.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders.Testing;

namespace CSKeylinx.BusinessLogic
{
    public class DataProcess
    {

        public DataProcess ()
        {
        }

        public List<RankingModel> SortClans(List<Matches> matches, List<Clans> clans)
        {
            List<RankingModel> _ranking = new List<RankingModel>();
            foreach (var clan in clans)
            {
                RankingModel temp = new RankingModel();
                temp.Name = clan.Name;
                temp.Id = clan.Id;
                _ranking.Add(temp);
            }

            GetScores(matches, _ranking);
            _ranking.Sort((x, y) => y.TotalScore.Value.CompareTo(x.TotalScore.Value));
            return _ranking;

        }

        public List<Players> SortPlayers(List<Players> players)
        {
             players.Sort((x, y) => y.Score.CompareTo(x.Score));
             return players;
        }

        private void GetScores(List<Matches> match, List<RankingModel> _ranking)
        {
            foreach (var matches in match)
            {
                if (matches.ClanAwayScore > matches.ClanHomeScore)
                {
                    int winner = _ranking.FindIndex(x => x.Id == matches.ClanAwayId);
                    _ranking[winner].TotalWonMatches++;
                    _ranking[winner].MatchesPlayed++;
                    _ranking[winner].TotalWonRounds = _ranking[winner].TotalWonRounds + matches.ClanAwayScore;
                    _ranking[winner].TotalLostRounds = _ranking[winner].TotalLostRounds + matches.ClanHomeScore;

                    int loser = _ranking.FindIndex(x => x.Id == matches.ClanHomeId);
                    _ranking[loser].TotalLostMatches++;
                    _ranking[loser].MatchesPlayed++;
                    _ranking[loser].TotalWonRounds = _ranking[loser].TotalWonRounds + matches.ClanHomeScore;
                    _ranking[loser].TotalLostRounds = _ranking[loser].TotalLostRounds + matches.ClanAwayScore;
                }
                else if (matches.ClanAwayScore == matches.ClanHomeScore)
                {
                    int winner = _ranking.FindIndex(x => x.Id == matches.ClanAwayId);
                    _ranking[winner].TotalDraws++;
                    _ranking[winner].MatchesPlayed++;
                    _ranking[winner].TotalWonRounds = _ranking[winner].TotalWonRounds + matches.ClanAwayScore;
                    _ranking[winner].TotalLostRounds = _ranking[winner].TotalLostRounds + matches.ClanHomeScore;

                    int loser = _ranking.FindIndex(x => x.Id == matches.ClanHomeId);
                    _ranking[loser].TotalDraws++;
                    _ranking[loser].MatchesPlayed++;
                    _ranking[loser].TotalWonRounds = _ranking[loser].TotalWonRounds + matches.ClanHomeScore;
                    _ranking[loser].TotalLostRounds = _ranking[loser].TotalLostRounds + matches.ClanAwayScore;
                }
                else
                {
                    int winner = _ranking.FindIndex(x => x.Id == matches.ClanHomeId);
                    _ranking[winner].TotalWonMatches++;
                    _ranking[winner].MatchesPlayed++;
                    _ranking[winner].TotalWonRounds = _ranking[winner].TotalWonRounds + matches.ClanHomeScore;
                    _ranking[winner].TotalLostRounds = _ranking[winner].TotalLostRounds + matches.ClanAwayScore;

                    int loser = _ranking.FindIndex(x => x.Id == matches.ClanAwayId);
                    _ranking[loser].TotalLostMatches++;
                    _ranking[loser].MatchesPlayed++;
                    _ranking[loser].TotalWonRounds = _ranking[loser].TotalWonRounds + matches.ClanAwayScore;
                    _ranking[loser].TotalLostRounds = _ranking[loser].TotalLostRounds + matches.ClanHomeScore;
                }
                    
            }

            foreach (RankingModel x in  _ranking)
            {
                x.TotalScore = (x.TotalWonMatches * 3) + x.TotalDraws;
            }

        }
    }
}
