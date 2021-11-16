using JukeboxApp.Models;
using JukeboxApp.Repositories;
using JukeboxApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JukeboxApp.Services
{
    public class TrackListService : GenericService<TracksAlbum>, ITrackListService
    {
        private ITrackListRepository _trackListRepository;

        public TrackListService(ITrackListRepository trackListRepository) : base(trackListRepository)
        {
            _trackListRepository = trackListRepository;
        }

        public async Task<List<TracksAlbum>> GetList()
        {
            return await _trackListRepository.GetAll();
        }

    }
}
