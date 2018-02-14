using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects;
using LibGit2Sharp;

namespace GitMetricsapp.Library
{
    public class Commits
    {
        public List<CommitDetails> GetCommitDetails()
        {
            List<CommitDetails> listOfCommits = new List<CommitDetails>();
            var repo = new Repository(@"C:\Work\SMWorkspace\Bonobo\newrepo");
            foreach (Branch branch in repo.Branches)
            {
                foreach (Commit commit in branch.Commits)
                {
                    var details = new CommitDetails
                    {
                        Author = commit.Author.Name,
                        Message = commit.Message,
                        Time = commit.Author.When.DateTime,
                        Branch = branch.FriendlyName
                    };
                    listOfCommits.Add(details);
                }
            }
            return listOfCommits;
        }

        public IEnumerable<CommitDetails> GetUserSpecificCommitDetails(string user)
        {
            var allCommitDetails = GetCommitDetails();
            var filteredCommitDetails = allCommitDetails.Where(x => x.Author.ToLower().Contains(user.ToLower()));
            return filteredCommitDetails;
        }
    }
}