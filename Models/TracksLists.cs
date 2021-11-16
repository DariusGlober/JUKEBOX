using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JukeboxApp.Models
{
    public partial class TracksLists
    {
        public TracksLists()
        {
            TracksAlbum = new HashSet<TracksAlbum>();
        }

        public int Id { get; set; }
        public string ListName { get; set; }

        public virtual ICollection<TracksAlbum> TracksAlbum { get; set; }
    }
}
