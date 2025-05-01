using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using BenlyDAL.BenlyDAL;
using Microsoft.VisualBasic;

namespace pmDHCD
{
    public partial class Mainform
    {
        public SqlConnection conn = new SqlConnection();
        public DAL BenlyDal;
        public string workingmeeting = "";
        public string period = "2022 – 2026";
        public string mettingType = "thường niên";
        public string stockCode = "APG";
        public string companyName = "Công ty Cổ phần Chứng khoán APG";
        public DateTime dateMeeting = DateTime.Now;

        public Mainform()
        {
            BenlyDal = new DAL(conn);
            InitializeComponent();
        }


        private void Mainform_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
        }

        private void Mainform_Shown(object sender, EventArgs e)
        {
            connect2db();
            My.MyProject.Forms.MeetingList.Show();
        }
        private void connect2db()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = GetConnectionString("connDBstr");
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                    return;
                }
            }
        }
        public string GetConnectionString(string key)
        {
            string strApp = "";
            try
            {
                strApp = ConfigurationManager.ConnectionStrings[key].ConnectionString;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            return strApp;
        }
        public string addthousandseperator(string str)
        {
            string result = str;
            int len = str.Length;
            if (len > 3)
            {
                result = result.Insert(len - 3, ".");
                len = len - 3;

                while (len > 3)
                {
                    result = result.Insert(len - 3, ".");
                    len = len - 3;
                }

            }
            return result;
        }
        private void DanhSáchCuộcHọpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MeetingList.Show();
        }

        private void DanhSáchCổĐôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.HolderList.Show();
        }

        private void DanhSáchĐạiBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DelegateList.Show();
        }

        private void DanhSáchỦyQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AuthorizationList.Show();
        }

        private void DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MatterList.Show();
        }

        private void BiểuQuyếtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DanhSáchVấnĐềBầuCửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ElectionList.Show();
        }

        private void DanhSáchỨngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CandidateList.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MatterVoteList.Show();
        }

        private void KếtQuảBầuCửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Elections_result.Show();
        }

        private void DanhSáchPhiếuBầuCửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.ElectionVoteList.Show();
        }

        private void KếtQuảBiểuQuyếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MatterVoteResult.Show();
        }

        private void ThôngTinCuộcHọpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.MeetingInfoshow.ShowDialog();
        }

        private void DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.IllegalElectionList.Show();
        }

        private void AbcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abc");
        }
    }
}