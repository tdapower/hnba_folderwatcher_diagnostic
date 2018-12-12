using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderWatcherDiagnostic
{
    public partial class Form1 : Form
    {
        private string PathNewBusiness = @"E:\HNBGI\SCN_DOCS\NEW\";
        private string PathRenewal = @"E:\HNBGI\SCN_DOCS\RENEWAL\";
        private string PathEndorsement = @"E:\HNBGI\SCN_DOCS\ENDORSEMENT\";
        private string PathCancellation = @"E:\HNBGI\SCN_DOCS\CANCELLATION\";
        private string PathNewBusinessFST = @"E:\HNBGI\SCN_DOCS\NEWFST\";

        private string PathNewBusiness2 = @"E:\HNBGI\SCN_DOCS_2\NEW\";
        private string PathRenewal2 = @"E:\HNBGI\SCN_DOCS_2\RENEWAL\";
        private string PathEndorsement2 = @"E:\HNBGI\SCN_DOCS_2\ENDORSEMENT\";
        private string PathCancellation2 = @"E:\HNBGI\SCN_DOCS_2\CANCELLATION\";
        private string PathNewBusinessFST2 = @"E:\HNBGI\SCN_DOCS_2\NEWFST\";

        private string PathNewBusiness3 = @"E:\HNBGI\SCN_DOCS_3\NEW\";
        private string PathRenewal3 = @"E:\HNBGI\SCN_DOCS_3\RENEWAL\";
        private string PathEndorsement3 = @"E:\HNBGI\SCN_DOCS_3\ENDORSEMENT\";
        private string PathCancellation3 = @"E:\HNBGI\SCN_DOCS_3\CANCELLATION\";
        private string PathNewBusinessFST3 = @"E:\HNBGI\SCN_DOCS_3\NEWFST\";

        private string PathNewBusiness4 = @"E:\HNBGI\SCN_DOCS_4\NEW\";
        private string PathRenewal4 = @"E:\HNBGI\SCN_DOCS_4\RENEWAL\";
        private string PathEndorsement4 = @"E:\HNBGI\SCN_DOCS_4\ENDORSEMENT\";
        private string PathCancellation4 = @"E:\HNBGI\SCN_DOCS_4\CANCELLATION\";
        private string PathNewBusinessFST4 = @"E:\HNBGI\SCN_DOCS_4\NEWFST\";






        public Form1()
        {


            InitializeComponent();
            initializeWatchers();
            refresh();

            //tableLayoutPanel1.Width = this.Width - 25;
            //tableLayoutPanel1.Height = this.Height - 50;

        }



        private void initializeWatchers()
        {
            //New
            FileSystemWatcher NewBusinessWatcher = new FileSystemWatcher();
            NewBusinessWatcher.Path = @PathNewBusiness;
            NewBusinessWatcher.IncludeSubdirectories = true;
            NewBusinessWatcher.Created += new FileSystemEventHandler(refresh);
            NewBusinessWatcher.Deleted += new FileSystemEventHandler(refresh);
            NewBusinessWatcher.EnableRaisingEvents = true;

            FileSystemWatcher NewBusinessWatcher2 = new FileSystemWatcher();
            NewBusinessWatcher2.Path = @PathNewBusiness2;
            NewBusinessWatcher2.IncludeSubdirectories = true;
            NewBusinessWatcher2.Created += new FileSystemEventHandler(refresh);
            NewBusinessWatcher2.Deleted += new FileSystemEventHandler(refresh);
            NewBusinessWatcher2.EnableRaisingEvents = true;

            FileSystemWatcher NewBusinessWatcher3 = new FileSystemWatcher();
            NewBusinessWatcher3.Path = @PathNewBusiness3;
            NewBusinessWatcher3.IncludeSubdirectories = true;
            NewBusinessWatcher3.Created += new FileSystemEventHandler(refresh);
            NewBusinessWatcher3.Deleted += new FileSystemEventHandler(refresh);
            NewBusinessWatcher3.EnableRaisingEvents = true;


            //New - FST
            FileSystemWatcher NewBusinessFSTWatcher = new FileSystemWatcher();
            NewBusinessFSTWatcher.Path = @PathNewBusinessFST;
            NewBusinessFSTWatcher.IncludeSubdirectories = true;
            NewBusinessFSTWatcher.Created += new FileSystemEventHandler(refresh);
            NewBusinessFSTWatcher.Deleted += new FileSystemEventHandler(refresh);
            NewBusinessFSTWatcher.EnableRaisingEvents = true;

            FileSystemWatcher NewBusinessFSTWatcher2 = new FileSystemWatcher();
            NewBusinessFSTWatcher2.Path = @PathNewBusinessFST2;
            NewBusinessFSTWatcher2.IncludeSubdirectories = true;
            NewBusinessFSTWatcher2.Created += new FileSystemEventHandler(refresh);
            NewBusinessFSTWatcher2.Deleted += new FileSystemEventHandler(refresh);
            NewBusinessFSTWatcher2.EnableRaisingEvents = true;

            FileSystemWatcher NewBusinessFSTWatcher3 = new FileSystemWatcher();
            NewBusinessFSTWatcher3.Path = @PathNewBusinessFST3;
            NewBusinessFSTWatcher3.IncludeSubdirectories = true;
            NewBusinessFSTWatcher3.Created += new FileSystemEventHandler(refresh);
            NewBusinessFSTWatcher3.Deleted += new FileSystemEventHandler(refresh);
            NewBusinessFSTWatcher3.EnableRaisingEvents = true;


            //Renewal
            FileSystemWatcher RenewalWatcher = new FileSystemWatcher();
            RenewalWatcher.Path = @PathRenewal;
            RenewalWatcher.IncludeSubdirectories = true;
            RenewalWatcher.Created += new FileSystemEventHandler(refresh);
            RenewalWatcher.Deleted += new FileSystemEventHandler(refresh);
            RenewalWatcher.EnableRaisingEvents = true;

            FileSystemWatcher RenewalWatcher2 = new FileSystemWatcher();
            RenewalWatcher2.Path = @PathRenewal2;
            RenewalWatcher2.IncludeSubdirectories = true;
            RenewalWatcher2.Created += new FileSystemEventHandler(refresh);
            RenewalWatcher2.Deleted += new FileSystemEventHandler(refresh);
            RenewalWatcher2.EnableRaisingEvents = true;

            FileSystemWatcher RenewalWatcher3 = new FileSystemWatcher();
            RenewalWatcher3.Path = @PathRenewal3;
            RenewalWatcher3.IncludeSubdirectories = true;
            RenewalWatcher3.Created += new FileSystemEventHandler(refresh);
            RenewalWatcher3.Deleted += new FileSystemEventHandler(refresh);
            RenewalWatcher3.EnableRaisingEvents = true;

            //Endorsement
            FileSystemWatcher EndorsementlWatcher = new FileSystemWatcher();
            EndorsementlWatcher.Path = @PathEndorsement;
            EndorsementlWatcher.IncludeSubdirectories = true;
            EndorsementlWatcher.Created += new FileSystemEventHandler(refresh);
            EndorsementlWatcher.Deleted += new FileSystemEventHandler(refresh);
            EndorsementlWatcher.EnableRaisingEvents = true;

            FileSystemWatcher EndorsementlWatcher2 = new FileSystemWatcher();
            EndorsementlWatcher2.Path = @PathEndorsement2;
            EndorsementlWatcher2.IncludeSubdirectories = true;
            EndorsementlWatcher2.Created += new FileSystemEventHandler(refresh);
            EndorsementlWatcher2.Deleted += new FileSystemEventHandler(refresh);
            EndorsementlWatcher2.EnableRaisingEvents = true;

            FileSystemWatcher EndorsementlWatcher3 = new FileSystemWatcher();
            EndorsementlWatcher3.Path = @PathEndorsement3;
            EndorsementlWatcher3.IncludeSubdirectories = true;
            EndorsementlWatcher3.Created += new FileSystemEventHandler(refresh);
            EndorsementlWatcher3.Deleted += new FileSystemEventHandler(refresh);
            EndorsementlWatcher3.EnableRaisingEvents = true;


            //Cancellation
            FileSystemWatcher CancellationWatcher = new FileSystemWatcher();
            CancellationWatcher.Path = @PathCancellation;
            CancellationWatcher.IncludeSubdirectories = true;
            CancellationWatcher.Created += new FileSystemEventHandler(refresh);
            CancellationWatcher.Deleted += new FileSystemEventHandler(refresh);
            CancellationWatcher.EnableRaisingEvents = true;

            FileSystemWatcher CancellationWatcher2 = new FileSystemWatcher();
            CancellationWatcher2.Path = @PathCancellation2;
            CancellationWatcher2.IncludeSubdirectories = true;
            CancellationWatcher2.Created += new FileSystemEventHandler(refresh);
            CancellationWatcher2.Deleted += new FileSystemEventHandler(refresh);
            CancellationWatcher2.EnableRaisingEvents = true;

            FileSystemWatcher CancellationWatcher3 = new FileSystemWatcher();
            CancellationWatcher3.Path = @PathCancellation3;
            CancellationWatcher3.IncludeSubdirectories = true;
            CancellationWatcher3.Created += new FileSystemEventHandler(refresh);
            CancellationWatcher3.Deleted += new FileSystemEventHandler(refresh);
            CancellationWatcher3.EnableRaisingEvents = true;


        }

        private void refresh()
        {
            loadFiles(lvCancellation1, PathCancellation);
            loadFiles(lvCancellation2, PathCancellation2);
            loadFiles(lvCancellation3, PathCancellation3);
            loadFiles(lvCancellation4, PathCancellation4);

            loadFiles(lvEndorsement1, PathEndorsement);
            loadFiles(lvEndorsement2, PathEndorsement2);
            loadFiles(lvEndorsement3, PathEndorsement3);
            loadFiles(lvEndorsement4, PathEndorsement4);

            loadFiles(lvNew1, PathNewBusiness);
            loadFiles(lvNew2, PathNewBusiness2);
            loadFiles(lvNew3, PathNewBusiness3);
            loadFiles(lvNew4, PathNewBusiness4);

            loadFiles(lvRenewal1, PathRenewal);
            loadFiles(lvRenewal2, PathRenewal2);
            loadFiles(lvRenewal3, PathRenewal3);
            loadFiles(lvRenewal4, PathRenewal4);



            loadFiles(lvNewFst1, PathNewBusinessFST);
            loadFiles(lvNewFst2, PathNewBusinessFST2);
            loadFiles(lvNewFst3, PathNewBusinessFST3);
            loadFiles(lvNewFst4, PathNewBusinessFST4);

        }
        private void refresh(object sender, FileSystemEventArgs e)
        {
            loadFiles(lvCancellation1, PathCancellation);
            loadFiles(lvCancellation2, PathCancellation2);
            loadFiles(lvCancellation3, PathCancellation3);
            loadFiles(lvCancellation4, PathCancellation4);

            loadFiles(lvEndorsement1, PathEndorsement);
            loadFiles(lvEndorsement2, PathEndorsement2);
            loadFiles(lvEndorsement3, PathEndorsement3);
            loadFiles(lvEndorsement4, PathEndorsement4);

            loadFiles(lvNew1, PathNewBusiness);
            loadFiles(lvNew2, PathNewBusiness2);
            loadFiles(lvNew3, PathNewBusiness3);
            loadFiles(lvNew4, PathNewBusiness4);

            loadFiles(lvRenewal1, PathRenewal);
            loadFiles(lvRenewal2, PathRenewal2);
            loadFiles(lvRenewal3, PathRenewal3);
            loadFiles(lvRenewal4, PathRenewal4);



            loadFiles(lvNewFst1, PathNewBusinessFST);
            loadFiles(lvNewFst2, PathNewBusinessFST2);
            loadFiles(lvNewFst3, PathNewBusinessFST3);
            loadFiles(lvNewFst4, PathNewBusinessFST4);

        }

        private void loadFiles(ListView listvv, string location)
        {
            try
            {
                listvv.Items.Clear();
                DirectoryInfo nodeDirInfo = new DirectoryInfo(@location);
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                              {new ListViewItem.ListViewSubItem(item, "Directory"),
                   new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    listvv.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                              { new ListViewItem.ListViewSubItem(item, "File"),
                   new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    listvv.Items.Add(item);
                }

                lvCancellation1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                //lblMessage.Text = ee.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                delete4thFolders();


                reprocessCancellation();
                reprocessEndorsement();
                reprocessNew();
                reprocessRenewal();
                reprocessNewFST();

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }




            refresh();

            lblLastReprocessTime.Text = DateTime.Now.ToString();
        }


        private void reprocessCancellation()
        {
            try
            {
                DirectoryInfo nodeDirInfo1 = new DirectoryInfo(PathCancellation);
                DirectoryInfo nodeDirInfo2 = new DirectoryInfo(PathCancellation2);
                DirectoryInfo nodeDirInfo3 = new DirectoryInfo(PathCancellation3);


                foreach (FileInfo file in nodeDirInfo1.GetFiles())
                {
                    File.Move(file.FullName, @PathCancellation4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo2.GetFiles())
                {
                    File.Move(file.FullName, @PathCancellation4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo3.GetFiles())
                {
                    File.Move(file.FullName, @PathCancellation4 + @"\" + file.Name);
                }

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }
        }

        private void reprocessEndorsement()
        {
            try
            {
                DirectoryInfo nodeDirInfo1 = new DirectoryInfo(PathEndorsement);
                DirectoryInfo nodeDirInfo2 = new DirectoryInfo(PathEndorsement2);
                DirectoryInfo nodeDirInfo3 = new DirectoryInfo(PathEndorsement3);

                foreach (FileInfo file in nodeDirInfo1.GetFiles())
                {
                    File.Move(file.FullName, PathEndorsement4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo2.GetFiles())
                {
                    File.Move(file.FullName, PathEndorsement4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo3.GetFiles())
                {
                    File.Move(file.FullName, PathEndorsement4 + @"\" + file.Name);
                }

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }
        }

        private void reprocessNew()
        {
            try
            {
                DirectoryInfo nodeDirInfo1 = new DirectoryInfo(PathNewBusiness);
                DirectoryInfo nodeDirInfo2 = new DirectoryInfo(PathNewBusiness2);
                DirectoryInfo nodeDirInfo3 = new DirectoryInfo(PathNewBusiness3);

                foreach (FileInfo file in nodeDirInfo1.GetFiles())
                {
                    File.Move(file.FullName, @PathNewBusiness4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo2.GetFiles())
                {
                    File.Move(file.FullName, @PathNewBusiness4 + @"\" + file.Name);
                }

                foreach (FileInfo file in nodeDirInfo3.GetFiles())
                {
                    File.Move(file.FullName, @PathNewBusiness4 + @"\" + file.Name);
                }
            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }
        }

        private void reprocessRenewal()
        {
            try
            {
                DirectoryInfo nodeDirInfo1 = new DirectoryInfo(PathRenewal);
                DirectoryInfo nodeDirInfo2 = new DirectoryInfo(PathRenewal2);
                DirectoryInfo nodeDirInfo3 = new DirectoryInfo(PathRenewal3);

                foreach (FileInfo file in nodeDirInfo1.GetFiles())
                {
                    File.Move(file.FullName, @PathRenewal4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo2.GetFiles())
                {
                    File.Move(file.FullName, @PathRenewal4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo3.GetFiles())
                {
                    File.Move(file.FullName, @PathRenewal4 + @"\" + file.Name);
                }

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }
        }


        private void reprocessNewFST()
        {
            try
            {
                DirectoryInfo nodeDirInfo1 = new DirectoryInfo(PathNewBusinessFST);
                DirectoryInfo nodeDirInfo2 = new DirectoryInfo(PathNewBusinessFST2);
                DirectoryInfo nodeDirInfo3 = new DirectoryInfo(PathNewBusinessFST3);

                foreach (FileInfo file in nodeDirInfo1.GetFiles())
                {
                    File.Move(file.FullName, @PathNewBusinessFST4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo2.GetFiles())
                {
                    File.Move(file.FullName, @PathNewBusinessFST4 + @"\" + file.Name);
                }
                foreach (FileInfo file in nodeDirInfo3.GetFiles())
                {
                    File.Move(file.FullName, @PathNewBusinessFST4 + @"\" + file.Name);
                }

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }
        }



        private void delete4thFolders()
        {
            try
            {
                DirectoryInfo nodeDirInfo1 = new DirectoryInfo(PathNewBusiness4);
                DirectoryInfo nodeDirInfo2 = new DirectoryInfo(PathRenewal4);
                DirectoryInfo nodeDirInfo3 = new DirectoryInfo(PathEndorsement4);
                DirectoryInfo nodeDirInfo4 = new DirectoryInfo(PathCancellation4);
                DirectoryInfo nodeDirInfo5 = new DirectoryInfo(PathNewBusinessFST4);

                foreach (FileInfo file in nodeDirInfo1.GetFiles())
                {
                    File.Delete(file.FullName);
                }
                foreach (FileInfo file in nodeDirInfo2.GetFiles())
                {
                    File.Delete(file.FullName);
                }
                foreach (FileInfo file in nodeDirInfo3.GetFiles())
                {
                    File.Delete(file.FullName);
                }
                foreach (FileInfo file in nodeDirInfo4.GetFiles())
                {
                    File.Delete(file.FullName);
                }
                foreach (FileInfo file in nodeDirInfo5.GetFiles())
                {
                    File.Delete(file.FullName);
                }

            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

            //tableLayoutPanel1.Width = this.Width - 25;
            //tableLayoutPanel1.Height = this.Height - 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                delete4thFolders();

                reprocessCancellation();
                reprocessEndorsement();
                reprocessNew();
                reprocessRenewal();
                reprocessNewFST();
            }
            catch (Exception ee)
            {
                //eventLog1.Source = "mnbfwd_error";
                //eventLog1.WriteEntry(ee.ToString(), EventLogEntryType.Warning, 1000);
                lblMessage.Text = ee.ToString();
            }


            refresh();

            lblLastReprocessTime.Text = DateTime.Now.ToString();
        }

        void lvNew1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void lvNew1_DragEnter(object sender, DragEventArgs e)
        {
            lvNew1.Items.Add(e.Data.ToString());
        }

        private void btnFindInQueued_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtJobNumber.Text != "" && cmbJobType.Text != "")
                {
                    Job job = new Job();
                    job.jobNumber = txtJobNumber.Text;


                    job.jobType = cmbJobType.Text;

                    JobController jobController = new JobController();
                    bool ReturnVal = jobController.CheckAvailabilty(job);
                    if (jobController.CheckAvailabilty(job))
                    {
                        MessageBox.Show("File is Available in Queued folder");
                    }
                    else
                    {
                        MessageBox.Show("File is  Not Available in Queued folder");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all the required details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
            }
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtJobNumber.Text != "" && cmbJobType.Text != "")
                {
                    Job job = new Job();
                    job.jobNumber = txtJobNumber.Text;


                    job.jobType = cmbJobType.Text;

                    DBController dbController = new DBController();
                    String status = dbController.GetJobStatusFromDB(job.jobNumber, job.jobType);

                    if (status != null)
                    {
                        job.jobStatus = status;


                        if (dbController.CheckStatus(job))
                        {
                            MessageBox.Show("File Status is " + status + " and possible to re-process");
                        }
                        else
                        {
                            MessageBox.Show("File Status is " + status + " and not possible to re-process");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid job number");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all the required details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                lblFileMessages.Text = ex.ToString();
            }
        }

        private void btnReprocess_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtJobNumber.Text != "")
                {
                    var confirmationResult = MessageBox.Show("Are you sure that you would like to Re-process?", "Warning Re-processing",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                    if (confirmationResult == DialogResult.Yes)
                    {

                        Job job = new Job();
                        job.jobNumber = txtJobNumber.Text;


                        job.jobType = cmbJobType.Text;

                        DBController dbController = new DBController();
                        String status = dbController.GetJobStatusFromDB(job.jobNumber, job.jobType);

                        if (status != null)
                        {
                            job.jobStatus = status;


                            if (dbController.CheckStatus(job))
                            {
                                JobController jobController = new JobController();

                                if (jobController.CheckAvailabilty(job))
                                {
                                    ReprocessController reprocessController = new ReprocessController();

                                    if (reprocessController.MoveFolders(job))
                                    {
                                        MessageBox.Show("File sucessfully moved to Saved Folder");
                                    }
                                    else
                                    {
                                        MessageBox.Show("File is  Not Found in Queued folder");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("File is  Not Found in Queued folder");
                                }

                            }
                            else
                            {
                                MessageBox.Show("File Status is " + status + " and not possible to re-process");
                            }

                        }


                    }


                }
                else
                {
                    MessageBox.Show("Please enter all the required details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
            }
        }

        private void btnUnknown_Click(object sender, EventArgs e)
        {
            try
            {


                if (cmbJobType.Text != "")
                {
                    Job job = new Job();
                    job.jobNumber = txtJobNumber.Text;
                    job.jobType = cmbJobType.Text;

                    lbFileNames.Items.Clear();
                    lbFileNames.Visible = true;

                    CheckInUnknown checkInUnknown = new CheckInUnknown();
                    String[] FolderList = checkInUnknown.loadFilesToListBox(job);

                    foreach (string Folder in FolderList)
                    {
                        lbFileNames.Items.Add(Path.GetFileName(Folder));
                    }


                }
                else
                {
                    MessageBox.Show("Please select the file type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading files");
            }

        }

        private void btnReprocessWithAdminPwd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtJobNumber.Text != "")
                {
                    if (txtAdminPwd.Text == "tdapower")
                    {

                        var confirmationResult = MessageBox.Show("Are you sure that you would like to Re-process?", "Warning Re-processing",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                        if (confirmationResult == DialogResult.Yes)
                        {

                            Job job = new Job();
                            job.jobNumber = txtJobNumber.Text;


                            job.jobType = cmbJobType.Text;

                            DBController dbController = new DBController();
                            String status = dbController.GetJobStatusFromDB(job.jobNumber, job.jobType);

                            if (status != null)
                            {
                                job.jobStatus = status;


                                if (dbController.CheckStatus(job))
                                {
                                    JobController jobController = new JobController();

                                    if (jobController.CheckAvailabilty(job))
                                    {
                                        ReprocessController reprocessController = new ReprocessController();

                                        if (reprocessController.MoveFolders(job))
                                        {
                                            MessageBox.Show("File sucessfully moved to Saved Folder");
                                        }
                                        else
                                        {
                                            MessageBox.Show("File is  Not Found in Queued folder");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("File is  Not Found in Queued folder");
                                    }

                                }
                                else
                                {
                                    JobController jobController = new JobController();

                                    if (jobController.CheckAvailabilty(job))
                                    {
                                        ReprocessController reprocessController = new ReprocessController();

                                        if (reprocessController.MoveFolders(job))
                                        {
                                            MessageBox.Show("File sucessfully moved to Saved Folder");
                                        }
                                        else
                                        {
                                            MessageBox.Show("File is  Not Found in Queued folder");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("File is  Not Found in Queued folder");
                                    }


                                }

                            }


                        }


                    }
                    else
                    {
                        MessageBox.Show("Wrong admin password!");
                    }


                }
                else
                {
                    MessageBox.Show("Please enter all the required details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
            }

        }




    }
}
