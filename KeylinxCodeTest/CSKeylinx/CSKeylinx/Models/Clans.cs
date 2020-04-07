using System;
using System.Collections.Generic;

namespace CSKeylinx.Models
{
    public partial class Clans
    {
        public Clans()
        {
            MatchesClanAway = new HashSet<Matches>();
            MatchesClanHome = new HashSet<Matches>();
            Players = new HashSet<Players>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }

        public virtual ICollection<Matches> MatchesClanAway { get; set; }
        public virtual ICollection<Matches> MatchesClanHome { get; set; }
        public virtual ICollection<Players> Players { get; set; }
    }
}
