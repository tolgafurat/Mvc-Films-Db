using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFilmDb.Models;

namespace MvcFilmDb.Data
{
    public class MvcFilmDbContext : DbContext
    {
        public MvcFilmDbContext (DbContextOptions<MvcFilmDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcFilmDb.Models.Film> Film { get; set; } = default!;
    }
}
