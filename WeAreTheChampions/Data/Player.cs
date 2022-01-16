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
    [Table("Player")]
    public class Player
    {
        
        [Key]
        public int PlayerId{ get; set; }
        
        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string BirthPlace { get; set; }

        public DateTime? BirthDate { get; set; }

        public string PlayerPhoto { get; set; }

        public int Pace { get; set; }
        
        public int Shoot { get; set; }
        
        public int Pass { get; set; }
        
        public int Drippling { get; set; }
        
        public int Physics { get; set; }
        
        public int Defence { get; set; }

        public Positions Position { get; set; }

        public int Rating { get; set; } = 0;

        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
