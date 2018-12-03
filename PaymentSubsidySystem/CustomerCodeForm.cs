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
        public CustomerCodeForm()
        {
            InitializeComponent();
        }

        private void btnCustomerCodeCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCustomerCodeOK_Click(object sender, EventArgs e)
        {

        }

        private void CustomerCodeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Hide();
            }
        }

        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Hide();
            }
        }
    }
}
