using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Domain.Models
{
    class Match
    {
        public int Id { get; set; }

        public string Place { get; set; }

        public DateTime DateTime { get; set; }

    }
}
