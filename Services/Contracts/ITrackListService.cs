using JukeboxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JukeboxApp.Services.Contracts
{
    public interface ITrackListService :IGenericService<TracksAlbum>
    {
        //public Task<List<TracksAlbum>> GetList();


    }
}
