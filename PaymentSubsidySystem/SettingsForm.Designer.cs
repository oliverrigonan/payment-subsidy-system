namespace PaymentSubsidySystem
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnSettingsClose = new System.Windows.Forms.Button();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtSoftware = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnSettingsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsClose.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSettingsClose.ForeColor = System.Drawing.Color.White;
            this.btnSettingsClose.Location = new System.Drawing.Point(564, 317);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(111, 51);
            this.btnSettingsClose.TabIndex = 17;
            this.btnSettingsClose.Text = "Close";
            this.btnSettingsClose.UseVisualStyleBackColor = false;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsSave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSettingsSave.ForeColor = System.Drawing.Color.White;
            this.btnSettingsSave.Location = new System.Drawing.Point(447, 317);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(111, 51);
            this.btnSettingsSave.TabIndex = 16;
            this.btnSettingsSave.Text = "Save";
            this.btnSettingsSave.UseVisualStyleBackColor = false;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 67);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtConnectionString.Location = new System.Drawing.Point(232, 79);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(443, 111);
            this.txtConnectionString.TabIndex = 19;
            this.txtConnectionString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConnectionString_KeyPress);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblConnectionString.Location = new System.Drawing.Point(15, 79);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(186, 23);
            this.lblConnectionString.TabIndex = 20;
            this.lblConnectionString.Text = "Connection String:";
            // 
            // txtSoftware
            // 
            this.txtSoftware.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtSoftware.Location = new System.Drawing.Point(232, 196);
            this.txtSoftware.Name = "txtSoftware";
            this.txtSoftware.Size = new System.Drawing.Size(443, 32);
            this.txtSoftware.TabIndex = 21;
            this.txtSoftware.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoftware_KeyPress);
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtVersion.Location = new System.Drawing.Point(232, 234);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(443, 32);
            this.txtVersion.TabIndex = 22;
            this.txtVersion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVersion_KeyPress);
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDeveloper.Location = new System.Drawing.Point(232, 272);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(443, 32);
            this.txtDeveloper.TabIndex = 23;
            this.txtDeveloper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeveloper_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(99, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Software:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(116, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(81, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Developer:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtSoftware);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSettingsClose);
            this.Controls.Add(this.btnSettingsSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(705, 427);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsClose;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtSoftware;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}