using System;

namespace QuietFile.Backend
{
    public enum FileCopyResultStatus
    {
        None = 0,
        Success = 1,
        Error = 2
    };
    
    public class FileCopyResult
    {
        public FileCopyResultStatus Status { get; set; }
        public string ErrorMessage { get; set; }
        public TimeSpan Elapsed { get; set; }

        public FileCopyResult(FileCopyResultStatus status)
        {
            Status = status;
        }
    }
}
