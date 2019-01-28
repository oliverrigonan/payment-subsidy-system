using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentSubsidySystem
{
    public partial class GenerateCSVForm : Form
    {
        private Data.pos13DataContext db;

        public GenerateCSVForm()
        {
            InitializeComponent();
            db = new Data.pos13DataContext(Settings.GetConnectionString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = fbdGenerateCSV.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    DateTime startDate = dtpStartDate.Value.Date;
                    DateTime endDate = dtpEndDate.Value.Date;

                    StringBuilder csv = new StringBuilder();
                    String[] header = { "Date", "Id No.", "Customer", "Department", "Amount", "Remarks" };
                    csv.AppendLine(String.Join(",", header));

                    var paymentSubsidies = from d in db.TrnPaymentSubsidies
                                           where d.Date >= startDate
                                           && d.Date <= endDate
                                           && d.CreditAmount > 0
                                           select d;

                    if (paymentSubsidies.Any())
                    {
                        foreach (var paymentSubsidy in paymentSubsidies)
                        {
                            String[] data = {
                                paymentSubsidy.Date.ToShortDateString(),
                                "ID: " + paymentSubsidy.SubsidyCode,
                                paymentSubsidy.MstCustomer.Customer,
                                paymentSubsidy.MstCustomer.Address,
                                paymentSubsidy.CreditAmount.ToString("#,##0.00"),
                                paymentSubsidy.Particulars
                            };

                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(fbdGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\PaymentSubsidyReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("iso-8859-1"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
