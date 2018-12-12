using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderWatcherDiagnostic
{
    class ReprocessController
    {
        public bool MoveFolders(Job job)
        {
            String QueuedDocsPath = Properties.Settings.Default.QueuedDocsPath;
            String SavedDocsPath = Properties.Settings.Default.SavedDocsPath;
            string JobFileName = job.jobNumber + ".pdf";

            if (job.jobType == "Renewal")
            {
                string sourceFile = QueuedDocsPath + @"RENEWAL\" + job.jobNumber + @"\" + JobFileName;
                string destinationFile = SavedDocsPath + @"RENEWAL\" + JobFileName;

                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }
                System.IO.Directory.Move(sourceFile, destinationFile);


                return true;
            }


            else if (job.jobType == "Endorsement")
            {
                string sourceFile = QueuedDocsPath + @"ENDORSEMENT\" + job.jobNumber + @"\" + JobFileName;
                string destinationFile = SavedDocsPath + @"ENDORSEMENT\" + JobFileName;
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }
                System.IO.Directory.Move(sourceFile, destinationFile);
                return true;
            }

            else if (job.jobType == "Cancellation")
            {
                string sourceFile = QueuedDocsPath + @"CANCELLATION\" + job.jobNumber + @"\" + JobFileName;
                string destinationFile = SavedDocsPath + @"CANCELLATION\" + JobFileName;
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }
                System.IO.Directory.Move(sourceFile, destinationFile);
                return true;
            }
            else if (job.jobType == "New")
            {
                string sourceFile = QueuedDocsPath + @"NEW\" + job.jobNumber + @"\" + JobFileName;
                string destinationFile = SavedDocsPath + @"NEW\" + JobFileName;
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }
                System.IO.Directory.Move(sourceFile, destinationFile);
                return true;
            }
            else if (job.jobType == "New Fast Track")
            {
                string sourceFile = QueuedDocsPath + @"NEWFST\" + job.jobNumber + @"\" + JobFileName;
                string destinationFile = SavedDocsPath + @"NEWFST\" + JobFileName;
                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }
                System.IO.Directory.Move(sourceFile, destinationFile);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
