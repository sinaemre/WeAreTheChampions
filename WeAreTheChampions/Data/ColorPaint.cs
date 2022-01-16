using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    [Table("ColorPaint")]
    public class ColorPaint
    {
            public ColorPaint()
            {
                Teams = new List<Team>();
            }
            [Key]
            public int ColorPaintId { get; set; }

            [Required, MaxLength(100)]
            public string ColorName { get; set; }

            public double Red { get; set; }

            public double Green { get; set; }

            public double Blue { get; set; }

            public virtual ICollection<Team> Teams { get; set; }
    }
}
