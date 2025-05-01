using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MatterList : Form
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
            ToolStrip1 = new ToolStrip();
            ToolStripButton1 = new ToolStripButton();
            ToolStripButton1.Click += new EventHandler(ToolStripButton1_Click);
            ToolStripButton2 = new ToolStripButton();
            ToolStripButton2.Click += new EventHandler(ToolStripButton2_Click);
            ToolStripButton3 = new ToolStripButton();
            ToolStripButton3.Click += new EventHandler(ToolStripButton3_Click);
            ToolStripSeparator2 = new ToolStripSeparator();
            DataGridView1 = new DataGridView();
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            Mattercode = new DataGridViewTextBoxColumn();
            MatterName = new DataGridViewTextBoxColumn();
            MatterDescription = new DataGridViewTextBoxColumn();
            ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator2 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(975, 27);
            ToolStrip1.TabIndex = 3;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            ToolStripButton1.Image = My.Resources.Resources.Add;
            ToolStripButton1.ImageTransparentColor = Color.Magenta;
            ToolStripButton1.Name = "ToolStripButton1";
            ToolStripButton1.Size = new Size(70, 24);
            ToolStripButton1.Text = "Thêm";
            // 
            // ToolStripButton2
            // 
            ToolStripButton2.Image = My.Resources.Resources.Document;
            ToolStripButton2.ImageTransparentColor = Color.Magenta;
            ToolStripButton2.Name = "ToolStripButton2";
            ToolStripButton2.Size = new Size(58, 24);
            ToolStripButton2.Text = "Sửa";
            // 
            // ToolStripButton3
            // 
            ToolStripButton3.Image = My.Resources.Resources.Delete;
            ToolStripButton3.ImageTransparentColor = Color.Magenta;
            ToolStripButton3.Name = "ToolStripButton3";
            ToolStripButton3.Size = new Size(59, 24);
            ToolStripButton3.Text = "Xóa";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 27);
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Mattercode, MatterName, MatterDescription });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 27);
            DataGridView1.Margin = new Padding(4, 4, 4, 4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(975, 485);
            DataGridView1.TabIndex = 6;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            StatusStrip1.Location = new Point(0, 486);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(975, 26);
            StatusStrip1.TabIndex = 7;
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
            // Mattercode
            // 
            Mattercode.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Mattercode.DataPropertyName = "Mattercode";
            Mattercode.FillWeight = 59.08628f;
            Mattercode.HeaderText = "Mã vấn đề";
            Mattercode.MinimumWidth = 6;
            Mattercode.Name = "Mattercode";
            Mattercode.ReadOnly = true;
            Mattercode.Width = 103;
            // 
            // MatterName
            // 
            MatterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MatterName.DataPropertyName = "MatterName";
            MatterName.FillWeight = 59.08628f;
            MatterName.HeaderText = "Tên vấn đề";
            MatterName.MinimumWidth = 6;
            MatterName.Name = "MatterName";
            MatterName.ReadOnly = true;
            MatterName.Width = 109;
            // 
            // MatterDescription
            // 
            MatterDescription.DataPropertyName = "MatterDescription";
            MatterDescription.FillWeight = 59.08628f;
            MatterDescription.HeaderText = "Diễn giải";
            MatterDescription.MinimumWidth = 6;
            MatterDescription.Name = "MatterDescription";
            MatterDescription.ReadOnly = true;
            // 
            // MatterList
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 512);
            Controls.Add(StatusStrip1);
            Controls.Add(DataGridView1);
            Controls.Add(ToolStrip1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MatterList";
            Text = "Danh sách vấn đề biểu quyết";
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            Load += new EventHandler(MatterList_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStrip ToolStrip1;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripSeparator ToolStripSeparator2;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal DataGridViewTextBoxColumn Mattercode;
        internal DataGridViewTextBoxColumn MatterName;
        internal DataGridViewTextBoxColumn MatterDescription;
    }
}