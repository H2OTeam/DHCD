using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MatterVoteList : Form
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MatterVoteList));
            ToolStrip1 = new ToolStrip();
            ToolStripButton1 = new ToolStripButton();
            ToolStripButton1.Click += new EventHandler(ToolStripButton1_Click);
            ToolStripButton2 = new ToolStripButton();
            ToolStripButton2.Click += new EventHandler(ToolStripButton2_Click);
            ToolStripButton3 = new ToolStripButton();
            ToolStripButton3.Click += new EventHandler(ToolStripButton3_Click);
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripLabel1 = new ToolStripLabel();
            ToolStripTextBox1 = new ToolStripTextBox();
            ToolStripSeparator1 = new ToolStripSeparator();
            ToolStripLabel2 = new ToolStripLabel();
            ToolStripTextBox2 = new ToolStripTextBox();
            ToolStripButton4 = new ToolStripButton();
            ToolStripButton4.Click += new EventHandler(ToolStripButton4_Click);
            DataGridView1 = new DataGridView();
            DataGridView1.CellValueChanged += new DataGridViewCellEventHandler(DataGridView1_CellValueChanged);
            Mattercode = new DataGridViewTextBoxColumn();
            MatterName = new DataGridViewTextBoxColumn();
            HolderName = new DataGridViewTextBoxColumn();
            Delegatename = new DataGridViewTextBoxColumn();
            Voterights = new DataGridViewTextBoxColumn();
            agree = new DataGridViewCheckBoxColumn();
            Disagree = new DataGridViewCheckBoxColumn();
            Noidea = new DataGridViewCheckBoxColumn();
            DelegateCode = new DataGridViewTextBoxColumn();
            HolderCode = new DataGridViewTextBoxColumn();
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripSplitButton3 = new ToolStripSplitButton();
            ToolStripStatusLabel15 = new ToolStripStatusLabel();
            ToolStripStatusLabel16 = new ToolStripStatusLabel();
            StatusStrip2 = new StatusStrip();
            ToolStripStatusLabel3 = new ToolStripStatusLabel();
            ToolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripStatusLabel5 = new ToolStripStatusLabel();
            ToolStripStatusLabel6 = new ToolStripStatusLabel();
            ToolStripSplitButton1 = new ToolStripSplitButton();
            ToolStripStatusLabel7 = new ToolStripStatusLabel();
            ToolStripStatusLabel8 = new ToolStripStatusLabel();
            ToolStripStatusLabel9 = new ToolStripStatusLabel();
            ToolStripStatusLabel10 = new ToolStripStatusLabel();
            ToolStripSplitButton2 = new ToolStripSplitButton();
            ToolStripStatusLabel11 = new ToolStripStatusLabel();
            ToolStripStatusLabel12 = new ToolStripStatusLabel();
            ToolStripStatusLabel13 = new ToolStripStatusLabel();
            ToolStripStatusLabel14 = new ToolStripStatusLabel();
            ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            StatusStrip1.SuspendLayout();
            StatusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator2, ToolStripLabel1, ToolStripTextBox1, ToolStripSeparator1, ToolStripLabel2, ToolStripTextBox2, ToolStripButton4 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1136, 27);
            ToolStrip1.TabIndex = 11;
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
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 27);
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(130, 24);
            ToolStripLabel1.Text = "Mã v/đ biểu quyết";
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox1.Name = "ToolStripTextBox1";
            ToolStripTextBox1.Size = new Size(132, 27);
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 27);
            // 
            // ToolStripLabel2
            // 
            ToolStripLabel2.Name = "ToolStripLabel2";
            ToolStripLabel2.Size = new Size(65, 24);
            ToolStripLabel2.Text = "CMT/HC";
            // 
            // ToolStripTextBox2
            // 
            ToolStripTextBox2.Font = new Font("Segoe UI", 9.0f);
            ToolStripTextBox2.Name = "ToolStripTextBox2";
            ToolStripTextBox2.Size = new Size(132, 27);
            // 
            // ToolStripButton4
            // 
            ToolStripButton4.Image = My.Resources.Resources.Search;
            ToolStripButton4.ImageTransparentColor = Color.Magenta;
            ToolStripButton4.Name = "ToolStripButton4";
            ToolStripButton4.Size = new Size(58, 24);
            ToolStripButton4.Text = "Tìm";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Control;
            DataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Mattercode, MatterName, HolderName, Delegatename, Voterights, agree, Disagree, Noidea, DelegateCode, HolderCode });
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = SystemColors.Window;
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = DataGridViewCellStyle4;
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 27);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = SystemColors.Control;
            DataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(1136, 583);
            DataGridView1.TabIndex = 12;
            // 
            // Mattercode
            // 
            Mattercode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Mattercode.DataPropertyName = "Mattercode";
            Mattercode.FillWeight = 59.08628f;
            Mattercode.Frozen = true;
            Mattercode.HeaderText = "Mã vấn đề";
            Mattercode.MinimumWidth = 6;
            Mattercode.Name = "Mattercode";
            Mattercode.Width = 70;
            // 
            // MatterName
            // 
            MatterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MatterName.DataPropertyName = "MatterName";
            MatterName.FillWeight = 59.08628f;
            MatterName.Frozen = true;
            MatterName.HeaderText = "Tên vấn đề";
            MatterName.MinimumWidth = 6;
            MatterName.Name = "MatterName";
            MatterName.Width = 150;
            // 
            // HolderName
            // 
            HolderName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HolderName.DataPropertyName = "HolderName";
            HolderName.HeaderText = "Cổ đông";
            HolderName.MinimumWidth = 6;
            HolderName.Name = "HolderName";
            HolderName.Width = 180;
            // 
            // Delegatename
            // 
            Delegatename.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Delegatename.DataPropertyName = "Delegatename";
            Delegatename.HeaderText = "Cổ đông/Người đại diện";
            Delegatename.MinimumWidth = 6;
            Delegatename.Name = "Delegatename";
            Delegatename.Width = 150;
            // 
            // Voterights
            // 
            Voterights.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Voterights.DataPropertyName = "Voterights";
            DataGridViewCellStyle3.Format = "N0";
            Voterights.DefaultCellStyle = DataGridViewCellStyle3;
            Voterights.HeaderText = "Số quyền biểu quyết";
            Voterights.MinimumWidth = 6;
            Voterights.Name = "Voterights";
            Voterights.Width = 125;
            // 
            // agree
            // 
            agree.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            agree.DataPropertyName = "agree";
            agree.FillWeight = 59.08628f;
            agree.HeaderText = "Đồng ý";
            agree.MinimumWidth = 6;
            agree.Name = "agree";
            agree.Resizable = DataGridViewTriState.True;
            agree.SortMode = DataGridViewColumnSortMode.Automatic;
            agree.Width = 70;
            // 
            // Disagree
            // 
            Disagree.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Disagree.DataPropertyName = "Disagree";
            Disagree.HeaderText = "Không đồng ý";
            Disagree.MinimumWidth = 6;
            Disagree.Name = "Disagree";
            Disagree.Resizable = DataGridViewTriState.True;
            Disagree.SortMode = DataGridViewColumnSortMode.Automatic;
            Disagree.Width = 70;
            // 
            // Noidea
            // 
            Noidea.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Noidea.DataPropertyName = "Noidea";
            Noidea.HeaderText = "Không ý kiến";
            Noidea.MinimumWidth = 6;
            Noidea.Name = "Noidea";
            Noidea.Resizable = DataGridViewTriState.True;
            Noidea.SortMode = DataGridViewColumnSortMode.Automatic;
            Noidea.Width = 70;
            // 
            // DelegateCode
            // 
            DelegateCode.DataPropertyName = "DelegateCode";
            DelegateCode.HeaderText = "DelegateCode";
            DelegateCode.MinimumWidth = 6;
            DelegateCode.Name = "DelegateCode";
            DelegateCode.Visible = false;
            // 
            // HolderCode
            // 
            HolderCode.DataPropertyName = "HolderCode";
            HolderCode.HeaderText = "HolderCode";
            HolderCode.MinimumWidth = 6;
            HolderCode.Name = "HolderCode";
            HolderCode.Visible = false;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripSplitButton3, ToolStripStatusLabel15, ToolStripStatusLabel16 });
            StatusStrip1.Location = new Point(0, 584);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(1136, 26);
            StatusStrip1.TabIndex = 13;
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
            // ToolStripSplitButton3
            // 
            ToolStripSplitButton3.DisplayStyle = ToolStripItemDisplayStyle.None;
            ToolStripSplitButton3.Image = (Image)resources.GetObject("ToolStripSplitButton3.Image");
            ToolStripSplitButton3.ImageTransparentColor = Color.Magenta;
            ToolStripSplitButton3.Name = "ToolStripSplitButton3";
            ToolStripSplitButton3.Size = new Size(19, 24);
            ToolStripSplitButton3.Text = "ToolStripSplitButton3";
            // 
            // ToolStripStatusLabel15
            // 
            ToolStripStatusLabel15.Name = "ToolStripStatusLabel15";
            ToolStripStatusLabel15.Size = new Size(191, 20);
            ToolStripStatusLabel15.Text = "Tổng số quyền biểu quyết : ";
            // 
            // ToolStripStatusLabel16
            // 
            ToolStripStatusLabel16.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel16.Name = "ToolStripStatusLabel16";
            ToolStripStatusLabel16.Size = new Size(154, 20);
            ToolStripStatusLabel16.Text = "ToolStripStatusLabel16";
            // 
            // StatusStrip2
            // 
            StatusStrip2.ImageScalingSize = new Size(20, 20);
            StatusStrip2.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel3, ToolStripStatusLabel4, ToolStripStatusLabel5, ToolStripStatusLabel6, ToolStripSplitButton1, ToolStripStatusLabel7, ToolStripStatusLabel8, ToolStripStatusLabel9, ToolStripStatusLabel10, ToolStripSplitButton2, ToolStripStatusLabel11, ToolStripStatusLabel12, ToolStripStatusLabel13, ToolStripStatusLabel14 });
            StatusStrip2.Location = new Point(0, 560);
            StatusStrip2.Name = "StatusStrip2";
            StatusStrip2.Padding = new Padding(1, 0, 19, 0);
            StatusStrip2.Size = new Size(1136, 24);
            StatusStrip2.TabIndex = 14;
            StatusStrip2.Text = "StatusStrip2";
            // 
            // ToolStripStatusLabel3
            // 
            ToolStripStatusLabel3.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            ToolStripStatusLabel3.Size = new Size(70, 18);
            ToolStripStatusLabel3.Text = "Đồng ý : ";
            // 
            // ToolStripStatusLabel4
            // 
            ToolStripStatusLabel4.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            ToolStripStatusLabel4.Size = new Size(0, 18);
            // 
            // ToolStripStatusLabel5
            // 
            ToolStripStatusLabel5.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            ToolStripStatusLabel5.Size = new Size(0, 18);
            // 
            // ToolStripStatusLabel6
            // 
            ToolStripStatusLabel6.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            ToolStripStatusLabel6.Size = new Size(0, 18);
            // 
            // ToolStripSplitButton1
            // 
            ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            ToolStripSplitButton1.Image = (Image)resources.GetObject("ToolStripSplitButton1.Image");
            ToolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            ToolStripSplitButton1.Size = new Size(19, 22);
            ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel7
            // 
            ToolStripStatusLabel7.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel7.Name = "ToolStripStatusLabel7";
            ToolStripStatusLabel7.Size = new Size(115, 18);
            ToolStripStatusLabel7.Text = "Không đồng ý : ";
            // 
            // ToolStripStatusLabel8
            // 
            ToolStripStatusLabel8.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel8.Name = "ToolStripStatusLabel8";
            ToolStripStatusLabel8.Size = new Size(146, 18);
            ToolStripStatusLabel8.Text = "ToolStripStatusLabel8";
            // 
            // ToolStripStatusLabel9
            // 
            ToolStripStatusLabel9.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel9.Name = "ToolStripStatusLabel9";
            ToolStripStatusLabel9.Size = new Size(146, 18);
            ToolStripStatusLabel9.Text = "ToolStripStatusLabel9";
            // 
            // ToolStripStatusLabel10
            // 
            ToolStripStatusLabel10.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel10.Name = "ToolStripStatusLabel10";
            ToolStripStatusLabel10.Size = new Size(154, 18);
            ToolStripStatusLabel10.Text = "ToolStripStatusLabel10";
            // 
            // ToolStripSplitButton2
            // 
            ToolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.None;
            ToolStripSplitButton2.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripSplitButton2.Image = (Image)resources.GetObject("ToolStripSplitButton2.Image");
            ToolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            ToolStripSplitButton2.Size = new Size(19, 22);
            ToolStripSplitButton2.Text = "ToolStripSplitButton2";
            // 
            // ToolStripStatusLabel11
            // 
            ToolStripStatusLabel11.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel11.Name = "ToolStripStatusLabel11";
            ToolStripStatusLabel11.Size = new Size(107, 18);
            ToolStripStatusLabel11.Text = "Không ý kiến : ";
            // 
            // ToolStripStatusLabel12
            // 
            ToolStripStatusLabel12.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel12.Name = "ToolStripStatusLabel12";
            ToolStripStatusLabel12.Size = new Size(154, 18);
            ToolStripStatusLabel12.Text = "ToolStripStatusLabel12";
            // 
            // ToolStripStatusLabel13
            // 
            ToolStripStatusLabel13.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel13.Name = "ToolStripStatusLabel13";
            ToolStripStatusLabel13.Size = new Size(36, 18);
            ToolStripStatusLabel13.Text = "Tool";
            // 
            // ToolStripStatusLabel14
            // 
            ToolStripStatusLabel14.Font = new Font("Tahoma", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripStatusLabel14.Name = "ToolStripStatusLabel14";
            ToolStripStatusLabel14.Size = new Size(154, 18);
            ToolStripStatusLabel14.Text = "ToolStripStatusLabel14";
            // 
            // MatterVoteList
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 610);
            Controls.Add(StatusStrip2);
            Controls.Add(StatusStrip1);
            Controls.Add(DataGridView1);
            Controls.Add(ToolStrip1);
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "MatterVoteList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phiếu biểu quyết";
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            StatusStrip2.ResumeLayout(false);
            StatusStrip2.PerformLayout();
            Load += new EventHandler(MatterVoteList_Load);
            KeyUp += new KeyEventHandler(MatterVoteList_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStrip ToolStrip1;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStripTextBox ToolStripTextBox1;
        internal ToolStripButton ToolStripButton4;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal StatusStrip StatusStrip2;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripStatusLabel ToolStripStatusLabel7;
        internal ToolStripSplitButton ToolStripSplitButton3;
        internal ToolStripStatusLabel ToolStripStatusLabel15;
        internal ToolStripStatusLabel ToolStripStatusLabel16;
        internal ToolStripStatusLabel ToolStripStatusLabel8;
        internal ToolStripStatusLabel ToolStripStatusLabel9;
        internal ToolStripStatusLabel ToolStripStatusLabel10;
        internal ToolStripSplitButton ToolStripSplitButton2;
        internal ToolStripStatusLabel ToolStripStatusLabel11;
        internal ToolStripStatusLabel ToolStripStatusLabel12;
        internal ToolStripStatusLabel ToolStripStatusLabel13;
        internal ToolStripStatusLabel ToolStripStatusLabel14;
        internal DataGridViewTextBoxColumn Mattercode;
        internal DataGridViewTextBoxColumn MatterName;
        internal DataGridViewTextBoxColumn HolderName;
        internal DataGridViewTextBoxColumn Delegatename;
        internal DataGridViewTextBoxColumn Voterights;
        internal DataGridViewCheckBoxColumn agree;
        internal DataGridViewCheckBoxColumn Disagree;
        internal DataGridViewCheckBoxColumn Noidea;
        internal DataGridViewTextBoxColumn DelegateCode;
        internal DataGridViewTextBoxColumn HolderCode;
    }
}