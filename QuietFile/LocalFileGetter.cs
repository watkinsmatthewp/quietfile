using System;
using System.Diagnostics;
using System.IO;

namespace QuietFile.Backend
{
    public class LocalFileGetter : FileGetter
    {
        public LocalFileGetter(string sourceFilePath, string destinationFilePath) : base(sourceFilePath, destinationFilePath)
        {
            
        }

        protected override FileCopyResult DoWork()
        {
            // Make sure the source file exists
            if (!File.Exists(SourceFilePath))
            {
                return new FileCopyResult(FileCopyResultStatus.Error)
                {
                    ErrorMessage = "The source file does not exist"
                };
            }

            // Attempt the copy
            FileCopyResult result = new FileCopyResult(FileCopyResultStatus.None);
            Stopwatch clock = new Stopwatch();
            clock.Start();
            try
            {
                if (DeleteSourcePathAfterSuccess)
                {
                    File.Move(SourceFilePath, DestinationFilePath);
                }
                else
                {
                    File.Copy(SourceFilePath, DestinationFilePath, OverwiteDestinationPath);
                }
                
                result.Status = FileCopyResultStatus.Success;
            }
            catch (Exception e)
            {
                result.Status = FileCopyResultStatus.Error;
                result.ErrorMessage = e.Message;
            }
            finally
            {
                clock.Stop();
                result.Elapsed = clock.Elapsed;
            }

            // Return the results of our attempt
            return result;
        }
    }
}
