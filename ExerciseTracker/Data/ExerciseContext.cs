using ExerciseTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Data;

internal class ExerciseContext : DbContext
{
    public DbSet<RunSession> RunSessions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        optionsBuilder.UseSqlite(connectionString);
    }
}
