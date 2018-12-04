using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;
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
    public partial class PaymentSubsidyForm : Form
    {
        private Data.pos13DataContext db;

        public String subsidyCode = "";
        public DateTime filterDate = DateTime.Today;
        public LoginForm loginForm;

        public PaymentSubsidyForm(LoginForm form)
        {
            InitializeComponent();
            db = new Data.pos13DataContext(Settings.GetConnectionString());

            createPaymentSubsidyForm();
            ActiveControl = txtSubsidyCode;

            loginForm = form;

            lblCurrentUser.Text = loginForm.currentUser;

            getFooterDetails();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            Hide();
        }

        public void createPaymentSubsidyForm()
        {
            try
            {
                dgvPaymentSubsidy.Rows.Clear();
                dgvPaymentSubsidy.Refresh();

                dgvPaymentSubsidy.Columns["colId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPaymentSubsidy.Columns["colDebit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPaymentSubsidy.Columns["colCredit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                String searchString = txtSearch.Text;
                filterDate = dtpDate.Value.Date;

                var paymentSubsidies = from d in db.TrnPaymentSubsidies.OrderByDescending(d => d.Id)
                                       where d.Date == filterDate
                                       && (d.SubsidyCode.Contains(searchString)
                                       || d.MstCustomer.Customer.Contains(searchString)
                                       || d.Particulars.Contains(searchString)
                                       || d.MstUser.FullName.Contains(searchString))
                                       select d;

                if (paymentSubsidies.Any())
                {
                    db.Refresh(RefreshMode.OverwriteCurrentValues, paymentSubsidies);

                    Decimal totalDebit = 0, totalCredit = 0;
                    foreach (var paymentSubsidy in paymentSubsidies)
                    {
                        dgvPaymentSubsidy.Rows.Add(paymentSubsidy.Id,
                            paymentSubsidy.TimeStamp,
                            paymentSubsidy.SubsidyCode,
                            paymentSubsidy.MstCustomer.Customer,
                            paymentSubsidy.DebitAmount.ToString("#,##0.00"),
                            paymentSubsidy.CreditAmount.ToString("#,##0.00"),
                            paymentSubsidy.Particulars,
                            paymentSubsidy.MstUser.FullName);

                        totalDebit += paymentSubsidy.DebitAmount;
                        totalCredit += paymentSubsidy.CreditAmount;
                    }

                    dgvPaymentSubsidy.Rows.Add("", "", "", "TOTALS: ", totalDebit.ToString("#,##0.00"), totalCredit.ToString("#,##0.00"), "", "");

                    dgvPaymentSubsidy["colCustomer", dgvPaymentSubsidy.Rows.Count - 1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPaymentSubsidy["colCustomer", dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    dgvPaymentSubsidy["colDebit", dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    dgvPaymentSubsidy["colCredit", dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);

                    dgvPaymentSubsidy.Rows[dgvPaymentSubsidy.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            filterDate = dtpDate.Value.Date;

            dgvPaymentSubsidy.Rows.Clear();
            dgvPaymentSubsidy.Refresh();

            if (dgvPaymentSubsidy.Rows.Count == 0)
            {
                createPaymentSubsidyForm();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPaymentSubsidy.Rows.Clear();
            dgvPaymentSubsidy.Refresh();

            if (dgvPaymentSubsidy.Rows.Count == 0)
            {
                createPaymentSubsidyForm();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dgvPaymentSubsidy.Rows.Clear();
                dgvPaymentSubsidy.Refresh();

                if (dgvPaymentSubsidy.Rows.Count == 0)
                {
                    createPaymentSubsidyForm();
                }
            }
        }

        private void txtSubsidyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtSubsidyCode.Text.Equals(""))
                {
                    MessageBox.Show("Subsidy code is empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String subsidyCodeString = txtSubsidyCode.Text;
                    filterDate = dtpDate.Value.Date;

                    var previousPaymentSubsidies = from d in db.TrnPaymentSubsidies
                                                   where d.Date < filterDate
                                                   && d.SubsidyCode.Equals(subsidyCodeString)
                                                   select d;

                    if (previousPaymentSubsidies.Any())
                    {
                        MessageBox.Show("Subsidy code already exist from the previous date.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var currentPaymentSubsidies = from d in db.TrnPaymentSubsidies
                                                      where d.Date == filterDate
                                                      && d.SubsidyCode.Equals(subsidyCodeString)
                                                      select d;

                        if (currentPaymentSubsidies.Any())
                        {
                            subsidyCode = currentPaymentSubsidies.FirstOrDefault().SubsidyCode;

                            EnterAmountForm enterAmountForm = new EnterAmountForm(this, loginForm);
                            enterAmountForm.ShowDialog();
                        }
                        else
                        {
                            subsidyCode = subsidyCodeString;

                            CustomerCodeForm customerCodeForm = new CustomerCodeForm(this, loginForm);
                            customerCodeForm.ShowDialog();
                        }
                    }
                }
            }
        }

        public void emptySubsidyCode()
        {
            txtSubsidyCode.Text = subsidyCode;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this, loginForm);
            settingsForm.ShowDialog();
        }

        public void getFooterDetails()
        {
            String settingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings.json");

            String json;
            using (StreamReader trmRead = new StreamReader(settingsPath)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.Settings settings = javaScriptSerializer.Deserialize<Entities.Settings>(json);

            lblPaymentSubsidySoftware.Text = settings.Software;
            lblPaymentSubsidyVersion.Text = settings.Version;
            lblPaymentSubsidyDeveloper.Text = settings.Developer;
        }

        private void PaymentSubsidyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
