using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpekCheckV2.Models
{
    public class Spectro
    {
        public int Id { get; set; }
        public string Spectrograph { get; set; }

        // Additional property from Artists model: ArtistId
        // Additional property from Artists model: ArtistName
        [JsonIgnore]
        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public int ArtistName { get; set; }

        // Additional property from Albums model: AlbumId
        // Additional property from Albums model: AlbumName
        [JsonIgnore]
        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }
        public int AlbumTitle { get; set; }

        // Additional property from Songs model: SongId
        // Additional property from Songs model: SongTitle
        [JsonIgnore]
        public virtual Song Song { get; set; }
        public int SongId { get; set; }
        public int SongTitle { get; set; }
    }
}
