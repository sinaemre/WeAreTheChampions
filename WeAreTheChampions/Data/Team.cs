using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    [Table("Team")]
    public class Team
    {
        public Team()
        {
            HomeMatches = new List<Match>();
            AwayMatches = new List<Match>();
            Colors = new List<ColorPaint>();
            Logo = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "ChampionsLeague.jpeg";
            MascotPicture = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Mascot.png";
        }
        [Key]
        public int TeamId { get; set; }

        [Required, MaxLength(200)]
        public string TeamName { get; set; }

        public string Logo { get; set; }

        public string MascotName { get; set; }
        
        public string MascotPicture { get; set; }

        public double TeamRating { get; set; } = 0;

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Match> HomeMatches { get; set; }
        
        public virtual ICollection<Match> AwayMatches { get; set; }

        public virtual ICollection<ColorPaint> Colors { get; set; }
    }
}
