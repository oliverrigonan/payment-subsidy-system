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
    public partial class ConnectionStringSettingsForm : Form
    {
        public ConnectionStringSettingsForm()
        {
            InitializeComponent();
        }

        private void btnConnectionStringSettingsClose_Click(object sender, EventArgs e)
        {
            Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        public void saveConnectionString()
        {
            btnConnectionStringSettingsSave.Enabled = false;
            btnConnectionStringSettingsClose.Enabled = false;

            if (testDBConnection())
            {
                String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

                String json;
                using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                Entities.Settings settings = javaScriptSerializer.Deserialize<Entities.Settings>(json);

                Entities.Settings newSettings = new Entities.Settings()
                {
                    ConnectionString = txtConnectionString.Text,
                    Software = settings.Software,
                    Version = settings.Version,
                    Developer = settings.Developer
                };

                String newConnectionStringJson = new JavaScriptSerializer().Serialize(newSettings);

                File.WriteAllText(settingsPath, newConnectionStringJson);

                Close();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid connection string.", "Server Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnConnectionStringSettingsSave.Enabled = true;
                btnConnectionStringSettingsClose.Enabled = true;
            }
        }

        private void btnConnectionStringSettingsSave_Click(object sender, EventArgs e)
        {
            saveConnectionString();
        }

        private void txtConnectionString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                saveConnectionString();
            }
        }
    }
}
