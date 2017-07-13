using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glitchdoctor.Models
{
    public class PollContext : DbContext
    {
        private IConfiguration _config;

        public PollContext(IConfigurationRoot config, DbContextOptions options ) : base(options)
        {
            _config = config;
        }

        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollOptions> Options { get; set; }
        public DbSet<PollResponse> Responses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:GlitchContextConnection"]);
        }
    }
}
