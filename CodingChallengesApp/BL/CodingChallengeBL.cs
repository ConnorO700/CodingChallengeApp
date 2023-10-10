using CodingChallengesApp.Data;
using CodingChallengesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingChallengesApp.BL
{
    public class CodingChallengeBL(ILogger<CodingChallengeBL> logger, CodingChallengeContext context) : ICodingChallengeBL
    {
        private readonly ILogger<CodingChallengeBL> _logger = logger;
        private readonly CodingChallengeContext _context = context;

  

        public async Task<IEnumerable<CodingChallenge>> GetAll()
        {
            var challenges = await _context.CodingChallenges.ToListAsync();
            return challenges;
        }

        public async Task<CodingChallenge> GetSingle(int id)
        {
            var challenge = await _context.CodingChallenges.FindAsync(id);
            if (challenge == null)
            {
                throw new Exception("Does not exist");
            }
            return challenge;
        }

        public void Add(CodingChallenge challenge)
        {
            context.Add(challenge);
            context.SaveChanges();
        }
    }
}
