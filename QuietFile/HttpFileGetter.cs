using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuietFile.Backend
{
    public class HttpFileGetter : FileGetter
    {
        public HttpFileGetter(string sourceFilePath, string destinationFilePath)
            : base(sourceFilePath, destinationFilePath)
        {

        }

        protected override FileCopyResult DoWork()
        {
            if (!SourceFilePath.StartsWith("http"))
            {
                return new FileCopyResult(FileCopyResultStatus.Error)
                {
                    ErrorMessage = "The address specified is not a valid Net address"
                };
            }

            try
            {
                new WebClient().DownloadFile(SourceFilePath, DestinationFilePath);
                return new FileCopyResult(FileCopyResultStatus.Success);
            }
            catch (Exception e)
            {
                return new FileCopyResult(FileCopyResultStatus.Error) { ErrorMessage = e.Message };
            }
        }
    }
}
