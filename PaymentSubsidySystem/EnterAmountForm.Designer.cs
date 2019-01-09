namespace PaymentSubsidySystem
{
    partial class EnterAmountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterAmountForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterAmountCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnterAmountOK = new System.Windows.Forms.Button();
            this.txtEnterAmountAmount = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSubsidyCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterAmountBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Please enter amount below.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnterAmountCancel
            // 
            this.btnEnterAmountCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnEnterAmountCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterAmountCancel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEnterAmountCancel.ForeColor = System.Drawing.Color.White;
            this.btnEnterAmountCancel.Location = new System.Drawing.Point(418, 227);
            this.btnEnterAmountCancel.Name = "btnEnterAmountCancel";
            this.btnEnterAmountCancel.Size = new System.Drawing.Size(111, 51);
            this.btnEnterAmountCancel.TabIndex = 15;
            this.btnEnterAmountCancel.Text = "Cancel";
            this.btnEnterAmountCancel.UseVisualStyleBackColor = false;
            this.btnEnterAmountCancel.Click += new System.EventHandler(this.btnEnterAmountCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subsidy Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnterAmountOK
            // 
            this.btnEnterAmountOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnterAmountOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterAmountOK.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEnterAmountOK.ForeColor = System.Drawing.Color.White;
            this.btnEnterAmountOK.Location = new System.Drawing.Point(301, 227);
            this.btnEnterAmountOK.Name = "btnEnterAmountOK";
            this.btnEnterAmountOK.Size = new System.Drawing.Size(111, 51);
            this.btnEnterAmountOK.TabIndex = 13;
            this.btnEnterAmountOK.Text = "OK";
            this.btnEnterAmountOK.UseVisualStyleBackColor = false;
            this.btnEnterAmountOK.Click += new System.EventHandler(this.btnnterAmountOK_Click);
            // 
            // txtEnterAmountAmount
            // 
            this.txtEnterAmountAmount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEnterAmountAmount.Location = new System.Drawing.Point(157, 177);
            this.txtEnterAmountAmount.Name = "txtEnterAmountAmount";
            this.txtEnterAmountAmount.Size = new System.Drawing.Size(373, 32);
            this.txtEnterAmountAmount.TabIndex = 12;
            this.txtEnterAmountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEnterAmountAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterAmountAmount_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUsername.Location = new System.Drawing.Point(49, 180);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 23);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Amount:";
            // 
            // lblSubsidyCode
            // 
            this.lblSubsidyCode.AutoSize = true;
            this.lblSubsidyCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubsidyCode.Location = new System.Drawing.Point(152, 80);
            this.lblSubsidyCode.Name = "lblSubsidyCode";
            this.lblSubsidyCode.Size = new System.Drawing.Size(65, 19);
            this.lblSubsidyCode.TabIndex = 17;
            this.lblSubsidyCode.Text = "#Code";
            this.lblSubsidyCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 67);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Amount";
            // 
            // txtEnterAmountBalance
            // 
            this.txtEnterAmountBalance.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEnterAmountBalance.Location = new System.Drawing.Point(156, 138);
            this.txtEnterAmountBalance.Name = "txtEnterAmountBalance";
            this.txtEnterAmountBalance.ReadOnly = true;
            this.txtEnterAmountBalance.Size = new System.Drawing.Size(373, 32);
            this.txtEnterAmountBalance.TabIndex = 21;
            this.txtEnterAmountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(45, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Balance:";
            // 
            // EnterAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 290);
            this.Controls.Add(this.txtEnterAmountBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSubsidyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnterAmountCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnterAmountOK);
            this.Controls.Add(this.txtEnterAmountAmount);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterAmountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Amount";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterAmountForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterAmountCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterAmountOK;
        private System.Windows.Forms.TextBox txtEnterAmountAmount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSubsidyCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterAmountBalance;
        private System.Windows.Forms.Label label4;
    }
}