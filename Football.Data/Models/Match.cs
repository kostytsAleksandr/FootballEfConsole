using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Models
{
    public class Match
    {
        public int Id { get; set; }

        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
