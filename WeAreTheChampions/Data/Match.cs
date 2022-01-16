using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Enums;

namespace WeAreTheChampions.Data
{
    [Table("Match")]
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        
        public int? HomeScore { get; set; }
        
        public int? AwayScore { get; set; }

        public string HomeTeamName { get; set; }
        public string GuestTeamName { get; set; }


        public DateTime MatchTime { get; set; }

        public string MatchScore { get; set; }
        
        public Result Result { get; set; }

        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }

        public int GuestTeamId { get; set; }
        public virtual Team GuestTeam { get; set; }
    }
}
