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
    public partial class EnterAmountForm : Form
    {
        private Data.pos13DataContext db;

        public PaymentSubsidyForm paymentSubsidyForm;
        public LoginForm loginForm;

        public EnterAmountForm(PaymentSubsidyForm form, LoginForm form1)
        {
            InitializeComponent();
            db = new Data.pos13DataContext(Settings.GetConnectionString());

            paymentSubsidyForm = form;
            loginForm = form1;

            lblSubsidyCode.Text = paymentSubsidyForm.subsidyCode;
        }

        private void btnEnterAmountCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnterAmountOK_Click(object sender, EventArgs e)
        {
            updateAmount();
        }

        public void updateAmount()
        {
            try
            {
                btnEnterAmountOK.Enabled = false;
                btnEnterAmountCancel.Enabled = false;

                Decimal amount = Convert.ToDecimal(txtEnterAmountAmount.Text);
                DateTime filterDate = paymentSubsidyForm.filterDate;

                var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                       where d.SubsidyCode.Equals(lblSubsidyCode.Text)
                                       && d.Date == filterDate
                                       select d;

                if (paymentSubsidies.Any())
                {
                    Decimal totalDebitAmount = paymentSubsidies.Sum(d => d.DebitAmount);
                    Decimal totalCreditAmount = paymentSubsidies.Sum(d => d.CreditAmount);

                    Decimal totalAmount = totalDebitAmount - totalCreditAmount;

                    if (amount <= totalAmount)
                    {
                        if (amount == 0)
                        {
                            MessageBox.Show("Zero amount is not allowed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            btnEnterAmountOK.Enabled = true;
                            btnEnterAmountCancel.Enabled = true;
                        }
                        else
                        {
                            Data.TrnPaymentSubsidy newPaymentSubsidy = new Data.TrnPaymentSubsidy
                            {
                                CustomerId = paymentSubsidies.FirstOrDefault().CustomerId,
                                Date = filterDate,
                                SubsidyCode = paymentSubsidies.FirstOrDefault().SubsidyCode,
                                DebitAmount = 0,
                                CreditAmount = amount,
                                Particulars = "",
                                UserId = loginForm.currentUserId,
                                TimeStamp = DateTime.Now
                            };

                            db.TrnPaymentSubsidies.InsertOnSubmit(newPaymentSubsidy);
                            db.SubmitChanges();

                            db.SubmitChanges();

                            Close();

                            paymentSubsidyForm.createPaymentSubsidyForm();

                            paymentSubsidyForm.subsidyCode = "";
                            paymentSubsidyForm.emptySubsidyCode();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The amount should not be greater than the current balance of the subsidy.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnEnterAmountOK.Enabled = true;
                        btnEnterAmountCancel.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Payment Subsidy code not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnEnterAmountOK.Enabled = true;
                    btnEnterAmountCancel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnEnterAmountOK.Enabled = true;
                btnEnterAmountCancel.Enabled = true;
            }
        }

        private void txtEnterAmountAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EnterAmountForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }
        }
    }
}
