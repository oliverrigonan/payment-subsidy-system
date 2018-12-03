using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentSubsidySystem
{
    public partial class PaymentSubsidyForm : Form
    {
        private Data.pos13DataContext db = new Data.pos13DataContext();
        public String subsidyCode = "";

        public PaymentSubsidyForm()
        {
            InitializeComponent();

            createPaymentSubsidyForm();
            ActiveControl = txtSubsidyCode;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            Hide();
        }

        public void createPaymentSubsidyForm()
        {
            try
            {
                dgvPaymentSubsidy.Columns["DebitAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPaymentSubsidy.Columns["CreditAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPaymentSubsidy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DateTime currentDate = dtpDate.Value.Date;
                String searchString = txtSearch.Text;

                var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                       where d.Date == currentDate
                                       && (d.SubsidyCode.Contains(searchString)
                                       || d.MstCustomer.Customer.Contains(searchString)
                                       || d.Particulars.Contains(searchString)
                                       || d.MstUser.FullName.Contains(searchString))
                                       select d;

                if (paymentSubsidies.Any())
                {
                    foreach (var paymentSubsidy in paymentSubsidies)
                    {
                        dgvPaymentSubsidy.Rows.Add(paymentSubsidy.TimeStamp, paymentSubsidy.SubsidyCode, paymentSubsidy.MstCustomer.Customer, paymentSubsidy.DebitAmount.ToString("#,##0.00"), paymentSubsidy.CreditAmount.ToString("#,##0.00"), paymentSubsidy.Particulars, paymentSubsidy.MstUser.FullName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dgvPaymentSubsidy.Rows.Clear();

            if (dgvPaymentSubsidy.Rows.Count == 0)
            {
                createPaymentSubsidyForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPaymentSubsidy.Rows.Clear();

            if (dgvPaymentSubsidy.Rows.Count == 0)
            {
                createPaymentSubsidyForm();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dgvPaymentSubsidy.Rows.Clear();

                if (dgvPaymentSubsidy.Rows.Count == 0)
                {
                    createPaymentSubsidyForm();
                }
            }
        }

        private void txtSubsidyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                DateTime currentDate = dtpDate.Value.Date;
                String subsidyCodeString = txtSubsidyCode.Text;

                var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                       where d.Date == currentDate
                                       && d.SubsidyCode.Equals(subsidyCodeString)
                                       select d;

                if (paymentSubsidies.Any())
                {
                    subsidyCode = txtSubsidyCode.Text;

                    EnterAmountForm enterAmountForm = new EnterAmountForm(this);
                    enterAmountForm.ShowDialog();
                }
                else
                {
                    CustomerCodeForm customerCodeForm = new CustomerCodeForm();
                    customerCodeForm.ShowDialog();
                }
            }
        }
    }
}
