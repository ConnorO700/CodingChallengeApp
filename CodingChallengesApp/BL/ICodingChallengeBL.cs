using CodingChallengesApp.Models;

namespace CodingChallengesApp.BL
{
    public interface ICodingChallengeBL
    {
        void Add(CodingChallenge challenge);
        Task<IEnumerable<CodingChallenge>> GetAll();
        Task<CodingChallenge> GetSingle(int id);
    }
}