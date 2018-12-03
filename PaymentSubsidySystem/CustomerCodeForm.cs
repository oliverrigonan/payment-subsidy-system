using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentSubsidySystem
{
    public partial class CustomerCodeForm : Form
    {
        private Data.pos13DataContext db = new Data.pos13DataContext();
        public PaymentSubsidyForm paymentSubsidyForm;
        public LoginForm loginForm;

        public CustomerCodeForm(PaymentSubsidyForm form, LoginForm form1)
        {
            InitializeComponent();

            paymentSubsidyForm = form;
            loginForm = form1;
        }

        private void btnCustomerCodeCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCustomerCodeOK_Click(object sender, EventArgs e)
        {
            addPaymentSubsidy();
        }

        public void addPaymentSubsidy()
        {
            try
            {
                btnCustomerCodeOK.Enabled = false;
                btnCustomerCodeCancel.Enabled = false;

                String customerCode = txtCustomerCode.Text;

                var customer = from d in db.MstCustomers
                               where d.CustomerCode.Equals(customerCode)
                               select d;

                if (customer.Any())
                {
                    var defaultDebitAmount = from d in db.TrnPaymentSubsidySettings select d;

                    Data.TrnPaymentSubsidy newPaymentSubsidy = new Data.TrnPaymentSubsidy
                    {
                        CustomerId = customer.FirstOrDefault().Id,
                        Date = DateTime.Today,
                        SubsidyCode = "NA",
                        DebitAmount = defaultDebitAmount.FirstOrDefault().DefaultDebitAmount,
                        CreditAmount = 0,
                        Particulars = "Initial Balance",
                        UserId = loginForm.currentUserId,
                        TimeStamp = DateTime.Now
                    };

                    db.TrnPaymentSubsidies.InsertOnSubmit(newPaymentSubsidy);
                    db.SubmitChanges();

                    MessageBox.Show("Add successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();

                    paymentSubsidyForm.createPaymentSubsidyForm();

                    paymentSubsidyForm.subsidyCode = "";
                    paymentSubsidyForm.emptySubsidyCode();
                }
                else
                {
                    MessageBox.Show("Customer code not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnCustomerCodeOK.Enabled = true;
                    btnCustomerCodeCancel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnCustomerCodeOK.Enabled = true;
                btnCustomerCodeCancel.Enabled = true;
            }
        }

        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                addPaymentSubsidy();
            }
        }

        private void CustomerCodeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }
        }
    }
}
