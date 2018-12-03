namespace PaymentSubsidySystem
{
    partial class CustomerCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerCodeForm));
            this.btnCustomerCodeOK = new System.Windows.Forms.Button();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomerCodeCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerCodeOK
            // 
            this.btnCustomerCodeOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerCodeOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerCodeOK.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCustomerCodeOK.ForeColor = System.Drawing.Color.White;
            this.btnCustomerCodeOK.Location = new System.Drawing.Point(302, 148);
            this.btnCustomerCodeOK.Name = "btnCustomerCodeOK";
            this.btnCustomerCodeOK.Size = new System.Drawing.Size(111, 51);
            this.btnCustomerCodeOK.TabIndex = 7;
            this.btnCustomerCodeOK.Text = "OK";
            this.btnCustomerCodeOK.UseVisualStyleBackColor = false;
            this.btnCustomerCodeOK.Click += new System.EventHandler(this.btnCustomerCodeOK_Click);
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCustomerCode.Location = new System.Drawing.Point(106, 88);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(424, 32);
            this.txtCustomerCode.TabIndex = 6;
            this.txtCustomerCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerCode_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUsername.Location = new System.Drawing.Point(12, 91);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 23);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subsidy code does not exist.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCustomerCodeCancel
            // 
            this.btnCustomerCodeCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCustomerCodeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerCodeCancel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCustomerCodeCancel.ForeColor = System.Drawing.Color.White;
            this.btnCustomerCodeCancel.Location = new System.Drawing.Point(419, 148);
            this.btnCustomerCodeCancel.Name = "btnCustomerCodeCancel";
            this.btnCustomerCodeCancel.Size = new System.Drawing.Size(111, 51);
            this.btnCustomerCodeCancel.TabIndex = 9;
            this.btnCustomerCodeCancel.Text = "Cancel";
            this.btnCustomerCodeCancel.UseVisualStyleBackColor = false;
            this.btnCustomerCodeCancel.Click += new System.EventHandler(this.btnCustomerCodeCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Please enter customer code below.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCustomerCodeCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerCodeOK);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 258);
            this.Name = "CustomerCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Code";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerCodeForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerCodeOK;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerCodeCancel;
        private System.Windows.Forms.Label label2;
    }
}