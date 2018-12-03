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
    public partial class LoginForm : Form
    {
        private Data.pos13DataContext db = new Data.pos13DataContext();

        public Int32 currentUserId = 0; 
        public String currentUser = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        public void login()
        {
            try
            {
                btnLogin.Enabled = false;
                btnCancel.Enabled = false;

                String username = txtUsername.Text;
                String password = txtPassword.Text;

                var user = from d in db.MstUsers where d.UserName.Equals(username) && d.Password.Equals(password) select d;
                if (user.Any())
                {
                    currentUserId = user.FirstOrDefault().Id;
                    currentUser = user.FirstOrDefault().FullName;

                    Hide();

                    PaymentSubsidyForm paymentSubsidyForm = new PaymentSubsidyForm(this);
                    paymentSubsidyForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnLogin.Enabled = true;
                    btnCancel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnLogin.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
