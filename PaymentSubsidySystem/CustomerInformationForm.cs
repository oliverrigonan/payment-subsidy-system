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
    public partial class CustomerInformationForm : Form
    {
        private Data.pos13DataContext db;
        public PaymentSubsidyForm paymentSubsidyForm;

        public CustomerInformationForm(PaymentSubsidyForm form, String subsidyCode, DateTime filterDate)
        {
            InitializeComponent();
            paymentSubsidyForm = form;

            db = new Data.pos13DataContext(Settings.GetConnectionString());

            var customer = from d in db.MstCustomers
                           where d.CustomerCode.Equals(subsidyCode)
                           select d;

            if (customer.Any())
            {
                txtCustomerCode.Text = customer.FirstOrDefault().CustomerCode;
                txtCustomer.Text = customer.FirstOrDefault().Customer;
                txtCustomerAddress.Text = customer.FirstOrDefault().Address;

                Decimal balance = 0;

                var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                       where d.SubsidyCode.Equals(subsidyCode)
                                       && d.Date == filterDate
                                       select d;

                if (paymentSubsidies.Any())
                {
                    Decimal totalDebitAmount = paymentSubsidies.Sum(d => d.DebitAmount);
                    Decimal totalCreditAmount = paymentSubsidies.Sum(d => d.CreditAmount);

                    balance = totalDebitAmount - totalCreditAmount;
                }

                txtBalance.Text = balance.ToString("#,##0.00");
            }
        }

        public void refreshPaymentSubsidyForm()
        {
            paymentSubsidyForm.createPaymentSubsidyForm();

            paymentSubsidyForm.subsidyCode = "";
            paymentSubsidyForm.emptySubsidyCode();
        }

        private void btnCustomerDetailOK_Click(object sender, EventArgs e)
        {
            refreshPaymentSubsidyForm();
            Close();
        }

        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refreshPaymentSubsidyForm();
                Close();
            }
        }

        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refreshPaymentSubsidyForm();
                Close();
            }
        }

        private void txtCustomerAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refreshPaymentSubsidyForm();
                Close();
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                refreshPaymentSubsidyForm();
                Close();
            }
        }
    }
}
