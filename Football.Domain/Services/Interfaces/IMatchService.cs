using Football.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Domain.Services.Interfaces
{
    interface IMatchService
    {
        void SetCard(int playerId, int matchId, string colorCard);
    }
}
