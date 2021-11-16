using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JukeboxApp.Models
{
    public partial class TracksAlbum
    {
        public int Id { get; set; }
        public int IdList { get; set; }
        public int IdTrack { get; set; }

        public virtual TracksLists IdListNavigation { get; set; }
        public virtual Tracks IdTrackNavigation { get; set; }
    }
}
