using Football.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Domain.Services.Interfaces
{
    interface IPlayerService
    {
        IEnumerable<Player> GetAll();
        void GetCard();
    }
}
