using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{
    public partial class MatterVoteList
    {
        public MatterVoteList()
        {
            InitializeComponent();
        }


        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            filldgv();
        }

        private void MatterVoteList_Load(object sender, EventArgs e)
        {
            MdiParent = My.MyProject.Forms.Mainform;
            filldgv();
        }
        private void filldgv()
        {
            var t = new DataTable();
            try
            {
                string HolderIdentify;
                int mattcode = 0;
                int delecode = 0;
                try
                {
                    mattcode = Conversions.ToInteger(ToolStripTextBox1.Text);
                }
                catch (Exception ex)
                {
                    mattcode = 0;
                }
                try
                {
                    HolderIdentify = ToolStripTextBox2.Text;
                }
                catch (Exception ex)
                {
                    HolderIdentify = "";
                }
                try
                {
                    delecode = Conversions.ToInteger(ToolStriptxtDbCode.Text);
                }
                catch (Exception ex)
                {
                    delecode = 0;
                }

                t = My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_getlist(My.MyProject.Forms.Mainform.workingmeeting, mattcode, HolderIdentify, delecode);
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }

            decimal totalright = 0m;
            decimal agreecount = 0m;
            decimal agreeright = 0m;
            decimal disagreecount = 0m;
            decimal disagreeright = 0m;
            decimal noideacount = 0m;
            decimal noidearight = 0m;
            decimal illegalacount = 0m;
            decimal illegalright = 0m;

            foreach (DataRow dr in t.Rows)
            {

                try
                {
                    totalright = Conversions.ToDecimal(Operators.AddObject(totalright, dr["Voterights"]));
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                }

                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["Agree"], true, false)))
                {
                    agreecount = agreecount + 1m;
                    agreeright = Conversions.ToDecimal(Operators.AddObject(agreeright, dr["Voterights"]));
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["DisAgree"], true, false)))
                {
                    disagreecount = disagreecount + 1m;
                    disagreeright = Conversions.ToDecimal(Operators.AddObject(disagreeright, dr["Voterights"]));
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["NoIdea"], true, false)))
                {
                    noideacount = noideacount + 1m;
                    noidearight = Conversions.ToDecimal(Operators.AddObject(noidearight, dr["NoIdea"]));
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["Illegal"], true, false)))
                {
                    illegalacount = illegalacount + 1m;
                    illegalright = Conversions.ToDecimal(Operators.AddObject(illegalright, dr["Voterights"]));
                }
            }
            DataGridView1.DataSource = t;
            ToolStripStatusLabel2.Text = DataGridView1.RowCount.ToString();
            ToolStripStatusLabel16.Text = My.MyProject.Forms.Mainform.addthousandseperator(totalright.ToString());

            // --------
            ToolStripStatusLabel4.Text = My.MyProject.Forms.Mainform.addthousandseperator(agreecount.ToString()) + " -- ";
            ToolStripStatusLabel5.Text = My.MyProject.Forms.Mainform.addthousandseperator(agreeright.ToString()) + " -- ";
            ToolStripStatusLabel8.Text = My.MyProject.Forms.Mainform.addthousandseperator(disagreecount.ToString()) + " -- ";
            ToolStripStatusLabel9.Text = My.MyProject.Forms.Mainform.addthousandseperator(disagreeright.ToString()) + " -- ";

            ToolStripStatusLabel12.Text = My.MyProject.Forms.Mainform.addthousandseperator(noideacount.ToString()) + " -- ";
            ToolStripStatusLabel13.Text = My.MyProject.Forms.Mainform.addthousandseperator(noidearight.ToString()) + " -- ";


            if (totalright > 0m)
            {
                ToolStripStatusLabel6.Text = Math.Round(agreeright / totalright * 100m, 2).ToString() + "% ";
                ToolStripStatusLabel10.Text = Math.Round(disagreeright / totalright * 100m, 2).ToString() + "% ";
                ToolStripStatusLabel14.Text = Math.Round(noidearight / totalright * 100m, 2).ToString() + "% ";
                decimal tyleIllegal = Math.Round(illegalright / totalright * 100m, 2);
                // --------Hop lệ
                txtCounthople.Text = "Số phiếu hợp lệ:" + (DataGridView1.RowCount - illegalacount).ToString() + "đại biểu - với tổng số quyền hợp lệ: " + (totalright - illegalright).ToString("#,###") + " - chiếm tỷ lệ:" + (100m - tyleIllegal).ToString() + "% ";
                // --------Không Hoplệ
                txtRighthl.Text = "Số phiếu hợp lệ:" + illegalacount.ToString() + " đại biểu - với tống số quyền không hợp lệ: " + illegalright.ToString("#,###") + " - chiếm tỷ lệ:" + tyleIllegal.ToString() + "% ";
            }
            else
            {
                ToolStripStatusLabel6.Text = "";
                ToolStripStatusLabel10.Text = "";
                ToolStripStatusLabel14.Text = "";
                txtCounthople.Text = "";
                txtRighthl.Text = "";
            }

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            int matcode = 0;
            int delecode = 0;
            try
            {
                matcode = Conversions.ToInteger(ToolStripTextBox1.Text);
            }
            catch (Exception ex)
            {
                matcode = 0;
            }
            try
            {
                delecode = Conversions.ToInteger(ToolStripTextBox2.Text);
            }
            catch (Exception ex)
            {
                delecode = 0;
            }
            var f = new Mattervote_ins_update("Add", matcode, delecode);
            f.ShowDialog();
            filldgv();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            var f = new Mattervote_ins_update("Update", Conversions.ToInteger(DataGridView1.CurrentRow.Cells["Mattercode"].Value), Conversions.ToInteger(DataGridView1.CurrentRow.Cells["delegatecode"].Value));
            f.ShowDialog();
            filldgv();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                Interaction.MsgBox("Bạn phải chọn ít nhất một bản ghi");
                return;
            }
            if (Interaction.MsgBox(Operators.AddObject(Operators.AddObject(Operators.AddObject("Bạn có chắc chắn XÓA Phiếu biểu quyết vấn đề :", DataGridView1.CurrentRow.Cells["mattername"].Value), " của đb "), DataGridView1.CurrentRow.Cells["Delegatename"].Value), (MsgBoxStyle)((int)MsgBoxStyle.OkCancel + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.ApplicationModal + (int)MsgBoxStyle.DefaultButton2), "XÓA PHIẾU BIỂU QUYẾT") == MsgBoxResult.Ok)
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_delete(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["Mattercode"].Value), Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["delegatecode"].Value), Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["HolderCode"].Value));
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                }
            }
            filldgv();
        }

        private void MatterVoteList_KeyUp(object sender, KeyEventArgs e)
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
                    case Keys.Escape:
                        {
                            Close();
                            break;
                        }
                }
            }

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = DataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "Agree" || colName == "Disagree" || colName == "Noidea" || colName == "Illegal")
                {
                    try
                    {
                        // mattercode As Decimal, ByVal delegatecode As Decimal, ByVal Agree As Boolean, ByVal disAgree As Boolean, ByVal noidea As Boolean)
                        var row = DataGridView1.Rows[e.RowIndex];
                        var mattercode = row.Cells["Mattercode"].Value;
                        var delegatecode = row.Cells["DelegateCode"].Value;
                        bool agree = false;
                        bool disagree = false;
                        bool noidea = false;
                        bool illegal = false;
                        // Nếu chọn Agree
                        if (colName == "Agree" && Conversions.ToBoolean(row.Cells["Agree"].Value) == true)
                        {
                            row.Cells["Disagree"].Value = false;
                            row.Cells["Noidea"].Value = false;
                            row.Cells["Illegal"].Value = false;
                            agree = true;
                            noidea = false;
                            disagree = false;
                            illegal = false;
                        }
                        // Nếu chọn Disagree
                        else if (colName == "Disagree" && Conversions.ToBoolean(row.Cells["Disagree"].Value) == true)
                        {
                            row.Cells["Agree"].Value = false;
                            row.Cells["Noidea"].Value = false;
                            row.Cells["Illegal"].Value = false;
                            disagree = true;
                            noidea = false;
                            agree = false;
                            illegal = false;
                        }
                        // Nếu chọn Noidea
                        else if (colName == "Noidea" && Conversions.ToBoolean(row.Cells["Noidea"].Value) == true)
                        {
                            row.Cells["Agree"].Value = false;
                            row.Cells["Disagree"].Value = false;
                            row.Cells["Illegal"].Value = false;
                            noidea = true;
                            disagree = false;
                            agree = false;
                            illegal = false;
                        }
                        // Nếu chọn Illegal
                        else if (colName == "Illegal" && Conversions.ToBoolean(row.Cells["Illegal"].Value) == true)
                        {
                            row.Cells["Agree"].Value = false;
                            row.Cells["Disagree"].Value = false;
                            row.Cells["Noidea"].Value = false;
                            illegal = true;
                            disagree = false;
                            agree = false;
                            noidea = false;
                        }
                        My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_update(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(mattercode), Conversions.ToDecimal(delegatecode), agree, disagree, noidea, illegal);
                        filldgv();
                        DataGridView1.Refresh();
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Lỗi :" + ex.Message);
                    }

                }
            }
        }


        private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToolStripButton4_Click(sender, e);
            }
        }

        private void ToolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToolStripButton4_Click(sender, e);
            }
        }

        private void ToolStriptxtDbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToolStripButton4_Click(sender, e);
            }
        }
    }
}