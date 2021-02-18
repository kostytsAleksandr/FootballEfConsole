using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int CountCards { get; set; }

        public int MatchId { get; set; }
    }
}
