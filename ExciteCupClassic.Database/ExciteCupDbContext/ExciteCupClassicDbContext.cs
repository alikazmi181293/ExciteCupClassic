using ExciteCupClassic.Models.Core;
using Microsoft.EntityFrameworkCore;

namespace ExciteCupClassic.Database.ExciteCupDbContext;

public class ExciteCupClassicDbContext : DbContext
{
    public ExciteCupClassicDbContext(DbContextOptions<ExciteCupClassicDbContext> options) : base(options) { }

    public DbSet<Competition> Competitions { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Registration> Registrations { get; set; }
}