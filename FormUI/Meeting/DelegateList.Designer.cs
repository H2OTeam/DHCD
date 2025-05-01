using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DelegateList : Form
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
            ToolStripTextBox1.KeyUp += new KeyEventHandler(ToolStripTextBox1_KeyUp);
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripLabel2 = new ToolStripLabel();
            ToolStripTextBox2 = new ToolStripTextBox();
            ToolStripTextBox2.KeyUp += new KeyEventHandler(ToolStripTextBox2_KeyUp);
            ToolStripButton4 = new ToolStripButton();
            ToolStripButton4.Click += new EventHandler(ToolStripButton4_Click);
            ToolStripSeparator3 = new ToolStripSeparator();
            ToolStripButton5 = new ToolStripButton();
            ToolStripButton5.Click += new EventHandler(ToolStripButton5_Click);
            ToolStripButton10 = new ToolStripButton();
            ToolStripButton10.Click += new EventHandler(ToolStripButton10_Click);
            ToolStripButton7 = new ToolStripButton();
            ToolStripButton7.Click += new EventHandler(ToolStripButton7_Click_1);
            InPhieuBauBKS = new ToolStripButton();
            InPhieuBauBKS.Click += new EventHandler(InPhieuBauBKS_Click);
            InPhieuBauHDQT = new ToolStripButton();
            InPhieuBauHDQT.Click += new EventHandler(InPhieuBauHDQT_Click);
            ToolStripButton8 = new ToolStripButton();
            ToolStripButton8.Click += new EventHandler(ToolStripButton8_Click);
            ToolStripButton6 = new ToolStripButton();
            ToolStripButton9 = new ToolStripButton();
            ToolStripButton9.Click += new EventHandler(ToolStripButton9_Click);
            DataGridView1 = new DataGridView();
            Delegatecode = new DataGridViewTextBoxColumn();
            Delegatename = new DataGridViewTextBoxColumn();
            IdentityCard = new DataGridViewTextBoxColumn();
            DelegateAddress = new DataGridViewTextBoxColumn();
            Voterights = new DataGridViewTextBoxColumn();
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripSplitButton1 = new ToolStripSplitButton();
            ToolStripStatusLabel3 = new ToolStripStatusLabel();
            ToolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator1, ToolStripLabel1, ToolStripTextBox1, ToolStripSeparator2, ToolStripLabel2, ToolStripTextBox2, ToolStripButton4, ToolStripButton10, ToolStripSeparator3, ToolStripButton5, ToolStripButton7, InPhieuBauBKS, InPhieuBauHDQT, ToolStripButton8, ToolStripButton6, ToolStripButton9 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1636, 39);
            ToolStrip1.TabIndex = 3;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            ToolStripButton1.Image = My.Resources.Resources.Add;
            ToolStripButton1.ImageTransparentColor = Color.Magenta;
            ToolStripButton1.Name = "ToolStripButton1";
            ToolStripButton1.Size = new Size(90, 36);
            ToolStripButton1.Text = "Thêm(A)";
            // 
            // ToolStripButton2
            // 
            ToolStripButton2.Image = My.Resources.Resources.Document;
            ToolStripButton2.ImageTransparentColor = Color.Magenta;
            ToolStripButton2.Name = "ToolStripButton2";
            ToolStripButton2.Size = new Size(76, 36);
            ToolStripButton2.Text = "Sửa(E)";
            // 
            // ToolStripButton3
            // 
            ToolStripButton3.Image = My.Resources.Resources.Delete;
            ToolStripButton3.ImageTransparentColor = Color.Magenta;
            ToolStripButton3.Name = "ToolStripButton3";
            ToolStripButton3.Size = new Size(80, 36);
            ToolStripButton3.Text = "Xóa(D)";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 39);
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(88, 36);
            ToolStripLabel1.Text = "Mã đại biểu";
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox1.Name = "ToolStripTextBox1";
            ToolStripTextBox1.Size = new Size(65, 39);
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 39);
            // 
            // ToolStripLabel2
            // 
            ToolStripLabel2.Name = "ToolStripLabel2";
            ToolStripLabel2.Size = new Size(91, 36);
            ToolStripLabel2.Text = "CCCD/GPKD";
            // 
            // ToolStripTextBox2
            // 
            ToolStripTextBox2.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox2.Name = "ToolStripTextBox2";
            ToolStripTextBox2.Size = new Size(132, 39);
            // 
            // ToolStripButton4
            // 
            ToolStripButton4.Image = My.Resources.Resources.Search;
            ToolStripButton4.ImageTransparentColor = Color.Magenta;
            ToolStripButton4.Name = "ToolStripButton4";
            ToolStripButton4.Size = new Size(58, 36);
            ToolStripButton4.Text = "Tìm";
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(6, 39);
            // 
            // ToolStripButton5
            // 
            ToolStripButton5.Image = My.Resources.Resources.Printer;
            ToolStripButton5.ImageTransparentColor = Color.Magenta;
            ToolStripButton5.Name = "ToolStripButton5";
            ToolStripButton5.Size = new Size(94, 36);
            ToolStripButton5.Text = "In thẻ BQ";
            // 
            // ToolStripButton10
            // 
            ToolStripButton10.Image = My.Resources.Resources.Printer;
            ToolStripButton10.ImageTransparentColor = Color.Magenta;
            ToolStripButton10.Name = "ToolStripButton10";
            ToolStripButton10.Size = new Size(124, 36);
            ToolStripButton10.Text = "P.XN tham dự";
            // 
            // ToolStripButton7
            // 
            ToolStripButton7.Image = My.Resources.Resources.Printer;
            ToolStripButton7.ImageTransparentColor = Color.Magenta;
            ToolStripButton7.Name = "ToolStripButton7";
            ToolStripButton7.Size = new Size(93, 36);
            ToolStripButton7.Text = "Phiếu BQ";
            // 
            // InPhieuBauBKS
            // 
            InPhieuBauBKS.Image = My.Resources.Resources.Printer;
            InPhieuBauBKS.ImageTransparentColor = Color.Magenta;
            InPhieuBauBKS.Name = "InPhieuBauBKS";
            InPhieuBauBKS.Size = new Size(103, 36);
            InPhieuBauBKS.Text = "P. Bầu BSK";
            // 
            // InPhieuBauHDQT
            // 
            InPhieuBauHDQT.Image = My.Resources.Resources.Printer;
            InPhieuBauHDQT.ImageTransparentColor = Color.Magenta;
            InPhieuBauHDQT.Name = "InPhieuBauHDQT";
            InPhieuBauHDQT.Size = new Size(117, 36);
            InPhieuBauHDQT.Text = "P. Bầu HDQT";
            // 
            // ToolStripButton8
            // 
            ToolStripButton8.Image = My.Resources.Resources.Printer;
            ToolStripButton8.ImageTransparentColor = Color.Magenta;
            ToolStripButton8.Name = "ToolStripButton8";
            ToolStripButton8.Size = new Size(105, 36);
            ToolStripButton8.Text = "Phiếu BQ 2";
            ToolStripButton8.Visible = false;
            // 
            // ToolStripButton6
            // 
            ToolStripButton6.Image = My.Resources.Resources.Printer;
            ToolStripButton6.ImageTransparentColor = Color.Magenta;
            ToolStripButton6.Name = "ToolStripButton6";
            ToolStripButton6.Size = new Size(110, 36);
            ToolStripButton6.Text = "Phiếu bầu 1";
            ToolStripButton6.Visible = false;
            // 
            // ToolStripButton9
            // 
            ToolStripButton9.Image = My.Resources.Resources.Printer;
            ToolStripButton9.ImageTransparentColor = Color.Magenta;
            ToolStripButton9.Name = "ToolStripButton9";
            ToolStripButton9.Size = new Size(110, 36);
            ToolStripButton9.Text = "Phiếu bầu 2";
            ToolStripButton9.Visible = false;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delegatecode, Delegatename, IdentityCard, DelegateAddress, Voterights });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 49);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(1636, 793);
            DataGridView1.TabIndex = 6;
            // 
            // Delegatecode
            // 
            Delegatecode.DataPropertyName = "Delegatecode";
            Delegatecode.FillWeight = 59.08628f;
            Delegatecode.HeaderText = "Mã đại biểu";
            Delegatecode.MinimumWidth = 6;
            Delegatecode.Name = "Delegatecode";
            Delegatecode.ReadOnly = true;
            // 
            // Delegatename
            // 
            Delegatename.DataPropertyName = "Delegatename";
            Delegatename.FillWeight = 59.08628f;
            Delegatename.HeaderText = "Tên đại biểu";
            Delegatename.MinimumWidth = 6;
            Delegatename.Name = "Delegatename";
            Delegatename.ReadOnly = true;
            // 
            // IdentityCard
            // 
            IdentityCard.DataPropertyName = "IdentityCard";
            IdentityCard.FillWeight = 59.08628f;
            IdentityCard.HeaderText = "CMT/GPKD";
            IdentityCard.MinimumWidth = 6;
            IdentityCard.Name = "IdentityCard";
            IdentityCard.ReadOnly = true;
            // 
            // DelegateAddress
            // 
            DelegateAddress.DataPropertyName = "DelegateAddress";
            DelegateAddress.FillWeight = 200.0f;
            DelegateAddress.HeaderText = "Địa chỉ";
            DelegateAddress.MinimumWidth = 6;
            DelegateAddress.Name = "DelegateAddress";
            DelegateAddress.ReadOnly = true;
            // 
            // Voterights
            // 
            Voterights.DataPropertyName = "Voterights";
            DataGridViewCellStyle2.Format = "N0";
            DataGridViewCellStyle2.NullValue = null;
            Voterights.DefaultCellStyle = DataGridViewCellStyle2;
            Voterights.FillWeight = 59.08628f;
            Voterights.HeaderText = "Tổng  quyền b.quyết";
            Voterights.MinimumWidth = 6;
            Voterights.Name = "Voterights";
            Voterights.ReadOnly = true;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripSplitButton1, ToolStripStatusLabel3, ToolStripStatusLabel4 });
            StatusStrip1.Location = new Point(0, 649);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(1309, 24);
            StatusStrip1.TabIndex = 7;
            StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(131, 18);
            ToolStripStatusLabel1.Text = "Số lượng bản ghi : ";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(0, 18);
            // 
            // ToolStripSplitButton1
            // 
            ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            ToolStripSplitButton1.Size = new Size(19, 22);
            ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel3
            // 
            ToolStripStatusLabel3.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            ToolStripStatusLabel3.Size = new Size(180, 18);
            ToolStripStatusLabel3.Text = "Tổng số quyền biểu quyết";
            // 
            // ToolStripStatusLabel4
            // 
            ToolStripStatusLabel4.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            ToolStripStatusLabel4.Size = new Size(146, 18);
            ToolStripStatusLabel4.Text = "ToolStripStatusLabel4";
            // 
            // DelegateList
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 673);
            Controls.Add(StatusStrip1);
            Controls.Add(DataGridView1);
            Controls.Add(ToolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "DelegateList";
            Text = "Danh sách đại biểu";
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            Load += new EventHandler(DelegateList_Load);
            KeyUp += new KeyEventHandler(DelegateList_KeyUp);
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
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal ToolStripButton ToolStripButton4;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripButton ToolStripButton8;
        internal ToolStripButton ToolStripButton9;
        internal ToolStripButton ToolStripButton10;
        internal DataGridViewTextBoxColumn Delegatecode;
        internal DataGridViewTextBoxColumn Delegatename;
        internal DataGridViewTextBoxColumn IdentityCard;
        internal DataGridViewTextBoxColumn DelegateAddress;
        internal DataGridViewTextBoxColumn Voterights;
        internal ToolStripButton InPhieuBauBKS;
        internal ToolStripButton InPhieuBauHDQT;
        internal ToolStripButton ToolStripButton7;
    }
}