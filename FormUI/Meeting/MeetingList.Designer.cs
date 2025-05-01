using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MeetingList : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            ToolStrip1 = new ToolStrip();
            ToolStripButton1 = new ToolStripButton();
            ToolStripButton1.Click += new EventHandler(ToolStripButton1_Click);
            ToolStripButton2 = new ToolStripButton();
            ToolStripButton2.Click += new EventHandler(ToolStripButton2_Click);
            ToolStripButton3 = new ToolStripButton();
            ToolStripButton3.Click += new EventHandler(ToolStripButton3_Click);
            ToolStripSeparator1 = new ToolStripSeparator();
            ToolStripLabel1 = new ToolStripLabel();
            ToolStripTextBox1 = new ToolStripTextBox();
            ToolStripButton4 = new ToolStripButton();
            ToolStripButton4.Click += new EventHandler(ToolStripButton4_Click);
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripButton5 = new ToolStripButton();
            ToolStripButton5.Click += new EventHandler(ToolStripButton5_Click);
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            DataGridView1 = new DataGridView();
            DataGridView1.KeyDown += new KeyEventHandler(DataGridView1_KeyDown);
            Meetingcode = new DataGridViewTextBoxColumn();
            Meetingname = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            CompanyAddress = new DataGridViewTextBoxColumn();
            Meetingaddress = new DataGridViewTextBoxColumn();
            StockCode = new DataGridViewTextBoxColumn();
            meetingtime = new DataGridViewTextBoxColumn();
            Period = new DataGridViewTextBoxColumn();
            MettingType = new DataGridViewTextBoxColumn();
            YearMeeting = new DataGridViewTextBoxColumn();
            ToolStrip1.SuspendLayout();
            StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator1, ToolStripLabel1, ToolStripTextBox1, ToolStripButton4, ToolStripSeparator2, ToolStripButton5 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1197, 27);
            ToolStrip1.TabIndex = 1;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            ToolStripButton1.Image = My.Resources.Resources.Add;
            ToolStripButton1.ImageTransparentColor = Color.Magenta;
            ToolStripButton1.Name = "ToolStripButton1";
            ToolStripButton1.Size = new Size(90, 24);
            ToolStripButton1.Text = "Thêm(A)";
            // 
            // ToolStripButton2
            // 
            ToolStripButton2.Image = My.Resources.Resources.Document;
            ToolStripButton2.ImageTransparentColor = Color.Magenta;
            ToolStripButton2.Name = "ToolStripButton2";
            ToolStripButton2.Size = new Size(76, 24);
            ToolStripButton2.Text = "Sửa(E)";
            // 
            // ToolStripButton3
            // 
            ToolStripButton3.Image = My.Resources.Resources.Delete;
            ToolStripButton3.ImageTransparentColor = Color.Magenta;
            ToolStripButton3.Name = "ToolStripButton3";
            ToolStripButton3.Size = new Size(80, 24);
            ToolStripButton3.Text = "Xóa(D)";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 27);
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(95, 24);
            ToolStripLabel1.Text = "Mã cuộc họp";
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox1.Name = "ToolStripTextBox1";
            ToolStripTextBox1.Size = new Size(132, 27);
            // 
            // ToolStripButton4
            // 
            ToolStripButton4.Image = My.Resources.Resources.Search;
            ToolStripButton4.ImageTransparentColor = Color.Magenta;
            ToolStripButton4.Name = "ToolStripButton4";
            ToolStripButton4.Size = new Size(58, 24);
            ToolStripButton4.Text = "Tìm";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 27);
            // 
            // ToolStripButton5
            // 
            ToolStripButton5.Image = My.Resources.Resources.officemac01;
            ToolStripButton5.ImageTransparentColor = Color.Magenta;
            ToolStripButton5.Name = "ToolStripButton5";
            ToolStripButton5.Size = new Size(206, 24);
            ToolStripButton5.Text = "Chọn cuộc họp(S or Enter)";
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            StatusStrip1.Location = new Point(0, 512);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(1197, 26);
            StatusStrip1.TabIndex = 3;
            StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(134, 20);
            ToolStripStatusLabel1.Text = "Số lượng bản ghi : ";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Meetingcode, Meetingname, CompanyName, CompanyAddress, Meetingaddress, StockCode, meetingtime, Period, MettingType, YearMeeting });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 27);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(1197, 485);
            DataGridView1.TabIndex = 4;
            // 
            // Meetingcode
            // 
            Meetingcode.DataPropertyName = "Meetingcode";
            Meetingcode.FillWeight = 59.37841f;
            Meetingcode.HeaderText = "Mã cuộc họp";
            Meetingcode.MinimumWidth = 6;
            Meetingcode.Name = "Meetingcode";
            Meetingcode.ReadOnly = true;
            // 
            // Meetingname
            // 
            Meetingname.DataPropertyName = "Meetingname";
            Meetingname.FillWeight = 65.68176f;
            Meetingname.HeaderText = "Tên cuộc họp";
            Meetingname.MinimumWidth = 100;
            Meetingname.Name = "Meetingname";
            Meetingname.ReadOnly = true;
            // 
            // CompanyName
            // 
            CompanyName.DataPropertyName = "CompanyName";
            CompanyName.FillWeight = 138.3765f;
            CompanyName.HeaderText = "Tên công ty";
            CompanyName.MinimumWidth = 8;
            CompanyName.Name = "CompanyName";
            CompanyName.ReadOnly = true;
            // 
            // CompanyAddress
            // 
            CompanyAddress.DataPropertyName = "CompanyAddress";
            CompanyAddress.FillWeight = 79.50503f;
            CompanyAddress.HeaderText = "Đ/C công ty";
            CompanyAddress.MinimumWidth = 6;
            CompanyAddress.Name = "CompanyAddress";
            CompanyAddress.ReadOnly = true;
            // 
            // Meetingaddress
            // 
            Meetingaddress.DataPropertyName = "Meetingaddress";
            Meetingaddress.FillWeight = 24.77251f;
            Meetingaddress.HeaderText = "Địa điểm tổ chức";
            Meetingaddress.MinimumWidth = 6;
            Meetingaddress.Name = "Meetingaddress";
            Meetingaddress.ReadOnly = true;
            Meetingaddress.Visible = false;
            // 
            // StockCode
            // 
            StockCode.DataPropertyName = "StockCode";
            StockCode.HeaderText = "Mã CK";
            StockCode.MinimumWidth = 6;
            StockCode.Name = "StockCode";
            StockCode.ReadOnly = true;
            // 
            // meetingtime
            // 
            meetingtime.DataPropertyName = "meetingtime";
            DataGridViewCellStyle2.NullValue = null;
            meetingtime.DefaultCellStyle = DataGridViewCellStyle2;
            meetingtime.FillWeight = 38.75047f;
            meetingtime.HeaderText = "Thời gian tổ chức";
            meetingtime.MinimumWidth = 6;
            meetingtime.Name = "meetingtime";
            meetingtime.ReadOnly = true;
            // 
            // Period
            // 
            Period.DataPropertyName = "Period";
            Period.HeaderText = "Nhiệm kỳ";
            Period.MinimumWidth = 6;
            Period.Name = "Period";
            Period.ReadOnly = true;
            // 
            // MettingType
            // 
            MettingType.DataPropertyName = "MettingType";
            MettingType.HeaderText = "Loại hình";
            MettingType.MinimumWidth = 6;
            MettingType.Name = "MettingType";
            MettingType.ReadOnly = true;
            // 
            // YearMeeting
            // 
            YearMeeting.DataPropertyName = "YearMeeting";
            YearMeeting.HeaderText = "Năm";
            YearMeeting.MinimumWidth = 6;
            YearMeeting.Name = "YearMeeting";
            YearMeeting.ReadOnly = true;
            YearMeeting.Visible = false;
            // 
            // MeetingList
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 538);
            Controls.Add(DataGridView1);
            Controls.Add(StatusStrip1);
            Controls.Add(ToolStrip1);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "MeetingList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách cuộc họp";
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(MeetingList_Load);
            KeyUp += new KeyEventHandler(MeetingList_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStrip ToolStrip1;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStripTextBox ToolStripTextBox1;
        internal ToolStripButton ToolStripButton4;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal DataGridView DataGridView1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripButton ToolStripButton5;
        internal DataGridViewTextBoxColumn Meetingcode;
        internal DataGridViewTextBoxColumn Meetingname;
        internal DataGridViewTextBoxColumn CompanyName;
        internal DataGridViewTextBoxColumn CompanyAddress;
        internal DataGridViewTextBoxColumn Meetingaddress;
        internal DataGridViewTextBoxColumn StockCode;
        internal DataGridViewTextBoxColumn meetingtime;
        internal DataGridViewTextBoxColumn Period;
        internal DataGridViewTextBoxColumn MettingType;
        internal DataGridViewTextBoxColumn YearMeeting;
    }
}