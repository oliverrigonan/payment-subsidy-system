using HomeBi.Libraries.PagedList;
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
        public LoginForm loginForm;

        public List<Entities.DgvTrnPaymentSubsidy> paymentSubsidyList;
        public BindingSource dataPaymentSubsidyListSource = new BindingSource();
        public PagedList<Entities.DgvTrnPaymentSubsidy> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 20;

        public String subsidyCode = "";
        public DateTime filterDate = DateTime.Today;
        public String filterSubsidyCode = "";

        public Decimal totalDebitAmount = 0;
        public Decimal totalCreditAmount = 0;

        public PaymentSubsidyForm(LoginForm form)
        {
            InitializeComponent();
            db = new Data.pos13DataContext(Settings.GetConnectionString());

            CreateDgvPaymentSubsidy();
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

        public List<Entities.DgvTrnPaymentSubsidy> GetPaymentSubsidyListDataFilterByDateAndSearch()
        {
            List<Entities.DgvTrnPaymentSubsidy> rowList = new List<Entities.DgvTrnPaymentSubsidy>();

            Decimal totalDebit = 0, totalCredit = 0;

            String searchString = txtSearch.Text;
            filterDate = dtpDate.Value.Date;
            Controller.PaymentSubsidyController paymentSubsidyController = new Controller.PaymentSubsidyController();

            var paymentSubsidies = paymentSubsidyController.PaymentSubsidyList(filterDate, searchString);

            if (paymentSubsidies.Any())
            {
                var rows = from d in paymentSubsidies
                           select new Entities.DgvTrnPaymentSubsidy
                           {
                               ColumnId = d.Id.ToString(),
                               ColumnTimeStamp = d.TimeStamp,
                               ColumnSubsidyCode = d.SubsidyCode,
                               ColumnCustomer = d.Customer,
                               ColumnDebit = d.DebitAmount.ToString("#,##0.00"),
                               ColumnCredit = d.CreditAmount.ToString("#,##0.00"),
                               ColumnParticulars = d.Particulars,
                               ColumnUser = d.User
                           };

                totalDebit = paymentSubsidies.Sum(d => d.DebitAmount);
                totalCredit = paymentSubsidies.Sum(d => d.CreditAmount);

                Entities.DgvTrnPaymentSubsidy runningTotalDebitCreditAmount = new Entities.DgvTrnPaymentSubsidy
                {
                    ColumnSubsidyCode = "Total Amount",
                    ColumnDebit = totalDebit.ToString("#,##0.00"),
                    ColumnCredit = totalCredit.ToString("#,##0.00")
                };

                rowList = rows.ToList();
                rowList.Add(runningTotalDebitCreditAmount);
            }
            return rowList;
        }



        public void GetPaymentSubsidySource()
        {
            paymentSubsidyList = GetPaymentSubsidyListDataFilterByDateAndSearch();

            if (paymentSubsidyList.Any())
            {
                pageNumber = 1;
                pageList = new PagedList<Entities.DgvTrnPaymentSubsidy>(paymentSubsidyList, pageNumber, pageSize);

                if (pageList.PageCount == 1)
                {
                    buttonSalesListPageListFirst.Enabled = false;
                    buttonSalesListPageListPrevious.Enabled = false;
                    buttonSalesListPageListNext.Enabled = false;
                    buttonSalesListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonSalesListPageListFirst.Enabled = false;
                    buttonSalesListPageListPrevious.Enabled = false;
                    buttonSalesListPageListNext.Enabled = true;
                    buttonSalesListPageListLast.Enabled = true;
                }
                else if (pageNumber == pageList.PageCount)
                {
                    buttonSalesListPageListFirst.Enabled = true;
                    buttonSalesListPageListPrevious.Enabled = true;
                    buttonSalesListPageListNext.Enabled = false;
                    buttonSalesListPageListLast.Enabled = false;
                }
                else
                {
                    buttonSalesListPageListFirst.Enabled = true;
                    buttonSalesListPageListPrevious.Enabled = true;
                    buttonSalesListPageListNext.Enabled = true;
                    buttonSalesListPageListLast.Enabled = true;
                }

                textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
                dataPaymentSubsidyListSource.DataSource = pageList;
            }
            else
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;

                dataPaymentSubsidyListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }

        }

        public void CreateDgvPaymentSubsidy()
        {
            dgvPaymentSubsidy.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPaymentSubsidy.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPaymentSubsidy.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            GetPaymentSubsidySource();
            GetPaymentSubsidyListDataGridSource();

        }

        public void GetPaymentSubsidyListDataGridSource()
        {

            dgvPaymentSubsidy.DataSource = dataPaymentSubsidyListSource;

            if (dgvPaymentSubsidy.Rows.Count != 0)
            {
                if (pageList.PageCount == 1)
                {
                    dgvPaymentSubsidy[3, dgvPaymentSubsidy.Rows.Count - 1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPaymentSubsidy[3, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    dgvPaymentSubsidy[4, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    dgvPaymentSubsidy[5, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);

                    dgvPaymentSubsidy.Rows[dgvPaymentSubsidy.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }

                if (pageNumber == pageList.PageCount)
                {
                    dgvPaymentSubsidy[3, dgvPaymentSubsidy.Rows.Count - 1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPaymentSubsidy[3, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    dgvPaymentSubsidy[4, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    dgvPaymentSubsidy[5, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);

                    dgvPaymentSubsidy.Rows[dgvPaymentSubsidy.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
        }


        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dataPaymentSubsidyListSource.Clear();
            filterDate = dtpDate.Value.Date;
            CreateDgvPaymentSubsidy();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataPaymentSubsidyListSource.Clear();
            CreateDgvPaymentSubsidy();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataPaymentSubsidyListSource.Clear();
                CreateDgvPaymentSubsidy();
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

        private void btnGenerateCSV_Click(object sender, EventArgs e)
        {
            GenerateCSVForm generateCSVForm = new GenerateCSVForm();
            generateCSVForm.ShowDialog();
        }



        private void txtSubsidyCodeSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CreateDgvPaymentSubsidy();
            }
        }

        private void btnSusidyCodeSearch_Click(object sender, EventArgs e)
        {
            GetPaymentSubsidyDetail();
        }

        private void txtSubsidyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                GetPaymentSubsidyDetail();
            }

        }

        private void GetPaymentSubsidyDetail()
        {
            try
            {
                filterDate = dtpDate.Value.Date;

                subsidyCode = txtSubsidyCode.Text;
                var customer = from d in db.MstCustomers
                               where d.CustomerCode == subsidyCode 
                               
                               && d.IsLocked == true
                               select new Entities.CustomerDetail
                               {
                                   Id = d.Id,
                                   Code = d.CustomerCode,
                                   Customer = d.Customer,
                                   Department = d.Address,
                                   Balance = 0,
                               };

                if (customer.Any())
                {
                    CustomerInformationForm customerInformationForm = new CustomerInformationForm(this, loginForm, customer.FirstOrDefault(), filterDate);
                    customerInformationForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Subsidy Code not exist!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }


        private void buttonSalesListPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvTrnPaymentSubsidy>(paymentSubsidyList, ++pageNumber, pageSize);
                dataPaymentSubsidyListSource.DataSource = pageList;
            }

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;

            if (pageNumber == pageList.PageCount)
            {
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvTrnPaymentSubsidy>(paymentSubsidyList, pageList.PageCount, pageSize);
            dataPaymentSubsidyListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;
            buttonSalesListPageListNext.Enabled = false;
            buttonSalesListPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;

            dgvPaymentSubsidy[3, dgvPaymentSubsidy.Rows.Count - 1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPaymentSubsidy[3, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvPaymentSubsidy[4, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvPaymentSubsidy[5, dgvPaymentSubsidy.Rows.Count - 1].Style.Font = new Font("Century Gothic", 11, FontStyle.Bold);

            dgvPaymentSubsidy.Rows[dgvPaymentSubsidy.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LemonChiffon;
        }

        private void buttonSalesListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvTrnPaymentSubsidy>(paymentSubsidyList, --pageNumber, pageSize);
                dataPaymentSubsidyListSource.DataSource = pageList;
            }

            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvTrnPaymentSubsidy>(paymentSubsidyList, 1, pageSize);
            dataPaymentSubsidyListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = false;
            buttonSalesListPageListPrevious.Enabled = false;
            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }


    }
}
