using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderWatcherDiagnostic
{
    class JobController
    {
        public bool CheckAvailabilty(Job job)
        {
          
            string QueuedDocsPath = Properties.Settings.Default.QueuedDocsPath;
            string JobFileName = job.jobNumber + ".pdf";


            if (job.jobType == "Renewal")
            {

                string JobFile = QueuedDocsPath + @"RENEWAL\" + job.jobNumber + @"\" + JobFileName;


                if (File.Exists(JobFile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (job.jobType == "New")
            {
                string JobFile = QueuedDocsPath + @"NEW\" + job.jobNumber + @"\" + JobFileName;


                if (File.Exists(JobFile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
           
            }
            else if (job.jobType == "Endorsement")
            {
                string JobFile = QueuedDocsPath + @"ENDORSEMENT\" + job.jobNumber + @"\" + JobFileName;


                if (File.Exists(JobFile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (job.jobType == "Cancellation")
            {
                string JobFile = QueuedDocsPath + @"CANCELLATION\" + job.jobNumber + @"\" + JobFileName;


                if (File.Exists(JobFile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (job.jobType == "New Fast Track")
            {
                string JobFile = QueuedDocsPath + @"NEWFST\" + job.jobNumber + @"\" + JobFileName;


                if (File.Exists(JobFile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}