using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class HolderList : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(HolderList));
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
            ToolStripTextBox1.KeyUp += new KeyEventHandler(ToolStripTextBox1_KeyUp);
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripLabel2 = new ToolStripLabel();
            ToolStripTextBox2 = new ToolStripTextBox();
            ToolStripTextBox2.KeyUp += new KeyEventHandler(ToolStripTextBox2_KeyUp);
            ToolStripButton4 = new ToolStripButton();
            ToolStripButton4.Click += new EventHandler(ToolStripButton4_Click);
            ToolStripButton6 = new ToolStripButton();
            ToolStripButton6.Click += new EventHandler(ToolStripButton6_Click);
            ToolStripButton5 = new ToolStripButton();
            ToolStripButton5.Click += new EventHandler(ToolStripButton5_Click);
            DataGridView1 = new DataGridView();
            holdercode = new DataGridViewTextBoxColumn();
            HolderName = new DataGridViewTextBoxColumn();
            HolderIdentity = new DataGridViewTextBoxColumn();
            IdentityDate = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            HolderAddress = new DataGridViewTextBoxColumn();
            NotVSD = new DataGridViewTextBoxColumn();
            Shares = new DataGridViewTextBoxColumn();
            Voterights = new DataGridViewTextBoxColumn();
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripSplitButton1 = new ToolStripSplitButton();
            ToolStripStatusLabel3 = new ToolStripStatusLabel();
            ToolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripSplitButton2 = new ToolStripSplitButton();
            ToolStripStatusLabel5 = new ToolStripStatusLabel();
            ToolStripStatusLabel6 = new ToolStripStatusLabel();
            ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator1, ToolStripLabel1, ToolStripTextBox1, ToolStripSeparator2, ToolStripLabel2, ToolStripTextBox2, ToolStripButton4, ToolStripButton6, ToolStripButton5 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1109, 31);
            ToolStrip1.TabIndex = 2;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            ToolStripButton1.Image = My.Resources.Resources.Add;
            ToolStripButton1.ImageTransparentColor = Color.Magenta;
            ToolStripButton1.Name = "ToolStripButton1";
            ToolStripButton1.Size = new Size(90, 28);
            ToolStripButton1.Text = "Thêm(A)";
            // 
            // ToolStripButton2
            // 
            ToolStripButton2.Image = My.Resources.Resources.Document;
            ToolStripButton2.ImageTransparentColor = Color.Magenta;
            ToolStripButton2.Name = "ToolStripButton2";
            ToolStripButton2.Size = new Size(76, 28);
            ToolStripButton2.Text = "Sửa(E)";
            // 
            // ToolStripButton3
            // 
            ToolStripButton3.Image = My.Resources.Resources.Delete;
            ToolStripButton3.ImageTransparentColor = Color.Magenta;
            ToolStripButton3.Name = "ToolStripButton3";
            ToolStripButton3.Size = new Size(80, 28);
            ToolStripButton3.Text = "Xóa(D)";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 31);
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(89, 28);
            ToolStripLabel1.Text = "Mã cổ đông";
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox1.Name = "ToolStripTextBox1";
            ToolStripTextBox1.Size = new Size(132, 31);
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 31);
            // 
            // ToolStripLabel2
            // 
            ToolStripLabel2.Name = "ToolStripLabel2";
            ToolStripLabel2.Size = new Size(91, 28);
            ToolStripLabel2.Text = "CCCD/GPKD";
            // 
            // ToolStripTextBox2
            // 
            ToolStripTextBox2.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox2.Name = "ToolStripTextBox2";
            ToolStripTextBox2.Size = new Size(132, 31);
            // 
            // ToolStripButton4
            // 
            ToolStripButton4.Image = My.Resources.Resources.Search;
            ToolStripButton4.ImageTransparentColor = Color.Magenta;
            ToolStripButton4.Name = "ToolStripButton4";
            ToolStripButton4.Size = new Size(58, 28);
            ToolStripButton4.Text = "Tìm";
            // 
            // ToolStripButton6
            // 
            ToolStripButton6.Image = My.Resources.Resources.Printer;
            ToolStripButton6.ImageTransparentColor = Color.Magenta;
            ToolStripButton6.Name = "ToolStripButton6";
            ToolStripButton6.Size = new Size(118, 28);
            ToolStripButton6.Text = "In tài liệu..(P)";
            ToolStripButton6.Visible = false;
            // 
            // ToolStripButton5
            // 
            ToolStripButton5.Image = My.Resources.Resources.Printer;
            ToolStripButton5.ImageTransparentColor = Color.Magenta;
            ToolStripButton5.Name = "ToolStripButton5";
            ToolStripButton5.Size = new Size(109, 28);
            ToolStripButton5.Text = "In nhiều CĐ";
            ToolStripButton5.Visible = false;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { holdercode, HolderName, HolderIdentity, IdentityDate, Phone, email, HolderAddress, NotVSD, Shares, Voterights });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 31);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(1109, 541);
            DataGridView1.TabIndex = 5;
            // 
            // holdercode
            // 
            holdercode.DataPropertyName = "holdercode";
            holdercode.FillWeight = 59.08628f;
            holdercode.HeaderText = "Mã cổ đông";
            holdercode.MinimumWidth = 6;
            holdercode.Name = "holdercode";
            holdercode.ReadOnly = true;
            holdercode.Width = 50;
            // 
            // HolderName
            // 
            HolderName.DataPropertyName = "HolderName";
            HolderName.FillWeight = 59.08628f;
            HolderName.HeaderText = "Tên cổ đông";
            HolderName.MinimumWidth = 6;
            HolderName.Name = "HolderName";
            HolderName.ReadOnly = true;
            HolderName.Width = 120;
            // 
            // HolderIdentity
            // 
            HolderIdentity.DataPropertyName = "HolderIdentity";
            HolderIdentity.FillWeight = 59.08628f;
            HolderIdentity.HeaderText = "Số đăng ký sở hữu";
            HolderIdentity.MinimumWidth = 6;
            HolderIdentity.Name = "HolderIdentity";
            HolderIdentity.ReadOnly = true;
            HolderIdentity.Width = 94;
            // 
            // IdentityDate
            // 
            IdentityDate.DataPropertyName = "IdentityDate";
            IdentityDate.HeaderText = "Ngày Cấp";
            IdentityDate.MinimumWidth = 6;
            IdentityDate.Name = "IdentityDate";
            IdentityDate.ReadOnly = true;
            IdentityDate.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 125;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // HolderAddress
            // 
            HolderAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            HolderAddress.DataPropertyName = "HolderAddress";
            HolderAddress.FillWeight = 200.0f;
            HolderAddress.HeaderText = "Địa chỉ";
            HolderAddress.MinimumWidth = 6;
            HolderAddress.Name = "HolderAddress";
            HolderAddress.ReadOnly = true;
            HolderAddress.Width = 58;
            // 
            // NotVSD
            // 
            NotVSD.DataPropertyName = "NotVSD";
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle2.Format = "N0";
            DataGridViewCellStyle2.NullValue = "0";
            NotVSD.DefaultCellStyle = DataGridViewCellStyle2;
            NotVSD.HeaderText = "Chư Lưu Ký";
            NotVSD.MinimumWidth = 6;
            NotVSD.Name = "NotVSD";
            NotVSD.ReadOnly = true;
            NotVSD.Width = 125;
            // 
            // Shares
            // 
            Shares.DataPropertyName = "Shares";
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle3.Format = "N0";
            DataGridViewCellStyle3.NullValue = "0";
            Shares.DefaultCellStyle = DataGridViewCellStyle3;
            Shares.FillWeight = 59.08628f;
            Shares.HeaderText = "Số cổ phần";
            Shares.MinimumWidth = 6;
            Shares.Name = "Shares";
            Shares.ReadOnly = true;
            Shares.Width = 94;
            // 
            // Voterights
            // 
            Voterights.DataPropertyName = "Voterights";
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle4.Format = "N0";
            DataGridViewCellStyle4.NullValue = "0";
            Voterights.DefaultCellStyle = DataGridViewCellStyle4;
            Voterights.FillWeight = 59.08628f;
            Voterights.HeaderText = "Số quyền biểu quyết";
            Voterights.MinimumWidth = 6;
            Voterights.Name = "Voterights";
            Voterights.ReadOnly = true;
            Voterights.Width = 94;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripSplitButton1, ToolStripStatusLabel3, ToolStripStatusLabel4, ToolStripSplitButton2, ToolStripStatusLabel5, ToolStripStatusLabel6 });
            StatusStrip1.Location = new Point(0, 546);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(1109, 26);
            StatusStrip1.TabIndex = 6;
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
            // ToolStripSplitButton1
            // 
            ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            ToolStripSplitButton1.Size = new Size(19, 24);
            ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel3
            // 
            ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            ToolStripStatusLabel3.Size = new Size(130, 20);
            ToolStripStatusLabel3.Text = "Tổng số cổ phần : ";
            // 
            // ToolStripStatusLabel4
            // 
            ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            ToolStripStatusLabel4.Size = new Size(0, 20);
            // 
            // ToolStripSplitButton2
            // 
            ToolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.None;
            ToolStripSplitButton2.Image = (Image)resources.GetObject("ToolStripSplitButton2.Image");
            ToolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            ToolStripSplitButton2.Size = new Size(19, 24);
            ToolStripSplitButton2.Text = "ToolStripSplitButton2";
            // 
            // ToolStripStatusLabel5
            // 
            ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            ToolStripStatusLabel5.Size = new Size(191, 20);
            ToolStripStatusLabel5.Text = "Tổng số quyền biểu quyết : ";
            // 
            // ToolStripStatusLabel6
            // 
            ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            ToolStripStatusLabel6.Size = new Size(0, 20);
            // 
            // HolderList
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 572);
            Controls.Add(StatusStrip1);
            Controls.Add(DataGridView1);
            Controls.Add(ToolStrip1);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "HolderList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách cổ đông";
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            Load += new EventHandler(HolderList_Load);
            KeyUp += new KeyEventHandler(HolderList_KeyUp);
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
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton2;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        internal DataGridViewTextBoxColumn holdercode;
        internal DataGridViewTextBoxColumn HolderName;
        internal DataGridViewTextBoxColumn HolderIdentity;
        internal DataGridViewTextBoxColumn IdentityDate;
        internal DataGridViewTextBoxColumn Phone;
        internal DataGridViewTextBoxColumn email;
        internal DataGridViewTextBoxColumn HolderAddress;
        internal DataGridViewTextBoxColumn NotVSD;
        internal DataGridViewTextBoxColumn Shares;
        internal DataGridViewTextBoxColumn Voterights;
    }
}