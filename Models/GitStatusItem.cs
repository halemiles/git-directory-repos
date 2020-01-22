using System;
using System.Collections.Generic;

namespace git_stats.Models
{
    public class GitStatusItem
    {
        public string FolderName { get; set; }
        public string BranchName { get; set; }
        public int StashCount { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<int> CommitSparkLineValues { get; set; }
    }
}