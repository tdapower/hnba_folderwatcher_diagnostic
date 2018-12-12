namespace FolderWatcherDiagnostic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvEndorsement4 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvCancellation4 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvRenewal3 = new System.Windows.Forms.ListView();
            this.lvRenewal2 = new System.Windows.Forms.ListView();
            this.lvRenewal1 = new System.Windows.Forms.ListView();
            this.lvNew3 = new System.Windows.Forms.ListView();
            this.lvNew2 = new System.Windows.Forms.ListView();
            this.lvNew1 = new System.Windows.Forms.ListView();
            this.lvEndorsement3 = new System.Windows.Forms.ListView();
            this.lvEndorsement2 = new System.Windows.Forms.ListView();
            this.lvEndorsement1 = new System.Windows.Forms.ListView();
            this.lvCancellation3 = new System.Windows.Forms.ListView();
            this.lvCancellation2 = new System.Windows.Forms.ListView();
            this.lvCancellation1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvNew4 = new System.Windows.Forms.ListView();
            this.lvRenewal4 = new System.Windows.Forms.ListView();
            this.lblLastReprocessTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvNewFst1 = new System.Windows.Forms.ListView();
            this.lvNewFst2 = new System.Windows.Forms.ListView();
            this.lvNewFst3 = new System.Windows.Forms.ListView();
            this.lvNewFst4 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFileMessages = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.btnUnknown = new System.Windows.Forms.Button();
            this.btnReprocess = new System.Windows.Forms.Button();
            this.btnFindInQueued = new System.Windows.Forms.Button();
            this.cmbJobType = new System.Windows.Forms.ComboBox();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.lbFileNames = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txtAdminPwd = new System.Windows.Forms.TextBox();
            this.btnReprocessWithAdminPwd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 527);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Folder Summary View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(9, 468);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Message";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lvEndorsement4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lvCancellation4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvRenewal3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvRenewal2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lvRenewal1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvNew3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvNew2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lvNew1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvEndorsement3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvEndorsement2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lvEndorsement1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvCancellation3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvCancellation2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lvCancellation1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lvNew4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lvRenewal4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLastReprocessTime, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvNewFst1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvNewFst2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lvNewFst3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvNewFst4, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 448);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // lvEndorsement4
            // 
            this.lvEndorsement4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEndorsement4.Location = new System.Drawing.Point(182, 320);
            this.lvEndorsement4.Name = "lvEndorsement4";
            this.lvEndorsement4.Size = new System.Drawing.Size(173, 93);
            this.lvEndorsement4.SmallImageList = this.imageList1;
            this.lvEndorsement4.TabIndex = 19;
            this.lvEndorsement4.UseCompatibleStateImageBehavior = false;
            this.lvEndorsement4.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-icon-512x512.png");
            this.imageList1.Images.SetKeyName(1, "Filetype-Docs-icon.png");
            // 
            // lvCancellation4
            // 
            this.lvCancellation4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCancellation4.Location = new System.Drawing.Point(3, 320);
            this.lvCancellation4.Name = "lvCancellation4";
            this.lvCancellation4.Size = new System.Drawing.Size(173, 93);
            this.lvCancellation4.SmallImageList = this.imageList1;
            this.lvCancellation4.TabIndex = 18;
            this.lvCancellation4.UseCompatibleStateImageBehavior = false;
            this.lvCancellation4.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Renewal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "New";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Endorsement";
            // 
            // lvRenewal3
            // 
            this.lvRenewal3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRenewal3.Location = new System.Drawing.Point(540, 221);
            this.lvRenewal3.Name = "lvRenewal3";
            this.lvRenewal3.Size = new System.Drawing.Size(173, 93);
            this.lvRenewal3.SmallImageList = this.imageList1;
            this.lvRenewal3.TabIndex = 0;
            this.lvRenewal3.UseCompatibleStateImageBehavior = false;
            this.lvRenewal3.View = System.Windows.Forms.View.List;
            // 
            // lvRenewal2
            // 
            this.lvRenewal2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRenewal2.Location = new System.Drawing.Point(540, 122);
            this.lvRenewal2.Name = "lvRenewal2";
            this.lvRenewal2.Size = new System.Drawing.Size(173, 93);
            this.lvRenewal2.SmallImageList = this.imageList1;
            this.lvRenewal2.TabIndex = 0;
            this.lvRenewal2.UseCompatibleStateImageBehavior = false;
            this.lvRenewal2.View = System.Windows.Forms.View.List;
            // 
            // lvRenewal1
            // 
            this.lvRenewal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRenewal1.Location = new System.Drawing.Point(540, 23);
            this.lvRenewal1.Name = "lvRenewal1";
            this.lvRenewal1.Size = new System.Drawing.Size(173, 93);
            this.lvRenewal1.SmallImageList = this.imageList1;
            this.lvRenewal1.TabIndex = 0;
            this.lvRenewal1.UseCompatibleStateImageBehavior = false;
            this.lvRenewal1.View = System.Windows.Forms.View.List;
            // 
            // lvNew3
            // 
            this.lvNew3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNew3.Location = new System.Drawing.Point(361, 221);
            this.lvNew3.Name = "lvNew3";
            this.lvNew3.Size = new System.Drawing.Size(173, 93);
            this.lvNew3.SmallImageList = this.imageList1;
            this.lvNew3.TabIndex = 0;
            this.lvNew3.UseCompatibleStateImageBehavior = false;
            this.lvNew3.View = System.Windows.Forms.View.List;
            // 
            // lvNew2
            // 
            this.lvNew2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNew2.Location = new System.Drawing.Point(361, 122);
            this.lvNew2.Name = "lvNew2";
            this.lvNew2.Size = new System.Drawing.Size(173, 93);
            this.lvNew2.SmallImageList = this.imageList1;
            this.lvNew2.TabIndex = 0;
            this.lvNew2.UseCompatibleStateImageBehavior = false;
            this.lvNew2.View = System.Windows.Forms.View.List;
            // 
            // lvNew1
            // 
            this.lvNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNew1.Location = new System.Drawing.Point(361, 23);
            this.lvNew1.Name = "lvNew1";
            this.lvNew1.Size = new System.Drawing.Size(173, 93);
            this.lvNew1.SmallImageList = this.imageList1;
            this.lvNew1.TabIndex = 0;
            this.lvNew1.UseCompatibleStateImageBehavior = false;
            this.lvNew1.View = System.Windows.Forms.View.List;
            // 
            // lvEndorsement3
            // 
            this.lvEndorsement3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEndorsement3.Location = new System.Drawing.Point(182, 221);
            this.lvEndorsement3.Name = "lvEndorsement3";
            this.lvEndorsement3.Size = new System.Drawing.Size(173, 93);
            this.lvEndorsement3.SmallImageList = this.imageList1;
            this.lvEndorsement3.TabIndex = 0;
            this.lvEndorsement3.UseCompatibleStateImageBehavior = false;
            this.lvEndorsement3.View = System.Windows.Forms.View.List;
            // 
            // lvEndorsement2
            // 
            this.lvEndorsement2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEndorsement2.Location = new System.Drawing.Point(182, 122);
            this.lvEndorsement2.Name = "lvEndorsement2";
            this.lvEndorsement2.Size = new System.Drawing.Size(173, 93);
            this.lvEndorsement2.SmallImageList = this.imageList1;
            this.lvEndorsement2.TabIndex = 0;
            this.lvEndorsement2.UseCompatibleStateImageBehavior = false;
            this.lvEndorsement2.View = System.Windows.Forms.View.List;
            // 
            // lvEndorsement1
            // 
            this.lvEndorsement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEndorsement1.Location = new System.Drawing.Point(182, 23);
            this.lvEndorsement1.Name = "lvEndorsement1";
            this.lvEndorsement1.Size = new System.Drawing.Size(173, 93);
            this.lvEndorsement1.SmallImageList = this.imageList1;
            this.lvEndorsement1.TabIndex = 0;
            this.lvEndorsement1.UseCompatibleStateImageBehavior = false;
            this.lvEndorsement1.View = System.Windows.Forms.View.List;
            // 
            // lvCancellation3
            // 
            this.lvCancellation3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCancellation3.Location = new System.Drawing.Point(3, 221);
            this.lvCancellation3.Name = "lvCancellation3";
            this.lvCancellation3.Size = new System.Drawing.Size(173, 93);
            this.lvCancellation3.SmallImageList = this.imageList1;
            this.lvCancellation3.TabIndex = 0;
            this.lvCancellation3.UseCompatibleStateImageBehavior = false;
            this.lvCancellation3.View = System.Windows.Forms.View.List;
            // 
            // lvCancellation2
            // 
            this.lvCancellation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCancellation2.Location = new System.Drawing.Point(3, 122);
            this.lvCancellation2.Name = "lvCancellation2";
            this.lvCancellation2.Size = new System.Drawing.Size(173, 93);
            this.lvCancellation2.SmallImageList = this.imageList1;
            this.lvCancellation2.TabIndex = 0;
            this.lvCancellation2.UseCompatibleStateImageBehavior = false;
            this.lvCancellation2.View = System.Windows.Forms.View.List;
            // 
            // lvCancellation1
            // 
            this.lvCancellation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCancellation1.Location = new System.Drawing.Point(3, 23);
            this.lvCancellation1.Name = "lvCancellation1";
            this.lvCancellation1.Size = new System.Drawing.Size(173, 93);
            this.lvCancellation1.SmallImageList = this.imageList1;
            this.lvCancellation1.TabIndex = 0;
            this.lvCancellation1.UseCompatibleStateImageBehavior = false;
            this.lvCancellation1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cancellation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reprocess";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvNew4
            // 
            this.lvNew4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNew4.Location = new System.Drawing.Point(361, 320);
            this.lvNew4.Name = "lvNew4";
            this.lvNew4.Size = new System.Drawing.Size(173, 93);
            this.lvNew4.SmallImageList = this.imageList1;
            this.lvNew4.TabIndex = 20;
            this.lvNew4.UseCompatibleStateImageBehavior = false;
            this.lvNew4.View = System.Windows.Forms.View.List;
            // 
            // lvRenewal4
            // 
            this.lvRenewal4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRenewal4.Location = new System.Drawing.Point(540, 320);
            this.lvRenewal4.Name = "lvRenewal4";
            this.lvRenewal4.Size = new System.Drawing.Size(173, 93);
            this.lvRenewal4.SmallImageList = this.imageList1;
            this.lvRenewal4.TabIndex = 21;
            this.lvRenewal4.UseCompatibleStateImageBehavior = false;
            this.lvRenewal4.View = System.Windows.Forms.View.List;
            // 
            // lblLastReprocessTime
            // 
            this.lblLastReprocessTime.AutoSize = true;
            this.lblLastReprocessTime.Location = new System.Drawing.Point(361, 416);
            this.lblLastReprocessTime.Name = "lblLastReprocessTime";
            this.lblLastReprocessTime.Size = new System.Drawing.Size(0, 13);
            this.lblLastReprocessTime.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "New - Fast Track";
            // 
            // lvNewFst1
            // 
            this.lvNewFst1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewFst1.Location = new System.Drawing.Point(719, 23);
            this.lvNewFst1.Name = "lvNewFst1";
            this.lvNewFst1.Size = new System.Drawing.Size(177, 93);
            this.lvNewFst1.SmallImageList = this.imageList1;
            this.lvNewFst1.TabIndex = 24;
            this.lvNewFst1.UseCompatibleStateImageBehavior = false;
            this.lvNewFst1.View = System.Windows.Forms.View.List;
            // 
            // lvNewFst2
            // 
            this.lvNewFst2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewFst2.Location = new System.Drawing.Point(719, 122);
            this.lvNewFst2.Name = "lvNewFst2";
            this.lvNewFst2.Size = new System.Drawing.Size(177, 93);
            this.lvNewFst2.SmallImageList = this.imageList1;
            this.lvNewFst2.TabIndex = 25;
            this.lvNewFst2.UseCompatibleStateImageBehavior = false;
            this.lvNewFst2.View = System.Windows.Forms.View.List;
            // 
            // lvNewFst3
            // 
            this.lvNewFst3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewFst3.Location = new System.Drawing.Point(719, 221);
            this.lvNewFst3.Name = "lvNewFst3";
            this.lvNewFst3.Size = new System.Drawing.Size(177, 93);
            this.lvNewFst3.SmallImageList = this.imageList1;
            this.lvNewFst3.TabIndex = 26;
            this.lvNewFst3.UseCompatibleStateImageBehavior = false;
            this.lvNewFst3.View = System.Windows.Forms.View.List;
            // 
            // lvNewFst4
            // 
            this.lvNewFst4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewFst4.Location = new System.Drawing.Point(719, 320);
            this.lvNewFst4.Name = "lvNewFst4";
            this.lvNewFst4.Size = new System.Drawing.Size(177, 93);
            this.lvNewFst4.SmallImageList = this.imageList1;
            this.lvNewFst4.TabIndex = 27;
            this.lvNewFst4.UseCompatibleStateImageBehavior = false;
            this.lvNewFst4.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReprocessWithAdminPwd);
            this.tabPage2.Controls.Add(this.txtAdminPwd);
            this.tabPage2.Controls.Add(this.lblFileMessages);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnCheckStatus);
            this.tabPage2.Controls.Add(this.btnUnknown);
            this.tabPage2.Controls.Add(this.btnReprocess);
            this.tabPage2.Controls.Add(this.btnFindInQueued);
            this.tabPage2.Controls.Add(this.cmbJobType);
            this.tabPage2.Controls.Add(this.txtJobNumber);
            this.tabPage2.Controls.Add(this.lbFileNames);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Processor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFileMessages
            // 
            this.lblFileMessages.AutoSize = true;
            this.lblFileMessages.ForeColor = System.Drawing.Color.Red;
            this.lblFileMessages.Location = new System.Drawing.Point(22, 461);
            this.lblFileMessages.Name = "lblFileMessages";
            this.lblFileMessages.Size = new System.Drawing.Size(55, 13);
            this.lblFileMessages.TabIndex = 26;
            this.lblFileMessages.Text = "Messages";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Job Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Job Type";
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(625, 64);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(162, 33);
            this.btnCheckStatus.TabIndex = 23;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // btnUnknown
            // 
            this.btnUnknown.Location = new System.Drawing.Point(625, 146);
            this.btnUnknown.Name = "btnUnknown";
            this.btnUnknown.Size = new System.Drawing.Size(162, 35);
            this.btnUnknown.TabIndex = 22;
            this.btnUnknown.Text = "Veiw files in Unknown ";
            this.btnUnknown.UseVisualStyleBackColor = true;
            this.btnUnknown.Click += new System.EventHandler(this.btnUnknown_Click);
            // 
            // btnReprocess
            // 
            this.btnReprocess.Location = new System.Drawing.Point(625, 106);
            this.btnReprocess.Name = "btnReprocess";
            this.btnReprocess.Size = new System.Drawing.Size(162, 34);
            this.btnReprocess.TabIndex = 21;
            this.btnReprocess.Text = "Re-Process";
            this.btnReprocess.UseVisualStyleBackColor = true;
            this.btnReprocess.Click += new System.EventHandler(this.btnReprocess_Click);
            // 
            // btnFindInQueued
            // 
            this.btnFindInQueued.Location = new System.Drawing.Point(625, 19);
            this.btnFindInQueued.Name = "btnFindInQueued";
            this.btnFindInQueued.Size = new System.Drawing.Size(162, 39);
            this.btnFindInQueued.TabIndex = 20;
            this.btnFindInQueued.Text = "Find in Queued";
            this.btnFindInQueued.UseVisualStyleBackColor = true;
            this.btnFindInQueued.Click += new System.EventHandler(this.btnFindInQueued_Click);
            // 
            // cmbJobType
            // 
            this.cmbJobType.FormattingEnabled = true;
            this.cmbJobType.Items.AddRange(new object[] {
            "New",
            "Renewal",
            "Endorsement",
            "Cancellation",
            "New Fast Track"});
            this.cmbJobType.Location = new System.Drawing.Point(138, 52);
            this.cmbJobType.Name = "cmbJobType";
            this.cmbJobType.Size = new System.Drawing.Size(214, 21);
            this.cmbJobType.TabIndex = 19;
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.Location = new System.Drawing.Point(138, 26);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(214, 20);
            this.txtJobNumber.TabIndex = 18;
            // 
            // lbFileNames
            // 
            this.lbFileNames.FormattingEnabled = true;
            this.lbFileNames.Location = new System.Drawing.Point(56, 91);
            this.lbFileNames.Name = "lbFileNames";
            this.lbFileNames.Size = new System.Drawing.Size(296, 355);
            this.lbFileNames.TabIndex = 17;
            this.lbFileNames.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 180000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txtAdminPwd
            // 
            this.txtAdminPwd.Location = new System.Drawing.Point(624, 259);
            this.txtAdminPwd.Name = "txtAdminPwd";
            this.txtAdminPwd.PasswordChar = '.';
            this.txtAdminPwd.Size = new System.Drawing.Size(162, 20);
            this.txtAdminPwd.TabIndex = 27;
            // 
            // btnReprocessWithAdminPwd
            // 
            this.btnReprocessWithAdminPwd.Location = new System.Drawing.Point(625, 220);
            this.btnReprocessWithAdminPwd.Name = "btnReprocessWithAdminPwd";
            this.btnReprocessWithAdminPwd.Size = new System.Drawing.Size(161, 33);
            this.btnReprocessWithAdminPwd.TabIndex = 28;
            this.btnReprocessWithAdminPwd.Text = "Reprocess For Admin";
            this.btnReprocessWithAdminPwd.UseVisualStyleBackColor = true;
            this.btnReprocessWithAdminPwd.Click += new System.EventHandler(this.btnReprocessWithAdminPwd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 536);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Folder Watcher Diagnostic";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCancellation1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvCancellation2;
        private System.Windows.Forms.ListView lvCancellation3;
        private System.Windows.Forms.ListView lvEndorsement1;
        private System.Windows.Forms.ListView lvNew1;
        private System.Windows.Forms.ListView lvRenewal1;
        private System.Windows.Forms.ListView lvEndorsement2;
        private System.Windows.Forms.ListView lvNew2;
        private System.Windows.Forms.ListView lvRenewal2;
        private System.Windows.Forms.ListView lvEndorsement3;
        private System.Windows.Forms.ListView lvNew3;
        private System.Windows.Forms.ListView lvRenewal3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lvEndorsement4;
        private System.Windows.Forms.ListView lvCancellation4;
        private System.Windows.Forms.ListView lvNew4;
        private System.Windows.Forms.ListView lvRenewal4;
        private System.Windows.Forms.Label lblLastReprocessTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvNewFst1;
        private System.Windows.Forms.ListView lvNewFst2;
        private System.Windows.Forms.ListView lvNewFst3;
        private System.Windows.Forms.ListView lvNewFst4;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbFileNames;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.ComboBox cmbJobType;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Button btnUnknown;
        private System.Windows.Forms.Button btnReprocess;
        private System.Windows.Forms.Button btnFindInQueued;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFileMessages;
        private System.Windows.Forms.TextBox txtAdminPwd;
        private System.Windows.Forms.Button btnReprocessWithAdminPwd;
    }
}