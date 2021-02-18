using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data
{
    public class FootballContext : DbContext
    {
        public FootballContext() : base("Default") { }
        public FootballContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Match>()
                .HasMany(x => x.Players)
                .WithRequired()
                .HasForeignKey(x => x.MatchId);
        }
    }
}
