using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokeApplications.Models;

namespace JokeApplications.Data
{
    public class JokeApplicationsDbContext : DbContext
    {
        public JokeApplicationsDbContext (DbContextOptions<JokeApplicationsDbContext> options)
            : base(options)
        {
        }

        public DbSet<JokeApplications.Models.Joke> Joke { get; set; } = default!;
    }
}
