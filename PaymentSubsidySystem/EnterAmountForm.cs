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
        public PaymentSubsidyForm paymentSubsidyForm;

        public EnterAmountForm(PaymentSubsidyForm form)
        {
            InitializeComponent();

            paymentSubsidyForm = form;

            lblSubsidyCode.Text = paymentSubsidyForm.subsidyCode;
        }

        private void btnEnterAmountCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnnterAmountOK_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterAmountAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Hide();
            }
        }

        private void EnterAmountForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Hide();
            }
        }
    }
}
