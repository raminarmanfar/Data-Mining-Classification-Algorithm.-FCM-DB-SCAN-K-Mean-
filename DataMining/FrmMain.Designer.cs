using System.Windows.Forms;

namespace DataMining
{
    partial class FrmMain
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
            if (MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToolNew = new System.Windows.Forms.ToolStripButton();
            this.btnToolImport = new System.Windows.Forms.ToolStripButton();
            this.btnToolExportData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolExecute = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolAbout = new System.Windows.Forms.ToolStripButton();
            this.btnToolExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GBSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudIterations = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudNumberOfClusters = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.rbAlgDBSCAN = new System.Windows.Forms.RadioButton();
            this.rbAlgFCM = new System.Windows.Forms.RadioButton();
            this.rbAlgKMean = new System.Windows.Forms.RadioButton();
            this.nudFuzzyExp = new System.Windows.Forms.NumericUpDown();
            this.nudEps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinPts = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbGivenInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvGiven = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCentroid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPtExport = new System.Windows.Forms.Button();
            this.btnPtImport = new System.Windows.Forms.Button();
            this.btnPtRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.lblDataCounts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.gbGraphArea = new System.Windows.Forms.GroupBox();
            this.pbDrawingSurface = new System.Windows.Forms.PictureBox();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurRow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurCol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbShowMethod = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfClusters)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuzzyExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPts)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbGivenInfo.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiven)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.gbResult.SuspendLayout();
            this.gbGraphArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingSurface)).BeginInit();
            this.gbTools.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolNew,
            this.btnToolImport,
            this.btnToolExportData,
            this.toolStripSeparator2,
            this.btnToolExecute,
            this.toolStripSeparator6,
            this.btnToolAbout,
            this.btnToolExit,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1199, 70);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnToolNew
            // 
            this.btnToolNew.Image = ((System.Drawing.Image)(resources.GetObject("btnToolNew.Image")));
            this.btnToolNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolNew.Name = "btnToolNew";
            this.btnToolNew.Size = new System.Drawing.Size(52, 67);
            this.btnToolNew.Text = "New";
            this.btnToolNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToolNew.Click += new System.EventHandler(this.btnToolNew_Click);
            // 
            // btnToolImport
            // 
            this.btnToolImport.Image = ((System.Drawing.Image)(resources.GetObject("btnToolImport.Image")));
            this.btnToolImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolImport.Name = "btnToolImport";
            this.btnToolImport.Size = new System.Drawing.Size(74, 67);
            this.btnToolImport.Text = "Import Data";
            this.btnToolImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToolImport.Click += new System.EventHandler(this.btnToolImport_Click);
            // 
            // btnToolExportData
            // 
            this.btnToolExportData.Image = ((System.Drawing.Image)(resources.GetObject("btnToolExportData.Image")));
            this.btnToolExportData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolExportData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolExportData.Name = "btnToolExportData";
            this.btnToolExportData.Size = new System.Drawing.Size(71, 67);
            this.btnToolExportData.Text = "Export Data";
            this.btnToolExportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToolExportData.Click += new System.EventHandler(this.btnPtExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // btnToolExecute
            // 
            this.btnToolExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnToolExecute.Image")));
            this.btnToolExecute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolExecute.Name = "btnToolExecute";
            this.btnToolExecute.Size = new System.Drawing.Size(108, 67);
            this.btnToolExecute.Text = "Execute Algorithm";
            this.btnToolExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToolExecute.Click += new System.EventHandler(this.btnToolExecute_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // btnToolAbout
            // 
            this.btnToolAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnToolAbout.Image")));
            this.btnToolAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolAbout.Name = "btnToolAbout";
            this.btnToolAbout.Size = new System.Drawing.Size(93, 67);
            this.btnToolAbout.Text = "About Program";
            this.btnToolAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToolAbout.Click += new System.EventHandler(this.btnToolAbout_Click);
            // 
            // btnToolExit
            // 
            this.btnToolExit.Image = ((System.Drawing.Image)(resources.GetObject("btnToolExit.Image")));
            this.btnToolExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolExit.Name = "btnToolExit";
            this.btnToolExit.Size = new System.Drawing.Size(52, 67);
            this.btnToolExit.Text = "Exit";
            this.btnToolExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToolExit.Click += new System.EventHandler(this.btnToolExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GBSettings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbTools, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1199, 520);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // GBSettings
            // 
            this.GBSettings.Controls.Add(this.tableLayoutPanel2);
            this.GBSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBSettings.Location = new System.Drawing.Point(5, 5);
            this.GBSettings.Name = "GBSettings";
            this.GBSettings.Size = new System.Drawing.Size(1189, 47);
            this.GBSettings.TabIndex = 1;
            this.GBSettings.TabStop = false;
            this.GBSettings.Text = "Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 13;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel2.Controls.Add(this.nudIterations, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudNumberOfClusters, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudFuzzyExp, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudEps, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudMinPts, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1183, 28);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // nudIterations
            // 
            this.nudIterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIterations.Enabled = false;
            this.nudIterations.Location = new System.Drawing.Point(914, 3);
            this.nudIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIterations.Name = "nudIterations";
            this.nudIterations.Size = new System.Drawing.Size(50, 20);
            this.nudIterations.TabIndex = 16;
            this.nudIterations.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(806, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Number of Iterations";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudNumberOfClusters
            // 
            this.nudNumberOfClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumberOfClusters.Location = new System.Drawing.Point(579, 3);
            this.nudNumberOfClusters.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNumberOfClusters.Name = "nudNumberOfClusters";
            this.nudNumberOfClusters.Size = new System.Drawing.Size(50, 20);
            this.nudNumberOfClusters.TabIndex = 12;
            this.nudNumberOfClusters.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfClusters.AutoSizeChanged += new System.EventHandler(this.btnToolExecute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Algorithm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.rbAlgDBSCAN, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.rbAlgFCM, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.rbAlgKMean, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(59, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 22);
            this.tableLayoutPanel8.TabIndex = 25;
            // 
            // rbAlgDBSCAN
            // 
            this.rbAlgDBSCAN.AutoSize = true;
            this.rbAlgDBSCAN.Checked = true;
            this.rbAlgDBSCAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAlgDBSCAN.Location = new System.Drawing.Point(3, 3);
            this.rbAlgDBSCAN.Name = "rbAlgDBSCAN";
            this.rbAlgDBSCAN.Size = new System.Drawing.Size(69, 16);
            this.rbAlgDBSCAN.TabIndex = 5;
            this.rbAlgDBSCAN.TabStop = true;
            this.rbAlgDBSCAN.Text = "DBSCAN";
            this.rbAlgDBSCAN.UseVisualStyleBackColor = true;
            this.rbAlgDBSCAN.CheckedChanged += new System.EventHandler(this.rbAlgDBSCAN_CheckedChanged);
            // 
            // rbAlgFCM
            // 
            this.rbAlgFCM.AutoSize = true;
            this.rbAlgFCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAlgFCM.Location = new System.Drawing.Point(146, 3);
            this.rbAlgFCM.Name = "rbAlgFCM";
            this.rbAlgFCM.Size = new System.Drawing.Size(51, 16);
            this.rbAlgFCM.TabIndex = 7;
            this.rbAlgFCM.Text = "FCM";
            this.rbAlgFCM.UseVisualStyleBackColor = true;
            this.rbAlgFCM.CheckedChanged += new System.EventHandler(this.rbAlgDBSCAN_CheckedChanged);
            // 
            // rbAlgKMean
            // 
            this.rbAlgKMean.AutoSize = true;
            this.rbAlgKMean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAlgKMean.Location = new System.Drawing.Point(78, 3);
            this.rbAlgKMean.Name = "rbAlgKMean";
            this.rbAlgKMean.Size = new System.Drawing.Size(62, 16);
            this.rbAlgKMean.TabIndex = 6;
            this.rbAlgKMean.Text = "K-Mean";
            this.rbAlgKMean.UseVisualStyleBackColor = true;
            this.rbAlgKMean.CheckedChanged += new System.EventHandler(this.rbAlgDBSCAN_CheckedChanged);
            // 
            // nudFuzzyExp
            // 
            this.nudFuzzyExp.DecimalPlaces = 2;
            this.nudFuzzyExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudFuzzyExp.Enabled = false;
            this.nudFuzzyExp.Location = new System.Drawing.Point(740, 3);
            this.nudFuzzyExp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFuzzyExp.Name = "nudFuzzyExp";
            this.nudFuzzyExp.Size = new System.Drawing.Size(60, 20);
            this.nudFuzzyExp.TabIndex = 14;
            this.nudFuzzyExp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudEps
            // 
            this.nudEps.DecimalPlaces = 2;
            this.nudEps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudEps.Location = new System.Drawing.Point(296, 3);
            this.nudEps.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEps.Name = "nudEps";
            this.nudEps.Size = new System.Drawing.Size(60, 20);
            this.nudEps.TabIndex = 8;
            this.nudEps.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudEps.AutoSizeChanged += new System.EventHandler(this.btnToolExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eps";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(362, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "MinPoints";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMinPts
            // 
            this.nudMinPts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMinPts.Location = new System.Drawing.Point(421, 3);
            this.nudMinPts.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinPts.Name = "nudMinPts";
            this.nudMinPts.Size = new System.Drawing.Size(50, 20);
            this.nudMinPts.TabIndex = 9;
            this.nudMinPts.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMinPts.AutoSizeChanged += new System.EventHandler(this.btnToolExecute_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(635, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fuzzy Exponent (m)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(477, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Number of Clusters";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.13373F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.86627F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.gbGraphArea, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1189, 399);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(825, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbGivenInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbResult);
            this.splitContainer1.Size = new System.Drawing.Size(361, 393);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbGivenInfo
            // 
            this.gbGivenInfo.Controls.Add(this.tableLayoutPanel5);
            this.gbGivenInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGivenInfo.Location = new System.Drawing.Point(0, 0);
            this.gbGivenInfo.Name = "gbGivenInfo";
            this.gbGivenInfo.Size = new System.Drawing.Size(361, 212);
            this.gbGivenInfo.TabIndex = 0;
            this.gbGivenInfo.TabStop = false;
            this.gbGivenInfo.Text = "Given Information";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dgvGiven, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(355, 193);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dgvGiven
            // 
            this.dgvGiven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.IsCentroid});
            this.dgvGiven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiven.Location = new System.Drawing.Point(4, 4);
            this.dgvGiven.MultiSelect = false;
            this.dgvGiven.Name = "dgvGiven";
            this.dgvGiven.Size = new System.Drawing.Size(347, 116);
            this.dgvGiven.TabIndex = 0;
            this.dgvGiven.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiven_CellValueChanged);
            // 
            // X
            // 
            dataGridViewCellStyle1.Format = "N0";
            this.X.DefaultCellStyle = dataGridViewCellStyle1;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.Y.DefaultCellStyle = dataGridViewCellStyle2;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            // 
            // IsCentroid
            // 
            this.IsCentroid.HeaderText = "Is Centroid ?";
            this.IsCentroid.Name = "IsCentroid";
            this.IsCentroid.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btnPtExport, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnPtImport, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnPtRefresh, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 153);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(347, 36);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btnPtExport
            // 
            this.btnPtExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPtExport.Location = new System.Drawing.Point(233, 3);
            this.btnPtExport.Name = "btnPtExport";
            this.btnPtExport.Size = new System.Drawing.Size(111, 30);
            this.btnPtExport.TabIndex = 4;
            this.btnPtExport.Text = "Export Data";
            this.btnPtExport.UseVisualStyleBackColor = true;
            this.btnPtExport.Click += new System.EventHandler(this.btnPtExport_Click);
            // 
            // btnPtImport
            // 
            this.btnPtImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPtImport.Location = new System.Drawing.Point(118, 3);
            this.btnPtImport.Name = "btnPtImport";
            this.btnPtImport.Size = new System.Drawing.Size(109, 30);
            this.btnPtImport.TabIndex = 2;
            this.btnPtImport.Text = "Import Data";
            this.btnPtImport.UseVisualStyleBackColor = true;
            this.btnPtImport.Click += new System.EventHandler(this.btnToolImport_Click);
            // 
            // btnPtRefresh
            // 
            this.btnPtRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPtRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnPtRefresh.Name = "btnPtRefresh";
            this.btnPtRefresh.Size = new System.Drawing.Size(109, 30);
            this.btnPtRefresh.TabIndex = 0;
            this.btnPtRefresh.Text = "Refresh";
            this.btnPtRefresh.UseVisualStyleBackColor = true;
            this.btnPtRefresh.Click += new System.EventHandler(this.btnPtRefresh_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.dgv1, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblDataCounts, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 127);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(347, 19);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(140, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(130, 13);
            this.dgv1.TabIndex = 1;
            this.dgv1.Visible = false;
            // 
            // lblDataCounts
            // 
            this.lblDataCounts.AutoSize = true;
            this.lblDataCounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCounts.ForeColor = System.Drawing.Color.Blue;
            this.lblDataCounts.Location = new System.Drawing.Point(119, 0);
            this.lblDataCounts.Name = "lblDataCounts";
            this.lblDataCounts.Size = new System.Drawing.Size(15, 19);
            this.lblDataCounts.TabIndex = 13;
            this.lblDataCounts.Text = "0";
            this.lblDataCounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Points";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Location = new System.Drawing.Point(0, 0);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(361, 177);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Results";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 16);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(355, 158);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            // 
            // gbGraphArea
            // 
            this.gbGraphArea.Controls.Add(this.pbDrawingSurface);
            this.gbGraphArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGraphArea.Location = new System.Drawing.Point(3, 3);
            this.gbGraphArea.Name = "gbGraphArea";
            this.gbGraphArea.Size = new System.Drawing.Size(816, 393);
            this.gbGraphArea.TabIndex = 2;
            this.gbGraphArea.TabStop = false;
            this.gbGraphArea.Text = "Drawing Area";
            // 
            // pbDrawingSurface
            // 
            this.pbDrawingSurface.BackColor = System.Drawing.Color.White;
            this.pbDrawingSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawingSurface.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbDrawingSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawingSurface.Location = new System.Drawing.Point(3, 16);
            this.pbDrawingSurface.Name = "pbDrawingSurface";
            this.pbDrawingSurface.Size = new System.Drawing.Size(810, 374);
            this.pbDrawingSurface.TabIndex = 0;
            this.pbDrawingSurface.TabStop = false;
            this.pbDrawingSurface.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDrawingArea_MouseClick);
            this.pbDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDrawingArea_MouseMove);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.tableLayoutPanel14);
            this.gbTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTools.Location = new System.Drawing.Point(5, 467);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(1189, 48);
            this.gbTools.TabIndex = 4;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 7;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.tbZoom, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel4, 6, 0);
            this.tableLayoutPanel14.Controls.Add(this.progressBar1, 5, 0);
            this.tableLayoutPanel14.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel14.Controls.Add(this.cbShowMethod, 3, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1183, 29);
            this.tableLayoutPanel14.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Zoom";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbZoom
            // 
            this.tbZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbZoom.Location = new System.Drawing.Point(43, 3);
            this.tbZoom.Maximum = 20;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(337, 23);
            this.tbZoom.TabIndex = 18;
            this.tbZoom.ValueChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblCurRow, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblCurCol, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(900, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(759, 23);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // lblCurRow
            // 
            this.lblCurRow.AutoSize = true;
            this.lblCurRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurRow.ForeColor = System.Drawing.Color.Black;
            this.lblCurRow.Location = new System.Drawing.Point(44, 0);
            this.lblCurRow.Name = "lblCurRow";
            this.lblCurRow.Size = new System.Drawing.Size(15, 23);
            this.lblCurRow.TabIndex = 12;
            this.lblCurRow.Text = "0";
            this.lblCurRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(65, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Col";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurCol
            // 
            this.lblCurCol.AutoSize = true;
            this.lblCurCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurCol.ForeColor = System.Drawing.Color.Black;
            this.lblCurCol.Location = new System.Drawing.Point(99, 0);
            this.lblCurCol.Name = "lblCurCol";
            this.lblCurCol.Size = new System.Drawing.Size(15, 23);
            this.lblCurCol.TabIndex = 14;
            this.lblCurCol.Text = "0";
            this.lblCurCol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Row";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(732, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(386, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "Display Method";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(678, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Progress";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbShowMethod
            // 
            this.cbShowMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbShowMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowMethod.FormattingEnabled = true;
            this.cbShowMethod.Items.AddRange(new object[] {
            "Show in computer coordinate order",
            "Show in mathematic coordinate order"});
            this.cbShowMethod.Location = new System.Drawing.Point(472, 3);
            this.cbShowMethod.Name = "cbShowMethod";
            this.cbShowMethod.Size = new System.Drawing.Size(200, 21);
            this.cbShowMethod.TabIndex = 27;
            this.cbShowMethod.SelectedIndexChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Data Mining";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfClusters)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuzzyExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPts)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbGivenInfo.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiven)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbGraphArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingSurface)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnToolAbout;
        private ToolStripButton btnToolExit;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox GBSettings;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label2;
        private NumericUpDown nudMinPts;
        private Label label1;
        private NumericUpDown nudEps;
        private RadioButton rbAlgDBSCAN;
        private RadioButton rbAlgKMean;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblCurRow;
        private Label label6;
        private Label lblCurCol;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private SplitContainer splitContainer1;
        private GroupBox gbGivenInfo;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dgvGiven;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnPtImport;
        private Button btnPtRefresh;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblDataCounts;
        private Label label5;
        private GroupBox gbResult;
        private TextBox txtResult;
        private GroupBox gbGraphArea;
        private PictureBox pbDrawingSurface;
        private ToolStripButton btnToolNew;
        private ToolStripButton btnToolImport;
        private ToolStripButton btnToolExecute;
        private ToolStripButton btnToolExportData;
        private RadioButton rbAlgFCM;
        private NumericUpDown nudNumberOfClusters;
        private Label label7;
        private Button btnPtExport;
        private DataGridView dgv1;
        private Label label8;
        private NumericUpDown nudFuzzyExp;
        private Label label9;
        private NumericUpDown nudIterations;
        private ToolStripSeparator toolStripSeparator5;
        private Label label10;
        private TrackBar tbZoom;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel14;
        private GroupBox gbTools;
        private Label label11;
        private ProgressBar progressBar1;
        private ToolStripSeparator toolStripSeparator6;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn Z;
        private DataGridViewCheckBoxColumn IsCentroid;
        private Label label12;
        private ComboBox cbShowMethod;
    }
}

