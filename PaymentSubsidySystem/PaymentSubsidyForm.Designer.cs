namespace PaymentSubsidySystem
{
    partial class PaymentSubsidyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSubsidyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateCSV = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaymentSubsidyDeveloper = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPaymentSubsidyVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPaymentSubsidySoftware = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSusidyCodeSearch = new System.Windows.Forms.Button();
            this.lblSubsidyCode = new System.Windows.Forms.Label();
            this.txtSubsidyCode = new System.Windows.Forms.TextBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPaymentSubsidy = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubsidyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonSalesListPageListFirst = new System.Windows.Forms.Button();
            this.buttonSalesListPageListNext = new System.Windows.Forms.Button();
            this.buttonSalesListPageListLast = new System.Windows.Forms.Button();
            this.buttonSalesListPageListPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentSubsidy)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnGenerateCSV);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 67);
            this.panel1.TabIndex = 6;
            // 
            // btnGenerateCSV
            // 
            this.btnGenerateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateCSV.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerateCSV.FlatAppearance.BorderSize = 0;
            this.btnGenerateCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCSV.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnGenerateCSV.ForeColor = System.Drawing.Color.White;
            this.btnGenerateCSV.Location = new System.Drawing.Point(1053, 12);
            this.btnGenerateCSV.Name = "btnGenerateCSV";
            this.btnGenerateCSV.Size = new System.Drawing.Size(101, 43);
            this.btnGenerateCSV.TabIndex = 12;
            this.btnGenerateCSV.Text = "CSV";
            this.btnGenerateCSV.UseVisualStyleBackColor = false;
            this.btnGenerateCSV.Click += new System.EventHandler(this.btnGenerateCSV_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(1160, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(101, 43);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1267, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 44);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Subsidy List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblPaymentSubsidyDeveloper);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblPaymentSubsidyVersion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblPaymentSubsidySoftware);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 94);
            this.panel2.TabIndex = 7;
            // 
            // lblPaymentSubsidyDeveloper
            // 
            this.lblPaymentSubsidyDeveloper.AutoSize = true;
            this.lblPaymentSubsidyDeveloper.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPaymentSubsidyDeveloper.Location = new System.Drawing.Point(194, 56);
            this.lblPaymentSubsidyDeveloper.Name = "lblPaymentSubsidyDeveloper";
            this.lblPaymentSubsidyDeveloper.Size = new System.Drawing.Size(148, 20);
            this.lblPaymentSubsidyDeveloper.TabIndex = 11;
            this.lblPaymentSubsidyDeveloper.Text = "Easyfis Corporation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(98, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Developer:";
            // 
            // lblPaymentSubsidyVersion
            // 
            this.lblPaymentSubsidyVersion.AutoSize = true;
            this.lblPaymentSubsidyVersion.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPaymentSubsidyVersion.Location = new System.Drawing.Point(171, 37);
            this.lblPaymentSubsidyVersion.Name = "lblPaymentSubsidyVersion";
            this.lblPaymentSubsidyVersion.Size = new System.Drawing.Size(122, 20);
            this.lblPaymentSubsidyVersion.TabIndex = 9;
            this.lblPaymentSubsidyVersion.Text = "1.20181204.NOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(98, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version:";
            // 
            // lblPaymentSubsidySoftware
            // 
            this.lblPaymentSubsidySoftware.AutoSize = true;
            this.lblPaymentSubsidySoftware.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentSubsidySoftware.Location = new System.Drawing.Point(98, 9);
            this.lblPaymentSubsidySoftware.Name = "lblPaymentSubsidySoftware";
            this.lblPaymentSubsidySoftware.Size = new System.Drawing.Size(212, 19);
            this.lblPaymentSubsidySoftware.TabIndex = 7;
            this.lblPaymentSubsidySoftware.Text = "Payment Subsidy System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 50);
            this.panel3.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1267, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 37);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(12, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(172, 30);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSearch.Location = new System.Drawing.Point(190, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1071, 30);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnSusidyCodeSearch);
            this.panel4.Controls.Add(this.lblSubsidyCode);
            this.panel4.Controls.Add(this.txtSubsidyCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 622);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1382, 65);
            this.panel4.TabIndex = 9;
            // 
            // btnSusidyCodeSearch
            // 
            this.btnSusidyCodeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSusidyCodeSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSusidyCodeSearch.FlatAppearance.BorderSize = 0;
            this.btnSusidyCodeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSusidyCodeSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSusidyCodeSearch.ForeColor = System.Drawing.Color.White;
            this.btnSusidyCodeSearch.Location = new System.Drawing.Point(1267, 12);
            this.btnSusidyCodeSearch.Name = "btnSusidyCodeSearch";
            this.btnSusidyCodeSearch.Size = new System.Drawing.Size(101, 43);
            this.btnSusidyCodeSearch.TabIndex = 13;
            this.btnSusidyCodeSearch.Text = "Search";
            this.btnSusidyCodeSearch.UseVisualStyleBackColor = false;
            this.btnSusidyCodeSearch.Click += new System.EventHandler(this.btnSusidyCodeSearch_Click);
            // 
            // lblSubsidyCode
            // 
            this.lblSubsidyCode.AutoSize = true;
            this.lblSubsidyCode.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubsidyCode.ForeColor = System.Drawing.Color.White;
            this.lblSubsidyCode.Location = new System.Drawing.Point(13, 19);
            this.lblSubsidyCode.Name = "lblSubsidyCode";
            this.lblSubsidyCode.Size = new System.Drawing.Size(180, 28);
            this.lblSubsidyCode.TabIndex = 10;
            this.lblSubsidyCode.Text = "Subsidy Code:";
            // 
            // txtSubsidyCode
            // 
            this.txtSubsidyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubsidyCode.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtSubsidyCode.Location = new System.Drawing.Point(218, 15);
            this.txtSubsidyCode.Name = "txtSubsidyCode";
            this.txtSubsidyCode.Size = new System.Drawing.Size(1043, 36);
            this.txtSubsidyCode.TabIndex = 10;
            this.txtSubsidyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubsidyCode_KeyPress);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCurrentUser.Location = new System.Drawing.Point(146, 11);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(131, 22);
            this.lblCurrentUser.TabIndex = 13;
            this.lblCurrentUser.Text = "#CurrentUser";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Current User:";
            // 
            // dgvPaymentSubsidy
            // 
            this.dgvPaymentSubsidy.AllowUserToAddRows = false;
            this.dgvPaymentSubsidy.AllowUserToDeleteRows = false;
            this.dgvPaymentSubsidy.AllowUserToResizeRows = false;
            this.dgvPaymentSubsidy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentSubsidy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPaymentSubsidy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentSubsidy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTimeStamp,
            this.ColumnSubsidyCode,
            this.ColumnCustomer,
            this.ColumnDebit,
            this.ColumnCredit,
            this.ColumnParticulars,
            this.ColumnUser});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentSubsidy.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPaymentSubsidy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentSubsidy.Location = new System.Drawing.Point(0, 117);
            this.dgvPaymentSubsidy.Name = "dgvPaymentSubsidy";
            this.dgvPaymentSubsidy.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentSubsidy.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPaymentSubsidy.RowHeadersVisible = false;
            this.dgvPaymentSubsidy.RowTemplate.Height = 24;
            this.dgvPaymentSubsidy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaymentSubsidy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentSubsidy.Size = new System.Drawing.Size(1382, 411);
            this.dgvPaymentSubsidy.TabIndex = 14;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "ColumnId";
            this.ColumnId.FillWeight = 57.84526F;
            this.ColumnId.HeaderText = "Tx No.";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnTimeStamp
            // 
            this.ColumnTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTimeStamp.DataPropertyName = "ColumnTimeStamp";
            this.ColumnTimeStamp.FillWeight = 110.8348F;
            this.ColumnTimeStamp.HeaderText = "Time Stamp";
            this.ColumnTimeStamp.Name = "ColumnTimeStamp";
            this.ColumnTimeStamp.ReadOnly = true;
            // 
            // ColumnSubsidyCode
            // 
            this.ColumnSubsidyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSubsidyCode.DataPropertyName = "ColumnSubsidyCode";
            this.ColumnSubsidyCode.FillWeight = 109.4062F;
            this.ColumnSubsidyCode.HeaderText = "Subsidy Code";
            this.ColumnSubsidyCode.Name = "ColumnSubsidyCode";
            this.ColumnSubsidyCode.ReadOnly = true;
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCustomer.DataPropertyName = "ColumnCustomer";
            this.ColumnCustomer.FillWeight = 106.9758F;
            this.ColumnCustomer.HeaderText = "Customer";
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.ReadOnly = true;
            // 
            // ColumnDebit
            // 
            this.ColumnDebit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDebit.DataPropertyName = "ColumnDebit";
            this.ColumnDebit.FillWeight = 105.4602F;
            this.ColumnDebit.HeaderText = "Debit";
            this.ColumnDebit.Name = "ColumnDebit";
            this.ColumnDebit.ReadOnly = true;
            // 
            // ColumnCredit
            // 
            this.ColumnCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCredit.DataPropertyName = "ColumnCredit";
            this.ColumnCredit.FillWeight = 104.0708F;
            this.ColumnCredit.HeaderText = "Credit";
            this.ColumnCredit.Name = "ColumnCredit";
            this.ColumnCredit.ReadOnly = true;
            // 
            // ColumnParticulars
            // 
            this.ColumnParticulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnParticulars.DataPropertyName = "ColumnParticulars";
            this.ColumnParticulars.FillWeight = 103.5104F;
            this.ColumnParticulars.HeaderText = "Particulars";
            this.ColumnParticulars.Name = "ColumnParticulars";
            this.ColumnParticulars.ReadOnly = true;
            // 
            // ColumnUser
            // 
            this.ColumnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUser.DataPropertyName = "ColumnUser";
            this.ColumnUser.FillWeight = 101.8966F;
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lblCurrentUser);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 578);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1382, 44);
            this.panel6.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.buttonSalesListPageListFirst);
            this.panel8.Controls.Add(this.buttonSalesListPageListNext);
            this.panel8.Controls.Add(this.buttonSalesListPageListLast);
            this.panel8.Controls.Add(this.buttonSalesListPageListPrevious);
            this.panel8.Controls.Add(this.textBoxPageNumber);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 528);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1382, 50);
            this.panel8.TabIndex = 20;
            // 
            // buttonSalesListPageListFirst
            // 
            this.buttonSalesListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListFirst.Enabled = false;
            this.buttonSalesListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListFirst.Location = new System.Drawing.Point(12, 9);
            this.buttonSalesListPageListFirst.Name = "buttonSalesListPageListFirst";
            this.buttonSalesListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListFirst.TabIndex = 8;
            this.buttonSalesListPageListFirst.Text = "First";
            this.buttonSalesListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListFirst.Click += new System.EventHandler(this.buttonSalesListPageListFirst_Click);
            // 
            // buttonSalesListPageListNext
            // 
            this.buttonSalesListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListNext.Location = new System.Drawing.Point(331, 9);
            this.buttonSalesListPageListNext.Name = "buttonSalesListPageListNext";
            this.buttonSalesListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListNext.TabIndex = 10;
            this.buttonSalesListPageListNext.Text = "Next";
            this.buttonSalesListPageListNext.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListNext.Click += new System.EventHandler(this.buttonSalesListPageListNext_Click);
            // 
            // buttonSalesListPageListLast
            // 
            this.buttonSalesListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListLast.Location = new System.Drawing.Point(418, 9);
            this.buttonSalesListPageListLast.Name = "buttonSalesListPageListLast";
            this.buttonSalesListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonSalesListPageListLast.TabIndex = 11;
            this.buttonSalesListPageListLast.Text = "Last";
            this.buttonSalesListPageListLast.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListLast.Click += new System.EventHandler(this.buttonSalesListPageListLast_Click);
            // 
            // buttonSalesListPageListPrevious
            // 
            this.buttonSalesListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalesListPageListPrevious.Enabled = false;
            this.buttonSalesListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonSalesListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonSalesListPageListPrevious.Location = new System.Drawing.Point(100, 9);
            this.buttonSalesListPageListPrevious.Name = "buttonSalesListPageListPrevious";
            this.buttonSalesListPageListPrevious.Size = new System.Drawing.Size(106, 32);
            this.buttonSalesListPageListPrevious.TabIndex = 9;
            this.buttonSalesListPageListPrevious.Text = "Previous";
            this.buttonSalesListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonSalesListPageListPrevious.Click += new System.EventHandler(this.buttonSalesListPageListPrevious_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Location = new System.Drawing.Point(235, 18);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(69, 15);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaymentSubsidyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 781);
            this.Controls.Add(this.dgvPaymentSubsidy);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 828);
            this.Name = "PaymentSubsidyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Subsidy List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentSubsidyForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentSubsidy)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaymentSubsidyDeveloper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPaymentSubsidyVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaymentSubsidySoftware;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSubsidyCode;
        private System.Windows.Forms.Label lblSubsidyCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataGridView dgvPaymentSubsidy;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGenerateCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubsidyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonSalesListPageListFirst;
        private System.Windows.Forms.Button buttonSalesListPageListNext;
        private System.Windows.Forms.Button buttonSalesListPageListLast;
        private System.Windows.Forms.Button buttonSalesListPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.Button btnSusidyCodeSearch;
    }
}