using CodingChallengesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingChallengesApp.Data
{
    public class CodingChallengeContext : DbContext
    {
        private readonly IConfiguration _config;
        public CodingChallengeContext(DbContextOptions<CodingChallengeContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public required DbSet<CodingChallenge> CodingChallenges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DBConnectionString"));
        }
    }
}
