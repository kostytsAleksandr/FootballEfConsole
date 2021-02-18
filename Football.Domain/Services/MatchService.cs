using Football.Domain.Models;
using Football.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Data.Interfaces;

namespace Football.Domain.Services
{
    class MatchService : IMatchService
    {
        private readonly IMatchesRepository _matchesRepository;
        private readonly IPlayersRepository _playersRepository;

        public MatchService(IMatchesRepository matchesRepository, IPlayersRepository playersRepository)
        {
            _matchesRepository = matchesRepository;
            _playersRepository = playersRepository;
        }

        public void SetCard(int playerId, int matchId, string colorCard)
        {
            
        }
    }
}
