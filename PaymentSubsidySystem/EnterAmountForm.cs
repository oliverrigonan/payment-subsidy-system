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
        private Data.pos13DataContext db = new Data.pos13DataContext();

        public PaymentSubsidyForm paymentSubsidyForm;

        public EnterAmountForm(PaymentSubsidyForm form)
        {
            InitializeComponent();

            paymentSubsidyForm = form;

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

                var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                       where d.SubsidyCode.Equals(lblSubsidyCode.Text)
                                       select d;

                if (paymentSubsidies.Any())
                {
                    var updatePaymentSubsidy = paymentSubsidies.FirstOrDefault();
                    updatePaymentSubsidy.CreditAmount = amount;
                    updatePaymentSubsidy.TimeStamp = DateTime.Now;

                    db.SubmitChanges();

                    MessageBox.Show("Update successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Close();

                    paymentSubsidyForm.createPaymentSubsidyForm();

                    paymentSubsidyForm.subsidyCode = "";
                    paymentSubsidyForm.emptySubsidyCode();
                }
                else
                {
                    MessageBox.Show("Payment Subsidy code not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
