using NBASharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBASharp
{
    internal interface INBAClient
    {
        public Task<IEnumerable<PlayerBioModel>> GetPlayerBioAsync(string playerId);
        public Task<IEnumerable<GameModel>> GetScoreboardAsync(string date);
    }
}
