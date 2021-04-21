using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpekCheckV2.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }

        // Additional property from Artists model: ArtistId
        // Additional property from Artists model: ArtistName
        [JsonIgnore]
        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public int ArtistName { get; set; }
    }
}
