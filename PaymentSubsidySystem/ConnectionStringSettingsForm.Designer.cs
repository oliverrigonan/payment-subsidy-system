namespace PaymentSubsidySystem
{
    partial class ConnectionStringSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionStringSettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnectionStringSettingsClose = new System.Windows.Forms.Button();
            this.btnConnectionStringSettingsSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String Settings";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblConnectionString.Location = new System.Drawing.Point(15, 79);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(186, 23);
            this.lblConnectionString.TabIndex = 22;
            this.lblConnectionString.Text = "Connection String:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtConnectionString.Location = new System.Drawing.Point(232, 79);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(443, 111);
            this.txtConnectionString.TabIndex = 23;
            this.txtConnectionString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConnectionString_KeyPress);
            // 
            // btnConnectionStringSettingsClose
            // 
            this.btnConnectionStringSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectionStringSettingsClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnConnectionStringSettingsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectionStringSettingsClose.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnConnectionStringSettingsClose.ForeColor = System.Drawing.Color.White;
            this.btnConnectionStringSettingsClose.Location = new System.Drawing.Point(564, 197);
            this.btnConnectionStringSettingsClose.Name = "btnConnectionStringSettingsClose";
            this.btnConnectionStringSettingsClose.Size = new System.Drawing.Size(111, 51);
            this.btnConnectionStringSettingsClose.TabIndex = 25;
            this.btnConnectionStringSettingsClose.Text = "Close";
            this.btnConnectionStringSettingsClose.UseVisualStyleBackColor = false;
            this.btnConnectionStringSettingsClose.Click += new System.EventHandler(this.btnConnectionStringSettingsClose_Click);
            // 
            // btnConnectionStringSettingsSave
            // 
            this.btnConnectionStringSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectionStringSettingsSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConnectionStringSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectionStringSettingsSave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnConnectionStringSettingsSave.ForeColor = System.Drawing.Color.White;
            this.btnConnectionStringSettingsSave.Location = new System.Drawing.Point(447, 197);
            this.btnConnectionStringSettingsSave.Name = "btnConnectionStringSettingsSave";
            this.btnConnectionStringSettingsSave.Size = new System.Drawing.Size(111, 51);
            this.btnConnectionStringSettingsSave.TabIndex = 24;
            this.btnConnectionStringSettingsSave.Text = "Save";
            this.btnConnectionStringSettingsSave.UseVisualStyleBackColor = false;
            this.btnConnectionStringSettingsSave.Click += new System.EventHandler(this.btnConnectionStringSettingsSave_Click);
            // 
            // ConnectionStringSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(687, 260);
            this.Controls.Add(this.btnConnectionStringSettingsClose);
            this.Controls.Add(this.btnConnectionStringSettingsSave);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 307);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(705, 307);
            this.Name = "ConnectionStringSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection String Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnConnectionStringSettingsClose;
        private System.Windows.Forms.Button btnConnectionStringSettingsSave;
    }
}