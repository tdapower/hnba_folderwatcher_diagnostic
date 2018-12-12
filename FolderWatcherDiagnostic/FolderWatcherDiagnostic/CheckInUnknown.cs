using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderWatcherDiagnostic
{
    class CheckInUnknown
    {
        string UnknownDocsPath = Properties.Settings.Default.UnknownDocsPath;
     
        public String[] loadFilesToListBox(Job job)
        {
         
            string currentDate = "";
            currentDate = System.DateTime.Today.ToString("dd_MM_yyyy");

            string[] FolderList = null;
            if (job.jobType == "Renewal")
            {

                FolderList = Directory.GetFiles(UnknownDocsPath + @"\RENEWAL\" + currentDate);
                return FolderList;
            }
            else if (job.jobType == "New")
            {
                FolderList = Directory.GetFiles(UnknownDocsPath + @"\NEW\" + currentDate);
                return FolderList;
            }

            else if (job.jobType == "Endorsement")
            {
                String xx =UnknownDocsPath + @"\E\" + currentDate;
                FolderList = Directory.GetFiles(UnknownDocsPath + @"\ENDORSEMENT\" + currentDate);
                return FolderList;
            }
            else if (job.jobType == "Cancellation")
            {
                FolderList = Directory.GetFiles(UnknownDocsPath + @"\CANCELLATION\" + currentDate);
                return FolderList;
            }
            else if (job.jobType == "New Fast Track")
            {
                FolderList = Directory.GetFiles(UnknownDocsPath + @"\NEWFST\" + currentDate);
                return FolderList;
            }
            return FolderList;
        }
    }
}


