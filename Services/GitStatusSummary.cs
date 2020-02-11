using System;
using System.IO;
using git_directory_repos.Interfaces;
using git_stats.Models;
using git_stats.Models;
using LibGit2Sharp;
using System.Linq;

namespace git_directory_repos.Services
{
    public class GitStatusSummary : IGitStatusSummary
    {
        public GitStatusSummary()
        {

        }
        public GitStatusViewModel GetReposForFolder(string folderUrl)
        {
            GitStatusViewModel vm = new GitStatusViewModel();            
            var directories = Directory.GetDirectories(folderUrl);;
            vm.DirectoryUrl = folderUrl;
            foreach(string directory in directories)
            {
                try
                {
                    using(var repo = new Repository(directory))
                    {
                        vm.GitRepos.Add(new GitStatusItem(){
                            FolderName = Path.GetFileName(directory),
                            BranchName = repo.Head.FriendlyName,
                            StashCount = repo.Stashes.Count(),
                            LastUpdated = repo.Head.Commits.LastOrDefault().Committer.When.DateTime
                        });
                        
                    }
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
            return vm;
        }
    }
}