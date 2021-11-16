using JukeboxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JukeboxApp.Repositories.Implements
{
    public class TrackListRepository : GenericRepository<TracksAlbum>, ITrackListRepository
    {
        public TrackListRepository(JukeboxContext jukeboxContext) : base(jukeboxContext)
        { 
        
        }
    }
}
