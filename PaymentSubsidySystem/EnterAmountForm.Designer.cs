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
            this.btnnterAmountOK = new System.Windows.Forms.Button();
            this.txtEnterAmountAmount = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSubsidyCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(12, 40);
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
            this.btnEnterAmountCancel.Location = new System.Drawing.Point(419, 148);
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subsidary Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnnterAmountOK
            // 
            this.btnnterAmountOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnnterAmountOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnterAmountOK.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnnterAmountOK.ForeColor = System.Drawing.Color.White;
            this.btnnterAmountOK.Location = new System.Drawing.Point(302, 148);
            this.btnnterAmountOK.Name = "btnnterAmountOK";
            this.btnnterAmountOK.Size = new System.Drawing.Size(111, 51);
            this.btnnterAmountOK.TabIndex = 13;
            this.btnnterAmountOK.Text = "OK";
            this.btnnterAmountOK.UseVisualStyleBackColor = false;
            this.btnnterAmountOK.Click += new System.EventHandler(this.btnnterAmountOK_Click);
            // 
            // txtEnterAmountAmount
            // 
            this.txtEnterAmountAmount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEnterAmountAmount.Location = new System.Drawing.Point(141, 88);
            this.txtEnterAmountAmount.Name = "txtEnterAmountAmount";
            this.txtEnterAmountAmount.Size = new System.Drawing.Size(389, 32);
            this.txtEnterAmountAmount.TabIndex = 12;
            this.txtEnterAmountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEnterAmountAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterAmountAmount_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUsername.Location = new System.Drawing.Point(12, 91);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 23);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Amount:";
            // 
            // lblSubsidyCode
            // 
            this.lblSubsidyCode.AutoSize = true;
            this.lblSubsidyCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubsidyCode.Location = new System.Drawing.Point(170, 20);
            this.lblSubsidyCode.Name = "lblSubsidyCode";
            this.lblSubsidyCode.Size = new System.Drawing.Size(65, 19);
            this.lblSubsidyCode.TabIndex = 17;
            this.lblSubsidyCode.Text = "#Code";
            this.lblSubsidyCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EnterAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 211);
            this.Controls.Add(this.lblSubsidyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnterAmountCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnterAmountOK);
            this.Controls.Add(this.txtEnterAmountAmount);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 258);
            this.Name = "EnterAmountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Amount";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterAmountForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterAmountCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnterAmountOK;
        private System.Windows.Forms.TextBox txtEnterAmountAmount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSubsidyCode;
    }
}