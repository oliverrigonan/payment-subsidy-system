using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PaymentSubsidySystem
{
    public partial class LoginForm : Form
    {
        private Data.pos13DataContext db;

        public Int32 currentUserId = 0;
        public String currentUser = "";

        public LoginForm()
        {
            InitializeComponent();
            db = new Data.pos13DataContext(Settings.GetConnectionString());

            getFooterDetails();
        }

        public void login()
        {
            try
            {
                if (db.DatabaseExists())
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
                else
                {
                    MessageBox.Show("Looks like your connection string is invalid. Please update connection string.", "Server Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnLogin.Enabled = true;
                    btnCancel.Enabled = true;

                    Hide();

                    ConnectionStringSettingsForm connectionStringSettingsForm = new ConnectionStringSettingsForm();
                    connectionStringSettingsForm.ShowDialog();
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

        public void getFooterDetails()
        {
            String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

            String json;
            using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.Settings settings = javaScriptSerializer.Deserialize<Entities.Settings>(json);

            lblLoginSoftware.Text = settings.Software;
            lblLoginVersion.Text = settings.Version;
            lblLoginDeveloper.Text = settings.Developer;
        }
    }
}
