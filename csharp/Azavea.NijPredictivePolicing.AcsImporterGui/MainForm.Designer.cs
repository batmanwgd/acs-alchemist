﻿namespace Azavea.NijPredictivePolicing.AcsAlchemistGui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtLogConsole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboIncludeEmptyGeom = new System.Windows.Forms.CheckBox();
            this.chkStripExtraGeoID = new System.Windows.Forms.CheckBox();
            this.chkPreserveJamValues = new System.Windows.Forms.CheckBox();
            this.txtBoundaryShpFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseBoundaryShpFile = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrjFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowsePrjFile = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFishnetEnvelopeFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFishnetEnvelopeFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFishnetCellSize = new System.Windows.Forms.TextBox();
            this.chkReplaceJob = new System.Windows.Forms.CheckBox();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJobFilePath = new System.Windows.Forms.TextBox();
            this.btnSaveMessageLog = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.cboSummaryLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdVariablesFile = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseVariableFile = new System.Windows.Forms.Button();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.txtVariableFilePath = new System.Windows.Forms.TextBox();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJobFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJobFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileJob = new System.Windows.Forms.SaveFileDialog();
            this.ofdExportBoundaryShp = new System.Windows.Forms.OpenFileDialog();
            this.openFileJob = new System.Windows.Forms.OpenFileDialog();
            this.txtMessageLogFilePath = new System.Windows.Forms.TextBox();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.ofdOutputProjection = new System.Windows.Forms.OpenFileDialog();
            this.ofdGridEnvelopeShp = new System.Windows.Forms.OpenFileDialog();
            this.saveFileMessageLog = new System.Windows.Forms.SaveFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseWorking = new System.Windows.Forms.Button();
            this.lblWorkingDir = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGridCellUnits = new System.Windows.Forms.Label();
            this.btnFishnet = new System.Windows.Forms.Button();
            this.btnShapefile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSRIDFile = new System.Windows.Forms.RadioButton();
            this.radioDefaultSRID = new System.Windows.Forms.RadioButton();
            this.cboProjections = new System.Windows.Forms.ComboBox();
            this.radioSRIDFromList = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fbdWorkingDir = new System.Windows.Forms.FolderBrowserDialog();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogConsole
            // 
            this.txtLogConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogConsole.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLogConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogConsole.Location = new System.Drawing.Point(481, 73);
            this.txtLogConsole.Multiline = true;
            this.txtLogConsole.Name = "txtLogConsole";
            this.txtLogConsole.ReadOnly = true;
            this.txtLogConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogConsole.Size = new System.Drawing.Size(426, 441);
            this.txtLogConsole.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "1. ACS Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "2. State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "3. Summary Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "4. Variable File";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboIncludeEmptyGeom);
            this.groupBox1.Controls.Add(this.chkStripExtraGeoID);
            this.groupBox1.Controls.Add(this.chkPreserveJamValues);
            this.groupBox1.Location = new System.Drawing.Point(300, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optional Parameters";
            // 
            // cboIncludeEmptyGeom
            // 
            this.cboIncludeEmptyGeom.AutoSize = true;
            this.cboIncludeEmptyGeom.Checked = true;
            this.cboIncludeEmptyGeom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboIncludeEmptyGeom.Location = new System.Drawing.Point(6, 74);
            this.cboIncludeEmptyGeom.Name = "cboIncludeEmptyGeom";
            this.cboIncludeEmptyGeom.Size = new System.Drawing.Size(139, 17);
            this.cboIncludeEmptyGeom.TabIndex = 2;
            this.cboIncludeEmptyGeom.Text = "Include Empty Polygons";
            this.cboIncludeEmptyGeom.UseVisualStyleBackColor = true;
            this.cboIncludeEmptyGeom.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // chkStripExtraGeoID
            // 
            this.chkStripExtraGeoID.AutoSize = true;
            this.chkStripExtraGeoID.Checked = true;
            this.chkStripExtraGeoID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStripExtraGeoID.Location = new System.Drawing.Point(6, 48);
            this.chkStripExtraGeoID.Name = "chkStripExtraGeoID";
            this.chkStripExtraGeoID.Size = new System.Drawing.Size(111, 17);
            this.chkStripExtraGeoID.TabIndex = 1;
            this.chkStripExtraGeoID.Text = "Strip Extra GEOID";
            this.chkStripExtraGeoID.UseVisualStyleBackColor = true;
            this.chkStripExtraGeoID.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // chkPreserveJamValues
            // 
            this.chkPreserveJamValues.AutoSize = true;
            this.chkPreserveJamValues.Checked = true;
            this.chkPreserveJamValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreserveJamValues.Location = new System.Drawing.Point(6, 23);
            this.chkPreserveJamValues.Name = "chkPreserveJamValues";
            this.chkPreserveJamValues.Size = new System.Drawing.Size(114, 17);
            this.chkPreserveJamValues.TabIndex = 0;
            this.chkPreserveJamValues.Text = "Preserve ACS Jam";
            this.chkPreserveJamValues.UseVisualStyleBackColor = true;
            this.chkPreserveJamValues.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // txtBoundaryShpFilePath
            // 
            this.txtBoundaryShpFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoundaryShpFilePath.Location = new System.Drawing.Point(54, 64);
            this.txtBoundaryShpFilePath.Name = "txtBoundaryShpFilePath";
            this.txtBoundaryShpFilePath.Size = new System.Drawing.Size(147, 22);
            this.txtBoundaryShpFilePath.TabIndex = 2;
            this.txtBoundaryShpFilePath.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // btnBrowseBoundaryShpFile
            // 
            this.btnBrowseBoundaryShpFile.Location = new System.Drawing.Point(207, 62);
            this.btnBrowseBoundaryShpFile.Name = "btnBrowseBoundaryShpFile";
            this.btnBrowseBoundaryShpFile.Size = new System.Drawing.Size(66, 25);
            this.btnBrowseBoundaryShpFile.TabIndex = 3;
            this.btnBrowseBoundaryShpFile.Text = "Browse";
            this.btnBrowseBoundaryShpFile.UseVisualStyleBackColor = true;
            this.btnBrowseBoundaryShpFile.Click += new System.EventHandler(this.btnBrowseBoundaryShpFile_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Clip to:";
            // 
            // txtPrjFilePath
            // 
            this.txtPrjFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPrjFilePath.Location = new System.Drawing.Point(82, 72);
            this.txtPrjFilePath.Name = "txtPrjFilePath";
            this.txtPrjFilePath.Size = new System.Drawing.Size(119, 22);
            this.txtPrjFilePath.TabIndex = 2;
            this.txtPrjFilePath.TextChanged += new System.EventHandler(this.general_TextChanged);
            this.txtPrjFilePath.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrjFilePath_Validating);
            // 
            // btnBrowsePrjFile
            // 
            this.btnBrowsePrjFile.Location = new System.Drawing.Point(207, 70);
            this.btnBrowsePrjFile.Name = "btnBrowsePrjFile";
            this.btnBrowsePrjFile.Size = new System.Drawing.Size(66, 25);
            this.btnBrowsePrjFile.TabIndex = 3;
            this.btnBrowsePrjFile.Text = "Browse";
            this.btnBrowsePrjFile.UseVisualStyleBackColor = true;
            this.btnBrowsePrjFile.Click += new System.EventHandler(this.btnBrowsePrjFile_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 14);
            this.label14.TabIndex = 36;
            this.label14.Text = "Align Grid To Envelope";
            // 
            // txtFishnetEnvelopeFilePath
            // 
            this.txtFishnetEnvelopeFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFishnetEnvelopeFilePath.Location = new System.Drawing.Point(13, 70);
            this.txtFishnetEnvelopeFilePath.Name = "txtFishnetEnvelopeFilePath";
            this.txtFishnetEnvelopeFilePath.Size = new System.Drawing.Size(188, 22);
            this.txtFishnetEnvelopeFilePath.TabIndex = 1;
            this.txtFishnetEnvelopeFilePath.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // btnBrowseFishnetEnvelopeFile
            // 
            this.btnBrowseFishnetEnvelopeFile.Location = new System.Drawing.Point(207, 67);
            this.btnBrowseFishnetEnvelopeFile.Name = "btnBrowseFishnetEnvelopeFile";
            this.btnBrowseFishnetEnvelopeFile.Size = new System.Drawing.Size(66, 25);
            this.btnBrowseFishnetEnvelopeFile.TabIndex = 2;
            this.btnBrowseFishnetEnvelopeFile.Text = "Browse";
            this.btnBrowseFishnetEnvelopeFile.UseVisualStyleBackColor = true;
            this.btnBrowseFishnetEnvelopeFile.Click += new System.EventHandler(this.btnBrowseFishnetEnvelopeFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 14);
            this.label13.TabIndex = 31;
            this.label13.Text = "Cell Size";
            // 
            // txtFishnetCellSize
            // 
            this.txtFishnetCellSize.BackColor = System.Drawing.Color.White;
            this.txtFishnetCellSize.Location = new System.Drawing.Point(67, 21);
            this.txtFishnetCellSize.Name = "txtFishnetCellSize";
            this.txtFishnetCellSize.Size = new System.Drawing.Size(54, 22);
            this.txtFishnetCellSize.TabIndex = 0;
            this.txtFishnetCellSize.TextChanged += new System.EventHandler(this.general_TextChanged);
            this.txtFishnetCellSize.Validating += new System.ComponentModel.CancelEventHandler(this.txtFishnetCellSize_Validating);
            // 
            // chkReplaceJob
            // 
            this.chkReplaceJob.AutoSize = true;
            this.chkReplaceJob.Checked = true;
            this.chkReplaceJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReplaceJob.Location = new System.Drawing.Point(193, 31);
            this.chkReplaceJob.Name = "chkReplaceJob";
            this.chkReplaceJob.Size = new System.Drawing.Size(71, 17);
            this.chkReplaceJob.TabIndex = 1;
            this.chkReplaceJob.Text = "Overwrite";
            this.chkReplaceJob.UseVisualStyleBackColor = true;
            this.chkReplaceJob.CheckedChanged += new System.EventHandler(this.general_CheckedChanged);
            // 
            // txtJobName
            // 
            this.txtJobName.BackColor = System.Drawing.Color.White;
            this.txtJobName.Location = new System.Drawing.Point(54, 29);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(133, 22);
            this.txtJobName.TabIndex = 0;
            this.txtJobName.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "Name:";
            // 
            // txtJobFilePath
            // 
            this.txtJobFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtJobFilePath.Location = new System.Drawing.Point(580, 20);
            this.txtJobFilePath.Name = "txtJobFilePath";
            this.txtJobFilePath.ReadOnly = true;
            this.txtJobFilePath.Size = new System.Drawing.Size(327, 22);
            this.txtJobFilePath.TabIndex = 10;
            this.txtJobFilePath.TabStop = false;
            // 
            // btnSaveMessageLog
            // 
            this.btnSaveMessageLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMessageLog.Location = new System.Drawing.Point(841, 518);
            this.btnSaveMessageLog.Name = "btnSaveMessageLog";
            this.btnSaveMessageLog.Size = new System.Drawing.Size(66, 25);
            this.btnSaveMessageLog.TabIndex = 15;
            this.btnSaveMessageLog.Text = "Browse";
            this.btnSaveMessageLog.UseVisualStyleBackColor = true;
            this.btnSaveMessageLog.Click += new System.EventHandler(this.btnSaveMessageLog_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Save Log File as";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(133, 21);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(124, 22);
            this.cboYear.TabIndex = 0;
            this.cboYear.SelectedValueChanged += new System.EventHandler(this.general_SelectedValueChanged);
            this.cboYear.Validating += new System.ComponentModel.CancelEventHandler(this.cboYear_Validating);
            // 
            // cboStates
            // 
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(133, 54);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(157, 22);
            this.cboStates.TabIndex = 1;
            this.cboStates.SelectedValueChanged += new System.EventHandler(this.general_SelectedValueChanged);
            this.cboStates.Validating += new System.ComponentModel.CancelEventHandler(this.cboStates_Validating);
            // 
            // cboSummaryLevel
            // 
            this.cboSummaryLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSummaryLevel.FormattingEnabled = true;
            this.cboSummaryLevel.Location = new System.Drawing.Point(133, 87);
            this.cboSummaryLevel.Name = "cboSummaryLevel";
            this.cboSummaryLevel.Size = new System.Drawing.Size(157, 22);
            this.cboSummaryLevel.TabIndex = 2;
            this.cboSummaryLevel.SelectedValueChanged += new System.EventHandler(this.general_SelectedValueChanged);
            this.cboSummaryLevel.Validating += new System.ComponentModel.CancelEventHandler(this.cboSummaryLevel_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "5. Output Directory";
            // 
            // ofdVariablesFile
            // 
            this.ofdVariablesFile.Filter = "Text Files (*.txt,*.vars)|*.txt;*.var;*.vars|All Files (*.*)|*.*";
            // 
            // btnBrowseVariableFile
            // 
            this.btnBrowseVariableFile.Location = new System.Drawing.Point(399, 118);
            this.btnBrowseVariableFile.Name = "btnBrowseVariableFile";
            this.btnBrowseVariableFile.Size = new System.Drawing.Size(66, 25);
            this.btnBrowseVariableFile.TabIndex = 4;
            this.btnBrowseVariableFile.Text = "Browse";
            this.btnBrowseVariableFile.UseVisualStyleBackColor = true;
            this.btnBrowseVariableFile.Click += new System.EventHandler(this.btnBrowseVariableFile_Click);
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(399, 151);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(66, 25);
            this.btnBrowseOutputFolder.TabIndex = 6;
            this.btnBrowseOutputFolder.Text = "Browse";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // txtVariableFilePath
            // 
            this.txtVariableFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVariableFilePath.Location = new System.Drawing.Point(133, 120);
            this.txtVariableFilePath.Name = "txtVariableFilePath";
            this.txtVariableFilePath.Size = new System.Drawing.Size(260, 22);
            this.txtVariableFilePath.TabIndex = 3;
            this.txtVariableFilePath.TextChanged += new System.EventHandler(this.general_TextChanged);
            this.txtVariableFilePath.Validating += new System.ComponentModel.CancelEventHandler(this.txtVariableFilePath_Validating);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutputDirectory.Location = new System.Drawing.Point(133, 153);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(260, 22);
            this.txtOutputDirectory.TabIndex = 5;
            this.txtOutputDirectory.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJobToolStripMenuItem,
            this.openJobFileToolStripMenuItem,
            this.saveJobFileToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newJobToolStripMenuItem
            // 
            this.newJobToolStripMenuItem.Name = "newJobToolStripMenuItem";
            this.newJobToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newJobToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.newJobToolStripMenuItem.Text = "&New Job";
            this.newJobToolStripMenuItem.Click += new System.EventHandler(this.newJobToolStripMenuItem_Click);
            // 
            // openJobFileToolStripMenuItem
            // 
            this.openJobFileToolStripMenuItem.Name = "openJobFileToolStripMenuItem";
            this.openJobFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openJobFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openJobFileToolStripMenuItem.Text = "Open Job File";
            this.openJobFileToolStripMenuItem.Click += new System.EventHandler(this.openJobFileToolStripMenuItem_Click);
            // 
            // saveJobFileToolStripMenuItem
            // 
            this.saveJobFileToolStripMenuItem.Name = "saveJobFileToolStripMenuItem";
            this.saveJobFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveJobFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveJobFileToolStripMenuItem.Text = "Save Job File";
            this.saveJobFileToolStripMenuItem.Click += new System.EventHandler(this.saveJobFileToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileJob
            // 
            this.saveFileJob.Filter = "Text files|*.txt|Job files|*.job";
            // 
            // ofdExportBoundaryShp
            // 
            this.ofdExportBoundaryShp.Filter = "Shapefile|*.shp";
            // 
            // openFileJob
            // 
            this.openFileJob.Filter = "Text files|*.txt|Job files|*.job";
            // 
            // txtMessageLogFilePath
            // 
            this.txtMessageLogFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageLogFilePath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMessageLogFilePath.Location = new System.Drawing.Point(597, 518);
            this.txtMessageLogFilePath.Name = "txtMessageLogFilePath";
            this.txtMessageLogFilePath.Size = new System.Drawing.Size(238, 22);
            this.txtMessageLogFilePath.TabIndex = 14;
            // 
            // pgbStatus
            // 
            this.pgbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbStatus.Location = new System.Drawing.Point(84, 545);
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(835, 25);
            this.pgbStatus.TabIndex = 24;
            // 
            // ofdOutputProjection
            // 
            this.ofdOutputProjection.Filter = "Projection Files (*.prj)|*.prj|All Files (*.*)|*.*";
            // 
            // ofdGridEnvelopeShp
            // 
            this.ofdGridEnvelopeShp.Filter = "Shapefile|*.shp";
            // 
            // saveFileMessageLog
            // 
            this.saveFileMessageLog.Filter = "Text files|*.txt|Log files|*.log";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(478, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Current Job File:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCancel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtWorkingDirectory);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnBrowseWorking);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblWorkingDir);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnFishnet);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnShapefile);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pgbStatus);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtOutputDirectory);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label15);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtVariableFilePath);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtJobFilePath);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnBrowseOutputFolder);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtMessageLogFilePath);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnBrowseVariableFile);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtLogConsole);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnSaveMessageLog);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cboSummaryLevel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label10);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cboStates);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.cboYear);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(919, 570);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(919, 594);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(3, 545);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWorkingDirectory.Location = new System.Drawing.Point(133, 186);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(260, 22);
            this.txtWorkingDirectory.TabIndex = 27;
            this.txtWorkingDirectory.TextChanged += new System.EventHandler(this.general_TextChanged);
            // 
            // btnBrowseWorking
            // 
            this.btnBrowseWorking.Location = new System.Drawing.Point(399, 184);
            this.btnBrowseWorking.Name = "btnBrowseWorking";
            this.btnBrowseWorking.Size = new System.Drawing.Size(66, 25);
            this.btnBrowseWorking.TabIndex = 28;
            this.btnBrowseWorking.Text = "Browse";
            this.btnBrowseWorking.UseVisualStyleBackColor = true;
            this.btnBrowseWorking.Click += new System.EventHandler(this.btnBrowseWorking_Click);
            // 
            // lblWorkingDir
            // 
            this.lblWorkingDir.AutoSize = true;
            this.lblWorkingDir.Location = new System.Drawing.Point(7, 189);
            this.lblWorkingDir.Name = "lblWorkingDir";
            this.lblWorkingDir.Size = new System.Drawing.Size(120, 14);
            this.lblWorkingDir.TabIndex = 29;
            this.lblWorkingDir.Text = "6. Working Directory";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowseBoundaryShpFile);
            this.groupBox4.Controls.Add(this.txtBoundaryShpFilePath);
            this.groupBox4.Controls.Add(this.txtJobName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.chkReplaceJob);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(10, 330);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox4.Size = new System.Drawing.Size(280, 95);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shapefile Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblGridCellUnits);
            this.groupBox3.Controls.Add(this.txtFishnetCellSize);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtFishnetEnvelopeFilePath);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnBrowseFishnetEnvelopeFile);
            this.groupBox3.Location = new System.Drawing.Point(10, 431);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox3.Size = new System.Drawing.Size(280, 98);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fishnet Options";
            // 
            // lblGridCellUnits
            // 
            this.lblGridCellUnits.AutoSize = true;
            this.lblGridCellUnits.Location = new System.Drawing.Point(127, 25);
            this.lblGridCellUnits.Name = "lblGridCellUnits";
            this.lblGridCellUnits.Size = new System.Drawing.Size(92, 14);
            this.lblGridCellUnits.TabIndex = 1;
            this.lblGridCellUnits.Text = "projection units";
            // 
            // btnFishnet
            // 
            this.btnFishnet.Location = new System.Drawing.Point(300, 476);
            this.btnFishnet.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnFishnet.Name = "btnFishnet";
            this.btnFishnet.Size = new System.Drawing.Size(153, 53);
            this.btnFishnet.TabIndex = 12;
            this.btnFishnet.Text = "Export To Fishnet / Gridded Shapefile";
            this.btnFishnet.UseVisualStyleBackColor = true;
            this.btnFishnet.Click += new System.EventHandler(this.btnFishnet_Click);
            // 
            // btnShapefile
            // 
            this.btnShapefile.Location = new System.Drawing.Point(300, 372);
            this.btnShapefile.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnShapefile.Name = "btnShapefile";
            this.btnShapefile.Size = new System.Drawing.Size(153, 53);
            this.btnShapefile.TabIndex = 11;
            this.btnShapefile.Text = "Export To Shapefile";
            this.btnShapefile.UseVisualStyleBackColor = true;
            this.btnShapefile.Click += new System.EventHandler(this.btnShapefile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSRIDFile);
            this.groupBox2.Controls.Add(this.radioDefaultSRID);
            this.groupBox2.Controls.Add(this.cboProjections);
            this.groupBox2.Controls.Add(this.btnBrowsePrjFile);
            this.groupBox2.Controls.Add(this.radioSRIDFromList);
            this.groupBox2.Controls.Add(this.txtPrjFilePath);
            this.groupBox2.Location = new System.Drawing.Point(10, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox2.Size = new System.Drawing.Size(280, 105);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Projection";
            // 
            // radioSRIDFile
            // 
            this.radioSRIDFile.AutoSize = true;
            this.radioSRIDFile.Location = new System.Drawing.Point(13, 73);
            this.radioSRIDFile.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.radioSRIDFile.Name = "radioSRIDFile";
            this.radioSRIDFile.Size = new System.Drawing.Size(64, 17);
            this.radioSRIDFile.TabIndex = 3;
            this.radioSRIDFile.TabStop = true;
            this.radioSRIDFile.Text = "PRJ File";
            this.radioSRIDFile.UseVisualStyleBackColor = true;
            this.radioSRIDFile.CheckedChanged += new System.EventHandler(this.radioSRIDFile_CheckedChanged);
            // 
            // radioDefaultSRID
            // 
            this.radioDefaultSRID.AutoSize = true;
            this.radioDefaultSRID.Checked = true;
            this.radioDefaultSRID.Location = new System.Drawing.Point(13, 22);
            this.radioDefaultSRID.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.radioDefaultSRID.Name = "radioDefaultSRID";
            this.radioDefaultSRID.Size = new System.Drawing.Size(180, 17);
            this.radioDefaultSRID.TabIndex = 0;
            this.radioDefaultSRID.TabStop = true;
            this.radioDefaultSRID.Text = "Default SRID (census projection)";
            this.radioDefaultSRID.UseVisualStyleBackColor = true;
            this.radioDefaultSRID.CheckedChanged += new System.EventHandler(this.radioDefaultSRID_CheckedChanged);
            // 
            // cboProjections
            // 
            this.cboProjections.FormattingEnabled = true;
            this.cboProjections.Location = new System.Drawing.Point(109, 45);
            this.cboProjections.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.cboProjections.Name = "cboProjections";
            this.cboProjections.Size = new System.Drawing.Size(92, 22);
            this.cboProjections.TabIndex = 1;
            this.cboProjections.SelectedIndexChanged += new System.EventHandler(this.cboProjections_SelectedIndexChanged);
            this.cboProjections.Validating += new System.ComponentModel.CancelEventHandler(this.cboProjections_Validating);
            // 
            // radioSRIDFromList
            // 
            this.radioSRIDFromList.AutoSize = true;
            this.radioSRIDFromList.Location = new System.Drawing.Point(13, 47);
            this.radioSRIDFromList.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.radioSRIDFromList.Name = "radioSRIDFromList";
            this.radioSRIDFromList.Size = new System.Drawing.Size(90, 17);
            this.radioSRIDFromList.TabIndex = 1;
            this.radioSRIDFromList.TabStop = true;
            this.radioSRIDFromList.Text = "Desired SRID";
            this.radioSRIDFromList.UseVisualStyleBackColor = true;
            this.radioSRIDFromList.CheckedChanged += new System.EventHandler(this.radioSRIDFromList_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOfflineToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // workOfflineToolStripMenuItem
            // 
            this.workOfflineToolStripMenuItem.Name = "workOfflineToolStripMenuItem";
            this.workOfflineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workOfflineToolStripMenuItem.Text = "Work &Offline";
            this.workOfflineToolStripMenuItem.Click += new System.EventHandler(this.workOfflineToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(919, 594);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ACS Alchemist";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.ComboBox cboSummaryLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserOutputDir;
        private System.Windows.Forms.OpenFileDialog ofdVariablesFile;
        private System.Windows.Forms.Button btnBrowseVariableFile;
        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.TextBox txtVariableFilePath;
        private System.Windows.Forms.TextBox txtPrjFilePath;
        private System.Windows.Forms.Button btnBrowsePrjFile;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.TextBox txtJobFilePath;
        private System.Windows.Forms.Button btnSaveMessageLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJobFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileJob;
        private System.Windows.Forms.TextBox txtBoundaryShpFilePath;
        private System.Windows.Forms.Button btnBrowseBoundaryShpFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog ofdExportBoundaryShp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFishnetCellSize;
        private System.Windows.Forms.CheckBox chkReplaceJob;
        private System.Windows.Forms.CheckBox chkPreserveJamValues;
        private System.Windows.Forms.OpenFileDialog openFileJob;
        private System.Windows.Forms.CheckBox chkStripExtraGeoID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFishnetEnvelopeFilePath;
        private System.Windows.Forms.Button btnBrowseFishnetEnvelopeFile;
        private System.Windows.Forms.ToolStripMenuItem saveJobFileToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMessageLogFilePath;
        private System.Windows.Forms.ProgressBar pgbStatus;
        private System.Windows.Forms.OpenFileDialog ofdOutputProjection;
        private System.Windows.Forms.OpenFileDialog ofdGridEnvelopeShp;
        private System.Windows.Forms.SaveFileDialog saveFileMessageLog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJobToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioDefaultSRID;
        private System.Windows.Forms.RadioButton radioSRIDFromList;
        private System.Windows.Forms.ComboBox cboProjections;
        private System.Windows.Forms.RadioButton radioSRIDFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFishnet;
        private System.Windows.Forms.Button btnShapefile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGridCellUnits;
        private System.Windows.Forms.CheckBox cboIncludeEmptyGeom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Button btnBrowseWorking;
        private System.Windows.Forms.Label lblWorkingDir;
        private System.Windows.Forms.FolderBrowserDialog fbdWorkingDir;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOfflineToolStripMenuItem;
    }
}
