using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JukeboxApp.Models;
using JukeboxApp.Services;
using JukeboxApp.Services.Contracts;

namespace JukeboxApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracksListsController : ControllerBase
    {
        private ITrackListService _trackListService;
        public TracksListsController(ITrackListService trackListService)
        {
            _trackListService = trackListService;
        }

        // GET: api/TracksLists
        //[HttpGet]
        //public async Task<List<TracksAlbum>>  GetTracksLists()
        //{
        //    return await _trackListService.GetList();
        //}

        // GET: api/TracksLists/5
        [HttpGet("{id}")]
        public async Task<TracksAlbum> GetTracksLists(int id)
        {
            return await _trackListService.GetById(id);
        }

        // PUT: api/TracksLists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<TracksAlbum> PutTracksLists(TracksAlbum tracksLists)
        {
            return await _trackListService.Update(tracksLists);
        }

        // POST: api/TracksLists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<TracksAlbum> PostTracksLists(TracksAlbum tracksLists)
        {
            return await _trackListService.Insert(tracksLists);
        }

        // DELETE: api/TracksLists/5
        [HttpDelete("{id}")]
        public async Task DeleteTracksLists(int id)
        {
            await _trackListService.Delete(id);
        }

    }
}
