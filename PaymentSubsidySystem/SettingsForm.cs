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
    public partial class SettingsForm : Form
    {

        public PaymentSubsidyForm paymentSubsidyForm;
        public LoginForm loginForm;

        public SettingsForm(PaymentSubsidyForm form, LoginForm form1)
        {
            InitializeComponent();
            getSettings();

            paymentSubsidyForm = form;
            loginForm = form1;
        }

        public void getSettings()
        {
            String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

            String json;
            using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.Settings settings = javaScriptSerializer.Deserialize<Entities.Settings>(json);

            txtConnectionString.Text = settings.ConnectionString;
            txtSoftware.Text = settings.Software;
            txtVersion.Text = settings.Version;
            txtDeveloper.Text = settings.Developer;
        }

        private void btnSettingsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Boolean testDBConnection()
        {
            Data.pos13DataContext db = new Data.pos13DataContext(txtConnectionString.Text);
            Boolean result = true;

            try
            {
                db.Connection.Open();

                if (!db.DatabaseExists())
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                db.Dispose();
            }

            return result;
        }

        public void saveSettings()
        {
            btnSettingsSave.Enabled = false;
            btnSettingsClose.Enabled = false;

            if (testDBConnection())
            {
                Entities.Settings newSettings = new Entities.Settings()
                {
                    ConnectionString = txtConnectionString.Text,
                    Software = txtSoftware.Text,
                    Version = txtVersion.Text,
                    Developer = txtDeveloper.Text
                };

                String json = new JavaScriptSerializer().Serialize(newSettings);
                String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

                File.WriteAllText(settingsPath, json);

                paymentSubsidyForm.getFooterDetails();

                Close();
            }
            else
            {
                MessageBox.Show("Invalid connection string.", "Server Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSettingsSave.Enabled = true;
                btnSettingsClose.Enabled = true;
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void txtConnectionString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveSettings();
            }
        }

        private void txtSoftware_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveSettings();
            }
        }

        private void txtVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveSettings();
            }
        }

        private void txtDeveloper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveSettings();
            }
        }
    }
}
