using System;
using System.Collections.Generic;

namespace CSKeylinx.Models
{
    public partial class Players
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int? ClanId { get; set; }
        public int Score { get; set; }

        public virtual Clans Clan { get; set; }
    }
}
