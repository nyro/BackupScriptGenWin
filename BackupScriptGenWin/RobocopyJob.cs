using System;
using System.Collections.Generic;

namespace BackupScriptGenWin
{
    class RobocopyJob
    {
        public String JobTitle { get; set; }
        public String SourceFolder { get; set; }
        public String TargetFolder { get; set; }

        public List<String> ExcludedPaths { get; set; }

        public bool Mirror { get; set; }
        public bool CopySubFolders { get; set; }
        public bool IncludeEmptyFolders { get; set; }
        public bool MoveFiles { get; set; }
        public bool MoveFolders { get; set; }
        public bool MirrorFiles { get; set; }
        public RobocopyMode CopyMode { get; set; }

        public RobocopyJob(String JobTitle, String SourceFolder, String TargetFolder)
        {
            this.JobTitle = JobTitle;
            this.SourceFolder = SourceFolder;
            this.TargetFolder = TargetFolder;

            this.ExcludedPaths = new List<string>();
            
            this.Mirror = false;
            this.CopySubFolders = true;
            this.IncludeEmptyFolders = true;
            this.MoveFiles = false;
            this.MoveFolders = false;
            this.MirrorFiles = false;
            this.CopyMode = RobocopyMode.Hybrid;
        }

        public enum RobocopyMode
        {
            Resumable,
            Backup,
            Hybrid
        }
    }
}
