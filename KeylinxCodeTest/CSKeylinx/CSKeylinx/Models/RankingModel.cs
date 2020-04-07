using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSKeylinx.Models
{
    public class RankingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MatchesPlayed { get; set; }
        public int? TotalScore { get; set; } = 0;
        public int? TotalWonMatches { get; set; } = 0;
        public int? TotalDraws { get; set; } = 0;
        public int? TotalWonRounds { get; set; } = 0;
        public int? TotalLostMatches { get; set; } = 0;
        public int? TotalLostRounds { get; set; } = 0;

        public RankingModel()
        {
        }

        public RankingModel(string name)
        {
            Name = name;
        }

    }
}
