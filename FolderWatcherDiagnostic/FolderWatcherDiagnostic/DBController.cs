using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderWatcherDiagnostic
{
    class DBController
    {
        public bool CheckStatus(Job job)
        {
            if (job.jobType == "Renewal")
            {
                if (job.jobStatus == Properties.Settings.Default.RenewalAddedStatus)
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
                if (job.jobStatus == Properties.Settings.Default.EndorsementAddedStatus)
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
                if (job.jobStatus == Properties.Settings.Default.CancellationAddedStatus)
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
                if (job.jobStatus == Properties.Settings.Default.NewFastTrackAddedStatus)
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
                if (job.jobStatus == Properties.Settings.Default.NewStatus)
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

        public string GetJobStatusFromDB(string JobNo,string JobType)
        {
            string returnVal = "";
            OracleConnection con = new OracleConnection(Properties.Settings.Default.connectionString);
            OracleDataReader dr;
            string sql = "";
            if (JobType == "New")
            {
                sql = "select t.status from mnbq_proposal_upload t where t.quotation_no=:V_JOB_NUMBER";

            }
            else
            {
                sql = "select t.status from mnbq_proposal_upload t where t.job_number=:V_JOB_NUMBER";

            }
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.Parameters.Add(new OracleParameter("V_JOB_NUMBER", JobNo));
            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    returnVal = dr[0].ToString();
                    return returnVal;
                }
                else
                {
                    if (JobType == "New")
                    {
                        return "OK";
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (OracleException err)
            {
                throw new ApplicationException("Data error.");
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
