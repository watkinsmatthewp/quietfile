using System;
using System.IO;
using System.Threading;

namespace QuietFile.Backend
{
    public abstract class FileGetter
    {
        public bool OverwiteDestinationPath { get; set; }
        public bool DeleteSourcePathAfterSuccess { get; set; }

        public string SourceFilePath { get; private set; }
        public string DestinationFilePath { get; private set; }

        public delegate void ProcessFinishedDelegate(FileCopyResult result);
        public event ProcessFinishedDelegate ProcessFinished;
        public void OnProcessFinished(FileCopyResult result)
        {
            if (ProcessFinished != null)
            {
                ProcessFinished(result);
            }
        }

        protected FileGetter(string sourceFilePath, string destinationFilePath)
        {
            ValidateInput(sourceFilePath, destinationFilePath);
            
            SourceFilePath = sourceFilePath;
            DestinationFilePath = destinationFilePath;
        }

        public void StartAsync()
        {
            // Start the process on a new thread
            new Thread(() =>
            {
                OnProcessFinished(Start());
            }).Start();
        }

        public FileCopyResult Start()
        {
            // Make sure the source file is not the same as the destination file
            if (SourceFilePath.Equals(DestinationFilePath, StringComparison.OrdinalIgnoreCase))
            {
                return new FileCopyResult(FileCopyResultStatus.Error)
                {
                    ErrorMessage = "The source file is the same as the destination file"
                };
            }

            // Make sure the destination directory exists
            string destinationDirectory = Path.GetDirectoryName(DestinationFilePath);
            if (!Directory.Exists(destinationDirectory))
            {
                return new FileCopyResult(FileCopyResultStatus.Error)
                {
                    ErrorMessage = "The destination directory path does not exist"
                };
            }

            // Make sure we're allowed to overwrite if it will be needed
            if (!OverwiteDestinationPath && File.Exists(DestinationFilePath))
            {
                return new FileCopyResult(FileCopyResultStatus.Error)
                {
                    ErrorMessage = "The destination file already exists"
                };
            }

            // Everything is valid so far. Call the child method
            return DoWork();
        }

        // Overrides for children classes to implement
        protected abstract FileCopyResult DoWork();

        public static FileGetter Create(string sourceFilePath, string destinationFilePath)
        {
            ValidateInput(sourceFilePath, destinationFilePath);
            if (sourceFilePath.StartsWith("http"))
            {
                return new HttpFileGetter(sourceFilePath, destinationFilePath);
            }
            else
            {
                return new LocalFileGetter(sourceFilePath, destinationFilePath);
            }
        }

        #region Helpers

        private static void ValidateInput(string sourceFilePath, string destinationFilePath)
        {
            if (String.IsNullOrWhiteSpace(sourceFilePath))
            {
                throw new ArgumentException("Cannot have a blank source file path");
            }
            if (String.IsNullOrWhiteSpace(destinationFilePath))
            {
                throw new ArgumentException("Cannot have a blank destination file path");
            }
        }

        #endregion
    }
}
