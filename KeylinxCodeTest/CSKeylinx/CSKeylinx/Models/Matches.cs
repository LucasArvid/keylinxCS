using System;
using System.Collections.Generic;

namespace CSKeylinx.Models
{
    public partial class Matches
    {
        public int Id { get; set; }
        public int ClanHomeId { get; set; }
        public int? ClanHomeScore { get; set; }
        public int ClanAwayId { get; set; }
        public int? ClanAwayScore { get; set; }
        public DateTime? MatchDate { get; set; }
        public bool IsPlayed { get; set; }

        public virtual Clans ClanAway { get; set; }
        public virtual Clans ClanHome { get; set; }
    }
}
