using System;
using System.Collections.Generic;
using System.IO;
using git_stats.Models;

namespace git_stats.Models
{
    public class GitStatusViewModel
    {
        public string DirectoryUrl { get; set; }
        public string DirectoryFriendlyName { get { return Path.GetFileName(DirectoryUrl); } }
        public List<GitStatusItem> GitRepos = new List<GitStatusItem>();
        

    }
}