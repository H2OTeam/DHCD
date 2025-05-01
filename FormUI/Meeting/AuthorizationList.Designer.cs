using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AuthorizationList : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationList));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            ToolStrip1 = new ToolStrip();
            ToolStripButton1 = new ToolStripButton();
            ToolStripButton1.Click += new EventHandler(ToolStripButton1_Click);
            ToolStripButton2 = new ToolStripButton();
            ToolStripButton2.Click += new EventHandler(ToolStripButton2_Click);
            ToolStripButton3 = new ToolStripButton();
            ToolStripButton3.Click += new EventHandler(ToolStripButton3_Click);
            ToolStripSeparator1 = new ToolStripSeparator();
            ToolStripLabel2 = new ToolStripLabel();
            ToolStripTextBox2 = new ToolStripTextBox();
            ToolStripTextBox2.KeyUp += new KeyEventHandler(ToolStripTextBox2_KeyUp);
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripLabel4 = new ToolStripLabel();
            ToolStripTextBox4 = new ToolStripTextBox();
            ToolStripTextBox4.KeyUp += new KeyEventHandler(ToolStripTextBox4_KeyUp);
            ToolStripSeparator3 = new ToolStripSeparator();
            ToolStripButton5 = new ToolStripButton();
            ToolStripButton5.Click += new EventHandler(ToolStripButton5_Click);
            ToolStripButton6 = new ToolStripButton();
            ToolStripButton6.Click += new EventHandler(ToolStripButton6_Click);
            ToolStripButton4 = new ToolStripButton();
            ToolStripButton4.Click += new EventHandler(ToolStripButton4_Click);
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripSplitButton1 = new ToolStripSplitButton();
            ToolStripStatusLabel3 = new ToolStripStatusLabel();
            ToolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripSplitButton2 = new ToolStripSplitButton();
            ToolStripStatusLabel5 = new ToolStripStatusLabel();
            ToolStripStatusLabel6 = new ToolStripStatusLabel();
            DataGridView1 = new DataGridView();
            Holdercode = new DataGridViewTextBoxColumn();
            holdername = new DataGridViewTextBoxColumn();
            HolderIdentity = new DataGridViewTextBoxColumn();
            HolderAddress = new DataGridViewTextBoxColumn();
            Delegatecode = new DataGridViewTextBoxColumn();
            Delegatename = new DataGridViewTextBoxColumn();
            IdentityCard = new DataGridViewTextBoxColumn();
            DelegateAddress = new DataGridViewTextBoxColumn();
            voterights = new DataGridViewTextBoxColumn();
            DelegateRight = new DataGridViewTextBoxColumn();
            ToolStrip1.SuspendLayout();
            StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator1, ToolStripLabel2, ToolStripTextBox2, ToolStripSeparator2, ToolStripLabel4, ToolStripTextBox4, ToolStripSeparator3, ToolStripButton5, ToolStripButton6, ToolStripButton4 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1253, 27);
            ToolStrip1.TabIndex = 4;
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
            // ToolStripLabel2
            // 
            ToolStripLabel2.Name = "ToolStripLabel2";
            ToolStripLabel2.Size = new Size(131, 24);
            ToolStripLabel2.Text = "CCCD/HC đại biểu";
            // 
            // ToolStripTextBox2
            // 
            ToolStripTextBox2.Name = "ToolStripTextBox2";
            ToolStripTextBox2.Size = new Size(132, 27);
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 27);
            // 
            // ToolStripLabel4
            // 
            ToolStripLabel4.Name = "ToolStripLabel4";
            ToolStripLabel4.Size = new Size(176, 24);
            ToolStripLabel4.Text = "CCCD/HC/GPKD cổ đông";
            // 
            // ToolStripTextBox4
            // 
            ToolStripTextBox4.Name = "ToolStripTextBox4";
            ToolStripTextBox4.Size = new Size(132, 27);
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(6, 27);
            // 
            // ToolStripButton5
            // 
            ToolStripButton5.Image = My.Resources.Resources.Search;
            ToolStripButton5.ImageTransparentColor = Color.Magenta;
            ToolStripButton5.Name = "ToolStripButton5";
            ToolStripButton5.Size = new Size(58, 24);
            ToolStripButton5.Text = "Tìm";
            // 
            // ToolStripButton6
            // 
            ToolStripButton6.Image = My.Resources.Resources.Search;
            ToolStripButton6.ImageTransparentColor = Color.Magenta;
            ToolStripButton6.Name = "ToolStripButton6";
            ToolStripButton6.Size = new Size(94, 24);
            ToolStripButton6.Text = "In thẻ BQ";
            ToolStripButton6.Visible = false;
            // 
            // ToolStripButton4
            // 
            ToolStripButton4.Image = My.Resources.Resources.Search;
            ToolStripButton4.ImageTransparentColor = Color.Magenta;
            ToolStripButton4.Name = "ToolStripButton4";
            ToolStripButton4.Size = new Size(153, 24);
            ToolStripButton4.Text = "In giấy x.nhận t.dự";
            ToolStripButton4.Visible = false;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripSplitButton1, ToolStripStatusLabel3, ToolStripStatusLabel4, ToolStripSplitButton2, ToolStripStatusLabel5, ToolStripStatusLabel6 });
            StatusStrip1.Location = new Point(0, 544);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(1253, 26);
            StatusStrip1.TabIndex = 8;
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
            ToolStripSplitButton1.Image = (Image)resources.GetObject("ToolStripSplitButton1.Image");
            ToolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            ToolStripSplitButton1.Size = new Size(19, 24);
            ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel3
            // 
            ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            ToolStripStatusLabel3.Size = new Size(242, 20);
            ToolStripStatusLabel3.Text = "Tổng số quyền biểu quyết của CĐ : ";
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
            ToolStripStatusLabel5.Size = new Size(292, 20);
            ToolStripStatusLabel5.Text = "Tổng số quyền biểu quyết được ủy quyền : ";
            // 
            // ToolStripStatusLabel6
            // 
            ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            ToolStripStatusLabel6.Size = new Size(153, 20);
            ToolStripStatusLabel6.Text = "ToolStripStatusLabel6";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Holdercode, holdername, HolderIdentity, HolderAddress, Delegatecode, Delegatename, IdentityCard, DelegateAddress, voterights, DelegateRight });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 27);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(1253, 517);
            DataGridView1.TabIndex = 9;
            // 
            // Holdercode
            // 
            Holdercode.DataPropertyName = "Holdercode";
            Holdercode.FillWeight = 11.21656f;
            Holdercode.HeaderText = "Mã cổ đông";
            Holdercode.MinimumWidth = 80;
            Holdercode.Name = "Holdercode";
            Holdercode.ReadOnly = true;
            // 
            // holdername
            // 
            holdername.DataPropertyName = "holdername";
            holdername.FillWeight = 196.5355f;
            holdername.HeaderText = "Tên cổ đông";
            holdername.MinimumWidth = 150;
            holdername.Name = "holdername";
            holdername.ReadOnly = true;
            // 
            // HolderIdentity
            // 
            HolderIdentity.DataPropertyName = "HolderIdentity";
            DataGridViewCellStyle2.Format = "N0";
            DataGridViewCellStyle2.NullValue = null;
            HolderIdentity.DefaultCellStyle = DataGridViewCellStyle2;
            HolderIdentity.FillWeight = 97.21734f;
            HolderIdentity.HeaderText = "CCCD/HC/GPKD CĐ";
            HolderIdentity.MinimumWidth = 100;
            HolderIdentity.Name = "HolderIdentity";
            HolderIdentity.ReadOnly = true;
            // 
            // HolderAddress
            // 
            HolderAddress.DataPropertyName = "HolderAddress";
            HolderAddress.HeaderText = "HolderAddress";
            HolderAddress.MinimumWidth = 6;
            HolderAddress.Name = "HolderAddress";
            HolderAddress.ReadOnly = true;
            HolderAddress.Visible = false;
            // 
            // Delegatecode
            // 
            Delegatecode.DataPropertyName = "Delegatecode";
            Delegatecode.FillWeight = 74.75592f;
            Delegatecode.HeaderText = "Mã đại biểu";
            Delegatecode.MinimumWidth = 80;
            Delegatecode.Name = "Delegatecode";
            Delegatecode.ReadOnly = true;
            // 
            // Delegatename
            // 
            Delegatename.DataPropertyName = "Delegatename";
            Delegatename.FillWeight = 6.621332f;
            Delegatename.HeaderText = "Tên đại biểu";
            Delegatename.MinimumWidth = 200;
            Delegatename.Name = "Delegatename";
            Delegatename.ReadOnly = true;
            // 
            // IdentityCard
            // 
            IdentityCard.DataPropertyName = "IdentityCard";
            IdentityCard.FillWeight = 52.32525f;
            IdentityCard.HeaderText = "CMT/HC ĐB";
            IdentityCard.MinimumWidth = 100;
            IdentityCard.Name = "IdentityCard";
            IdentityCard.ReadOnly = true;
            // 
            // DelegateAddress
            // 
            DelegateAddress.DataPropertyName = "DelegateAddress";
            DelegateAddress.HeaderText = "DelegateAddress";
            DelegateAddress.MinimumWidth = 6;
            DelegateAddress.Name = "DelegateAddress";
            DelegateAddress.ReadOnly = true;
            DelegateAddress.Visible = false;
            // 
            // voterights
            // 
            voterights.DataPropertyName = "voterights";
            DataGridViewCellStyle3.Format = "N0";
            voterights.DefaultCellStyle = DataGridViewCellStyle3;
            voterights.FillWeight = 128.2284f;
            voterights.HeaderText = "Số quyền BQ CĐ";
            voterights.MinimumWidth = 40;
            voterights.Name = "voterights";
            voterights.ReadOnly = true;
            // 
            // DelegateRight
            // 
            DelegateRight.DataPropertyName = "DelegateRight";
            DataGridViewCellStyle4.Format = "N0";
            DelegateRight.DefaultCellStyle = DataGridViewCellStyle4;
            DelegateRight.FillWeight = 169.4455f;
            DelegateRight.HeaderText = "Số quyền BQ ủy quyền";
            DelegateRight.MinimumWidth = 40;
            DelegateRight.Name = "DelegateRight";
            DelegateRight.ReadOnly = true;
            // 
            // AuthorizationList
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 570);
            Controls.Add(DataGridView1);
            Controls.Add(StatusStrip1);
            Controls.Add(ToolStrip1);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "AuthorizationList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách ủy quyền";
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            Load += new EventHandler(AuthorizationList_Load);
            KeyUp += new KeyEventHandler(AuthorizationList_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStrip ToolStrip1;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel4;
        internal ToolStripTextBox ToolStripTextBox4;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripButton ToolStripButton4;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal DataGridView DataGridView1;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton2;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        internal DataGridViewTextBoxColumn Holdercode;
        internal DataGridViewTextBoxColumn holdername;
        internal DataGridViewTextBoxColumn HolderIdentity;
        internal DataGridViewTextBoxColumn HolderAddress;
        internal DataGridViewTextBoxColumn Delegatecode;
        internal DataGridViewTextBoxColumn Delegatename;
        internal DataGridViewTextBoxColumn IdentityCard;
        internal DataGridViewTextBoxColumn DelegateAddress;
        internal DataGridViewTextBoxColumn voterights;
        internal DataGridViewTextBoxColumn DelegateRight;
    }
}