using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpekCheckV2.Models;
using Microsoft.EntityFrameworkCore;

namespace SpekCheckV2
{
    public class SpekCheckV2Context : DbContext
    {
        public DbSet<Spectro> Spectros { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
