using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JukeboxApp.Models
{
    public partial class Tracks
    {
        public Tracks()
        {
            TracksAlbum = new HashSet<TracksAlbum>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int? CoverId { get; set; }

        public virtual ICollection<TracksAlbum> TracksAlbum { get; set; }
    }
}
