using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;

namespace pmDHCD
{

    public partial class PrintHolders
    {
        public PrintHolders()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            var dt = new DataTable();
            try
            {
                dt = My.MyProject.Forms.Mainform.BenlyDal.Holder_getListLimited(My.MyProject.Forms.Mainform.workingmeeting, Convert.ToInt32(txtFromHolder.Text), Convert.ToInt32(txtToHolder.Text));
                for (int i = 0, loopTo = dt.Rows.Count - 1; i <= loopTo; i++)
                    dt.Rows[i]["VoteRights"] = My.MyProject.Forms.Mainform.addthousandseperator(dt.Rows[i]["VoteRights"].ToString().Trim());

                // Dim cr_thebieuquyet As New thebieuquyet
                var cr_thebieuquyet = new ReportDocument();
                // cr_thebieuquyet.Load("~/Report/thebieuquyet.rpt")
                string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\thebieuquyet.rpt");
                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                    return;
                }
                cr_thebieuquyet.Load(reportPath);
                cr_thebieuquyet.SetDataSource(dt);
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr_thebieuquyet.SetParameterValue("LogoPath", logoPath);
                cr_thebieuquyet.SetParameterValue("DateMeeting", My.MyProject.Forms.Mainform.dateMeeting);
                cr_thebieuquyet.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                ReportViewer.LoadReport(cr_thebieuquyet, My.MyProject.Forms.HolderList);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}