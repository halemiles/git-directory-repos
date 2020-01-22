using git_stats.Models;

namespace git_directory_repos.Interfaces
{
    public interface IGitStatusSummary
    {
        GitStatusViewModel GetReposForFolder(string directoryUrl);
    }
}