using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
        public LoginForm loginForm;

        public PaymentSubsidyForm(LoginForm form)
        {
            InitializeComponent();

            createPaymentSubsidyForm();
            ActiveControl = txtSubsidyCode;

            loginForm = form;

            lblCurrentUser.Text = loginForm.currentUser;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            Close();
        }

        public void createPaymentSubsidyForm()
        {
            try
            {
                dgvPaymentSubsidy.Rows.Clear();
                dgvPaymentSubsidy.Refresh();

                dgvPaymentSubsidy.Columns["DebitAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPaymentSubsidy.Columns["CreditAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPaymentSubsidy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DateTime currentDate = dtpDate.Value.Date;
                String searchString = txtSearch.Text;

                var paymentSubsidies = from d in db.TrnPaymentSubsidies.OrderByDescending(d => d.Id)
                                       where d.Date == currentDate
                                       && (d.SubsidyCode.Contains(searchString)
                                       || d.MstCustomer.Customer.Contains(searchString)
                                       || d.Particulars.Contains(searchString)
                                       || d.MstUser.FullName.Contains(searchString))
                                       select d;

                if (paymentSubsidies.Any())
                {
                    db.Refresh(RefreshMode.OverwriteCurrentValues, paymentSubsidies);

                    foreach (var paymentSubsidy in paymentSubsidies)
                    {
                        Debug.WriteLine(paymentSubsidy.SubsidyCode);
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
            dgvPaymentSubsidy.Refresh();

            if (dgvPaymentSubsidy.Rows.Count == 0)
            {
                createPaymentSubsidyForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPaymentSubsidy.Rows.Clear();
            dgvPaymentSubsidy.Refresh();

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
                dgvPaymentSubsidy.Refresh();

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
                    subsidyCode = paymentSubsidies.FirstOrDefault().SubsidyCode;

                    EnterAmountForm enterAmountForm = new EnterAmountForm(this);
                    enterAmountForm.ShowDialog();
                }
                else
                {
                    subsidyCode = "";

                    CustomerCodeForm customerCodeForm = new CustomerCodeForm(this, loginForm);
                    customerCodeForm.ShowDialog();
                }
            }
        }

        public void emptySubsidyCode()
        {
            txtSubsidyCode.Text = subsidyCode;
        }
    }
}
