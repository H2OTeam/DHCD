using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{

    public partial class DelegateList
    {
        private DateTime dateMeeting = My.MyProject.Forms.Mainform.dateMeeting;

        public DelegateList()
        {
            InitializeComponent();
        }
        private void DelegateList_Load(object sender, EventArgs e)
        {
            MdiParent = My.MyProject.Forms.Mainform;
            filldgv();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            filldgv();
        }

        private void filldgv()
        {
            int delegatecode = 0;
            var dt = new DataTable();
            if (string.IsNullOrEmpty(ToolStripTextBox1.Text))
            {
                delegatecode = 0;
            }
            else
            {
                try
                {
                    delegatecode = Convert.ToInt32(ToolStripTextBox1.Text);
                }
                catch (Exception ex)
                {
                    delegatecode = 0;
                }
            }

            try
            {
                dt = My.MyProject.Forms.Mainform.BenlyDal.Delegate_getlist(My.MyProject.Forms.Mainform.workingmeeting, delegatecode, ToolStripTextBox2.Text);
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
                return;
            }

            DataGridView1.DataSource = dt;
            ToolStripStatusLabel2.Text = DataGridView1.RowCount.ToString();
            int totalright = 0;
            foreach (DataRow dr in dt.Rows)
                totalright = Conversions.ToInteger(Operators.AddObject(totalright, dr["Voterights"]));
            ToolStripStatusLabel4.Text = My.MyProject.Forms.Mainform.addthousandseperator(totalright.ToString());
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                Interaction.MsgBox("Bạn phải chọn ít nhất một bản ghi");
                return;
            }
            if (Interaction.MsgBox(Operators.AddObject("Bạn có chắc chắn XÓA đại biểu :" + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString() + " ---- ", DataGridView1.CurrentRow.Cells["Delegatename"].Value), (MsgBoxStyle)((int)MsgBoxStyle.OkCancel + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.ApplicationModal + (int)MsgBoxStyle.DefaultButton2), "XÓA CỔ ĐÔNG") == MsgBoxResult.Ok)
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.Delegate_delete(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToString(DataGridView1.CurrentRow.Cells["Delegatecode"].Value));
                    filldgv();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                }
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            var fr = new Delegate_ins();
            fr.ShowDialog();
            filldgv();
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            // Dim cr As New thebieuquyet_2
            var cr = new ReportDocument();
            string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\thebieuquyet_2.rpt");
            if (!System.IO.File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                return;
            }

            try
            {
                cr.Load(reportPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load báo cáo: " + ex.Message);
                return;
            }

            try
            {
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr.SetParameterValue("LogoPath", logoPath);
                string qrcodepath = System.IO.Path.Combine(Application.StartupPath, @"Resources\qrcode.jpeg");
                cr.SetParameterValue("qrcodepath", qrcodepath);
                cr.SetParameterValue("HolderName", DataGridView1.CurrentRow.Cells["Delegatename"].Value);
                cr.SetParameterValue("Delegatecode", "DB" + My.MyProject.Forms.Mainform.stockCode + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString().PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells["Delegatename"].Value.ToString().ToUpper());
                cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells["IdentityCard"].Value);
                cr.SetParameterValue("Address", DataGridView1.CurrentRow.Cells["DelegateAddress"].Value);
                cr.SetParameterValue("DateMeeting", dateMeeting);
                cr.SetParameterValue("Period", My.MyProject.Forms.Mainform.period);
                cr.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                var dt = new DataTable();
                dt = My.MyProject.Forms.Mainform.BenlyDal.Authorizations_getlist(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["Delegatecode"].Value), "", "", "");
                string str = "";
                if (dt.Rows.Count == 1)
                {
                    str = Conversions.ToString(dt.Rows[0]["Holdercode"]);
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                        str = str + dr["Holdercode"].ToString() + " (" + My.MyProject.Forms.Mainform.addthousandseperator(dr["DelegateRight"].ToString()) + " CP); ";
                }

                cr.SetParameterValue("Holdercode", str);
                cr.SetParameterValue("voterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(DataGridView1.CurrentRow.Cells["voterights"].Value)));
                // cr.PrintToPrinter(1, True, 1, 1)

                ReportViewer.LoadReport(cr, this);
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
                return;
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                Interaction.MsgBox("Bạn phải chọn ít nhất một bản ghi");
                return;
            }
            var du = new DelegateUpdate(Conversions.ToInteger(DataGridView1.CurrentRow.Cells["Delegatecode"].Value));
            du.ShowDialog();
            filldgv();
        }

        // In phieu bieu quyet
        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            var cr = new phieubieuquyet1();
            try
            {
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr.SetParameterValue("LogoPath", logoPath);
                cr.SetDataSource(My.MyProject.Forms.Mainform.BenlyDal.Matter_getlist(My.MyProject.Forms.Mainform.workingmeeting, 0m));
                cr.SetParameterValue("Delegatecode", "DB" + My.MyProject.Forms.Mainform.stockCode + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString().PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells["Delegatename"].Value.ToString().ToUpper());
                cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells["IdentityCard"].Value);
                cr.SetParameterValue("DelegateAddress", DataGridView1.CurrentRow.Cells["DelegateAddress"].Value);
                cr.SetParameterValue("DateMeeting", dateMeeting);
                cr.SetParameterValue("Period", My.MyProject.Forms.Mainform.period);
                cr.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.Authorizations_getlist(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["Delegatecode"].Value), "", "", "");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                    return;
                }
                string str = "";
                if (dt.Rows.Count == 1)
                {
                    str = Conversions.ToString(dt.Rows[0]["Holdercode"]);
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                        str = str + dr["Holdercode"].ToString() + " (" + My.MyProject.Forms.Mainform.addthousandseperator(dr["DelegateRight"].ToString()) + " CP); ";
                }

                cr.SetParameterValue("Holdercode", str);
                cr.SetParameterValue("voterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(DataGridView1.CurrentRow.Cells["voterights"].Value)));
                // cr.PrintToPrinter(1, True, 1, 10)
                ReportViewer.LoadReport(cr, this);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }



        }

        private void ToolStripButton8_Click(object sender, EventArgs e)
        {
            // Dim cr As New phieubieuquyet2
            // cr.SetParameterValue("Delegatecode", DataGridView1.CurrentRow.Cells("Delegatecode").Value)
            // cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells("Delegatename").Value)
            // cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells("IdentityCard").Value)
            // cr.SetParameterValue("DateMeeting", dateMeeting)
            // Dim dt As New DataTable
            // Try
            // dt = Mainform.BenlyDal.Authorizations_getlist(Mainform.workingmeeting, DataGridView1.CurrentRow.Cells("Delegatecode").Value, "", "", "")
            // Catch ex As Exception
            // MsgBox("Lỗi :" + ex.Message)
            // Exit Sub
            // End Try
            // Dim str As String = ""
            // If dt.Rows.Count = 1 Then
            // str = dt.Rows(0).Item("Holdercode")
            // Else
            // For Each dr As DataRow In dt.Rows
            // str = str + dr.Item("Holdercode").ToString + " (" + Mainform.addthousandseperator(dr.Item("DelegateRight").ToString) + " CP); "
            // Next
            // End If
            // 
            // cr.SetParameterValue("Holdercode", str)
            // cr.SetParameterValue("voterights", Mainform.addthousandseperator(DataGridView1.CurrentRow.Cells("voterights").Value))
            // 'cr.PrintToPrinter(1, True, 1, 1)
            // ReportViewer.LoadReport(cr, Me)
        }

        private void ToolStripButton9_Click(object sender, EventArgs e)
        {
            // Dim cr As New phieubau2
            // cr.SetParameterValue("Delegatecode", DataGridView1.CurrentRow.Cells("Delegatecode").Value)
            // cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells("Delegatename").Value)
            // cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells("IdentityCard").Value)
            // Dim dt As New DataTable
            // Try
            // dt = Mainform.BenlyDal.Authorizations_getlist(Mainform.workingmeeting, DataGridView1.CurrentRow.Cells("Delegatecode").Value, "", "", "")
            // Catch ex As Exception
            // MsgBox("Lỗi :" + ex.Message)
            // Exit Sub
            // End Try
            // Dim str As String = ""
            // If dt.Rows.Count = 1 Then
            // str = dt.Rows(0).Item("Holdercode")
            // Else
            // For Each dr As DataRow In dt.Rows
            // str = str + dr.Item("Holdercode").ToString + " (" + Mainform.addthousandseperator(dr.Item("DelegateRight").ToString) + " CP); "
            // Next
            // End If

            // cr.SetParameterValue("Holdercode", str)
            // cr.SetParameterValue("voterights", Mainform.addthousandseperator(DataGridView1.CurrentRow.Cells("voterights").Value))
            // cr.SetParameterValue("sumvoterights", Mainform.addthousandseperator(DataGridView1.CurrentRow.Cells("voterights").Value))
            // cr.PrintToPrinter(1, True, 1, 1)
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void DelegateList_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(ToolStripTextBox1.Focused | ToolStripTextBox2.Focused))
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        {
                            ToolStripButton1_Click(sender, e);
                            break;
                        }
                    case Keys.E:
                        {
                            ToolStripButton2_Click(sender, e);
                            break;
                        }
                    case Keys.D:
                        {
                            ToolStripButton3_Click(sender, e);
                            break;
                        }
                    case Keys.S:
                        {
                            ToolStripButton4_Click(sender, e);
                            break;
                        }
                    case Keys.B:
                        {
                            ToolStripButton5_Click(sender, e);
                            break;
                        }
                    case Keys.P:
                        {
                            ToolStripButton7_Click(sender, e);
                            break;
                        }
                    case Keys.Escape:
                        {
                            Close();
                            break;
                        }
                }
            }

        }

        private void ToolStripTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filldgv();
            }
        }

        private void ToolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filldgv();
            }

        }

        private void ToolStripButton10_Click(object sender, EventArgs e)
        {

            var isOnlyAuthori = default(bool);
            var isHolder = default(bool);
            string strHolders = My.MyProject.Forms.Mainform.BenlyDal.getAuthorizationByDelegateCode(My.MyProject.Forms.Mainform.workingmeeting, DataGridView1.CurrentRow.Cells["DelegateCode"].Value.ToString(), ref isOnlyAuthori, ref isHolder);
            try
            {
                // Me.InPhieuXacNhan(DataGridView1.CurrentRow.Cells("Delegatename").Value.ToString.ToUpper(), DataGridView1.CurrentRow.Cells("Delegatename").Value.ToString.ToUpper(), DataGridView1.CurrentRow.Cells("IdentityCard").Value, DataGridView1.CurrentRow.Cells("DelegateAddress").Value, Mainform.addthousandseperator(DataGridView1.CurrentRow.Cells("voterights").Value))
                InPhieuXacNhan(strHolders.ToUpper(), Conversions.ToString(DataGridView1.CurrentRow.Cells["Delegatecode"].Value), DataGridView1.CurrentRow.Cells["Delegatename"].Value.ToString().ToUpper(), Conversions.ToString(DataGridView1.CurrentRow.Cells["IdentityCard"].Value), Conversions.ToString(DataGridView1.CurrentRow.Cells["DelegateAddress"].Value), My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(DataGridView1.CurrentRow.Cells["voterights"].Value)), isOnlyAuthori, isHolder);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }


        }

        private void InPhieuXacNhan(string strHolderName, string strDelegateCode, string strDelegateName, string strIndentityCard, string strAddress, string strVoteRight, bool isOnlyAuthori, bool isHolder)
        {

            // Dim cr As New PhieuXacNhan
            var cr = new ReportDocument();

            string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\PhieuXacNhan.rpt");
            if (!System.IO.File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                return;
            }

            try
            {
                cr.Load(reportPath);
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr.SetParameterValue("LogoPath", logoPath);
                string[] holderName = strHolderName.Split(',');
                object[] holderName2 = Array.Empty<object>();
                if (holderName.Length > 0)
                {
                    holderName2 = holderName.Where(s => !string.IsNullOrEmpty(s.Trim().ToUpper())).ToArray();
                    for (int i = 0, loopTo = holderName2.Length - 1; i <= loopTo; i++)
                        holderName2[i] = Operators.AddObject((i + 1).ToString() + ". ", holderName2[i].ToString().Trim());
                }

                cr.SetParameterValue("HolderName", string.Join(Environment.NewLine, holderName2).ToUpper());
                cr.SetParameterValue("Delegatecode", "DB" + My.MyProject.Forms.Mainform.stockCode + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString().PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", strDelegateName.ToUpper());
                cr.SetParameterValue("IdentityCard", strIndentityCard);
                cr.SetParameterValue("Address", strAddress);
                cr.SetParameterValue("DateMeeting", dateMeeting);
                cr.SetParameterValue("voterights", strVoteRight);
                cr.SetParameterValue("Period", My.MyProject.Forms.Mainform.period);
                cr.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                cr.SetParameterValue("CompanyName", My.MyProject.Forms.Mainform.companyName);
                cr.SetParameterValue("isOnlyAuthori", isOnlyAuthori);
                cr.SetParameterValue("isHolder", isHolder);
                ReportViewer.LoadReport(cr, this);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }

        }

        private void InPhieuBauBKS_Click(object sender, EventArgs e)
        {
            // Dim cr As New phieubauBKS
            var cr = new ReportDocument();
            string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\phieubauBKS.rpt");
            if (!System.IO.File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                return;
            }

            try
            {
                cr.Load(reportPath);
                const string pram = "ban kiểm soát";
                var dt = My.MyProject.Forms.Mainform.BenlyDal.GetVoteSenate(pram);
                cr.SetDataSource(dt);
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr.SetParameterValue("LogoPath", logoPath);
                cr.SetParameterValue("Delegatecode", "DB" + My.MyProject.Forms.Mainform.stockCode + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString().PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells["Delegatename"].Value);
                cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells["IdentityCard"].Value);
                cr.SetParameterValue("DelegateAddress", DataGridView1.CurrentRow.Cells["DelegateAddress"].Value);
                cr.SetParameterValue("DateMeeting", dateMeeting);
                cr.SetParameterValue("CountCandidate", dt.Rows.Count.ToString());
                cr.SetParameterValue("Voterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(DataGridView1.CurrentRow.Cells["Voterights"].Value)));
                cr.SetParameterValue("sumvoterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(Operators.MultiplyObject(DataGridView1.CurrentRow.Cells["voterights"].Value, dt.Rows.Count))));
                cr.SetParameterValue("Period", My.MyProject.Forms.Mainform.period);
                cr.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                ReportViewer.LoadReport(cr, this);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }
        }

        private void InPhieuBauHDQT_Click(object sender, EventArgs e)
        {
            // Dim cr As New phieubauHDQT
            // Dim cr As New ReportDocument()
            // cr.Load("~/Report/phieubauHDQT.rpt")
            var cr = new ReportDocument();
            string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\phieubauHDQT.rpt");
            if (!System.IO.File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                return;
            }

            try
            {
                cr.Load(reportPath);
                const string pram = "Hội Đồng Quản trị";
                var dt = My.MyProject.Forms.Mainform.BenlyDal.GetVoteSenate(pram);
                cr.SetDataSource(dt);
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr.SetParameterValue("LogoPath", logoPath);
                cr.SetParameterValue("Delegatecode", "DB" + My.MyProject.Forms.Mainform.stockCode + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString().PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells["Delegatename"].Value);
                cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells["IdentityCard"].Value);
                cr.SetParameterValue("CountCandidate", dt.Rows.Count.ToString());
                cr.SetParameterValue("DelegateAddress", DataGridView1.CurrentRow.Cells["DelegateAddress"].Value);
                cr.SetParameterValue("dateMeeting", dateMeeting);
                cr.SetParameterValue("Voterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(DataGridView1.CurrentRow.Cells["Voterights"].Value)));
                cr.SetParameterValue("sumvoterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(Operators.MultiplyObject(DataGridView1.CurrentRow.Cells["voterights"].Value, dt.Rows.Count))));
                cr.SetParameterValue("Period", My.MyProject.Forms.Mainform.period);
                cr.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                ReportViewer.LoadReport(cr, this);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }

        }

        private void ToolStripButton7_Click_1(object sender, EventArgs e)
        {
            // Dim cr As New phieubieuquyet1
            var cr = new ReportDocument();
            string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\phieubieuquyet1.rpt");
            if (!System.IO.File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                return;
            }
            try
            {
                cr.Load(reportPath);
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");

                cr.SetDataSource(My.MyProject.Forms.Mainform.BenlyDal.Matter_getlist(My.MyProject.Forms.Mainform.workingmeeting, 0m));
                cr.SetParameterValue("Delegatecode", "DB" + My.MyProject.Forms.Mainform.stockCode + DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString().PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", DataGridView1.CurrentRow.Cells["Delegatename"].Value.ToString().ToUpper());
                cr.SetParameterValue("IdentityCard", DataGridView1.CurrentRow.Cells["IdentityCard"].Value);
                cr.SetParameterValue("DelegateAddress", DataGridView1.CurrentRow.Cells["DelegateAddress"].Value);
                cr.SetParameterValue("DateMeeting", dateMeeting);
                cr.SetParameterValue("Period", My.MyProject.Forms.Mainform.period);
                cr.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);
                cr.SetParameterValue("LogoPath", logoPath);
                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.Authorizations_getlist(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["Delegatecode"].Value), "", "", "");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                    return;
                }
                string str = "";
                if (dt.Rows.Count == 1)
                {
                    str = Conversions.ToString(dt.Rows[0]["Holdercode"]);
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                        str = str + dr["Holdercode"].ToString() + " (" + My.MyProject.Forms.Mainform.addthousandseperator(dr["DelegateRight"].ToString()) + " CP); ";
                }

                cr.SetParameterValue("Holdercode", str);
                cr.SetParameterValue("voterights", My.MyProject.Forms.Mainform.addthousandseperator(Conversions.ToString(DataGridView1.CurrentRow.Cells["voterights"].Value)));
                ReportViewer.LoadReport(cr, this);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }


        }
    }
}