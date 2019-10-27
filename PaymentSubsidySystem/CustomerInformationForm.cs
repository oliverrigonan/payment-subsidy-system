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
using PaymentSubsidySystem.Entities;

namespace PaymentSubsidySystem
{
    public partial class CustomerInformationForm : Form
    {
        public Data.pos13DataContext db;
        public PaymentSubsidyForm paymentSubsidyForm;
        public LoginForm loginForm;

        public CustomerDetail customer;
        public DateTime date;

        public CustomerInformationForm(PaymentSubsidyForm form, LoginForm form1, CustomerDetail customerDetail, DateTime filterDate)
        {
            InitializeComponent();

            ActiveControl = txtAmount;

            paymentSubsidyForm = form;
            loginForm = form1;

            customer = new CustomerDetail
            {
                Id = customerDetail.Id,
                Code = customerDetail.Code,
                Customer = customerDetail.Customer,
                Department = customerDetail.Department,
                Balance = customerDetail.Balance,
                Amount = 0
            };

            date = filterDate;

            db = new Data.pos13DataContext(Settings.GetConnectionString());

            txtCustomerCode.Text = customer.Code;
            txtCustomer.Text = customer.Customer;
            txtCustomerAddress.Text = customer.Department;

            Decimal balance = customer.Balance;

            var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                   where d.SubsidyCode.Equals(customer.Code)
                                   && d.Date == date
                                   select d;

            if (paymentSubsidies.Any())
            {
                Decimal totalDebitAmount = paymentSubsidies.Sum(d => d.DebitAmount);
                Decimal totalCreditAmount = paymentSubsidies.Sum(d => d.CreditAmount);
                balance = totalDebitAmount - totalCreditAmount;
            }

            txtBalance.Text = balance.ToString("#,##0.00");

            btnCustomerDetailOK.Enabled = true;
            btnCustomerDetailCancel.Enabled = true;
        }

        public void refreshPaymentSubsidyForm()
        {
            paymentSubsidyForm.CreateDgvPaymentSubsidy();

            paymentSubsidyForm.subsidyCode = "";
            paymentSubsidyForm.emptySubsidyCode();
        }

        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                updateAmount();
            }
        }

        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                updateAmount();
            }
        }

        private void txtCustomerAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                updateAmount();
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                updateAmount();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                updateAmount();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCustomerDetailOK_Click(object sender, EventArgs e)
        {
            updateAmount();
        }

        private void btnCustomerDetailCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void updateAmount()
        {
            btnCustomerDetailOK.Enabled = false;
            btnCustomerDetailCancel.Enabled = false;

            if (txtAmount.Text == "")
            {
                btnCustomerDetailOK.Enabled = true;
                btnCustomerDetailCancel.Enabled = true;

                MessageBox.Show("Zero amount or empty field is not allowed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDecimal(txtAmount.Text) == 0)
            {
                btnCustomerDetailOK.Enabled = true;
                btnCustomerDetailCancel.Enabled = true;

                MessageBox.Show("Zero amount or empty field is not allowed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Decimal balance = Convert.ToDecimal(txtBalance.Text);
                Decimal amount = Convert.ToDecimal(txtAmount.Text);

                if (amount <= balance)
                {
                    var currentPaymentSubsidies = from d in db.TrnPaymentSubsidies
                                                  where d.Date == date
                                                  && d.SubsidyCode.Equals(customer.Code)
                                                  select d;

                    if (currentPaymentSubsidies.Any())
                    {
                        Data.TrnPaymentSubsidy newPaymentSubsidy = new Data.TrnPaymentSubsidy
                        {
                            CustomerId = customer.Id,
                            Date = date,
                            SubsidyCode = currentPaymentSubsidies.FirstOrDefault().SubsidyCode,
                            DebitAmount = 0,
                            CreditAmount = Convert.ToDecimal(txtAmount.Text),
                            Particulars = "",
                            UserId = loginForm.currentUserId,
                            TimeStamp = DateTime.Now
                        };

                        db.TrnPaymentSubsidies.InsertOnSubmit(newPaymentSubsidy);
                        db.SubmitChanges();
                    }
                    else
                    {
                        Data.TrnPaymentSubsidy newDebitPaymentSubsidy = new Data.TrnPaymentSubsidy
                        {
                            CustomerId = customer.Id,
                            Date = date,
                            SubsidyCode = customer.Code,
                            DebitAmount = customer.Balance,
                            CreditAmount = 0,
                            Particulars = "Initial Balance",
                            UserId = loginForm.currentUserId,
                            TimeStamp = DateTime.Now
                        };

                        Data.TrnPaymentSubsidy newCreditPaymentSubsidy = new Data.TrnPaymentSubsidy
                        {
                            CustomerId = customer.Id,
                            Date = date,
                            SubsidyCode = customer.Code,
                            DebitAmount = 0,
                            CreditAmount = Convert.ToDecimal(txtAmount.Text),
                            Particulars = "",
                            UserId = loginForm.currentUserId,
                            TimeStamp = DateTime.Now
                        };

                        db.TrnPaymentSubsidies.InsertOnSubmit(newDebitPaymentSubsidy);
                        db.TrnPaymentSubsidies.InsertOnSubmit(newCreditPaymentSubsidy);

                        db.SubmitChanges();
                    }

                    refreshPaymentSubsidyForm();
                    Close();
                }
                else
                {
                    btnCustomerDetailOK.Enabled = true;
                    btnCustomerDetailCancel.Enabled = true;

                    MessageBox.Show("The amount should not be greater than the current balance of the subsidy.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
