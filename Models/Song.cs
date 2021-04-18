using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpekCheckV2.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Additional property from Artists model: ArtistId
        // Additional property from Artists model: ArtistName
        // Additional property from Albums model: AlbumId
        // Additional property from Albums model: AlbumName
    }
}
