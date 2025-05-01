using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{
    public partial class Meeting_ins_update
    {
        private string controlcode = "Add";
        private string updatemeetingcode;
        public Meeting_ins_update(string controlcode, string meetingcode)
        {
            this.controlcode = controlcode;
            updatemeetingcode = meetingcode;
            InitializeComponent();

        }
        private void Meeting_ins_update_Load(object sender, EventArgs e)
        {
            if (controlcode == "Update")
            {
                MaskedTextBox1.Text = updatemeetingcode;
                MaskedTextBox1.ReadOnly = true;
                Button1.Text = "Cập nhật";
                Text = "Cập nhật cuộc họp";
                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.Meeting_getlist(updatemeetingcode);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("lỗi" + ex.Message);
                    return;
                }
                MaskedTextBox2.Text = Conversions.ToString(dt.Rows[0]["meetingname"]);
                MaskedTextBox3.Text = Conversions.ToString(dt.Rows[0]["companyname"]);
                MaskedTextBox4.Text = Conversions.ToString(dt.Rows[0]["CompanyAddress"]);
                MaskedTextBox5.Text = Conversions.ToString(dt.Rows[0]["meetingAddress"]);
                txtPeriod.Text = Conversions.ToString(dt.Rows[0]["Period"]);
                txtMettingType.SelectedText = Conversions.ToString(dt.Rows[0]["MettingType"]); // stockCode
                stockCode.Text = Conversions.ToString(dt.Rows[0]["StockCode"]);
                // DateTimePicker1.Value = Convert.ToDateTime(dt.Rows(0)("meetingtime"))
                DateTimePicker1.Value = DateTime.Parse(Conversions.ToString(dt.Rows[0]["meetingtime"]), new CultureInfo("vi-VN"));
            }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (controlcode == "Add")
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.meeting_insert(MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, DateTimePicker1.Value.Date, txtPeriod.Text, txtMettingType.Text, stockCode.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi : " + ex.Message);
                }
            }
            else if (controlcode == "Update")
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.meeting_update(MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, DateTimePicker1.Value.Date, txtPeriod.Text, txtMettingType.Text, stockCode.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi : " + ex.Message);
                }

            }
        }

        private void Meeting_ins_update_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}