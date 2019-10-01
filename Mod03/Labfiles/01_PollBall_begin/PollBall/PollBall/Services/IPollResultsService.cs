using System.Collections.Generic;

namespace PollBall.Services
{
    public interface IPollResultsService
    {
        void AddVote(SelectedGame game);
        SortedDictionary<SelectedGame, int> GetVoteResult();
    }
}
