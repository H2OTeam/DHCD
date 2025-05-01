using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DelegateListForSelect : Form
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
            DataGridView1 = new DataGridView();
            DataGridView1.KeyDown += new KeyEventHandler(DataGridView1_KeyDown);
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            delegatecode = new DataGridViewTextBoxColumn();
            DelegateName = new DataGridViewTextBoxColumn();
            IdentityCard = new DataGridViewTextBoxColumn();
            DelegateAddress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridViewCellStyle1.BackColor = SystemColors.Info;
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { delegatecode, DelegateName, IdentityCard, DelegateAddress });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(0, 0);
            DataGridView1.Margin = new Padding(4, 4, 4, 4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(833, 357);
            DataGridView1.TabIndex = 5;
            // 
            // StatusStrip1
            // 
            StatusStrip1.ImageScalingSize = new Size(20, 20);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            StatusStrip1.Location = new Point(0, 331);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 19, 0);
            StatusStrip1.Size = new Size(833, 26);
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
            // delegatecode
            // 
            delegatecode.DataPropertyName = "delegatecode";
            delegatecode.FillWeight = 59.08628f;
            delegatecode.HeaderText = "Mã đại biểu";
            delegatecode.MinimumWidth = 6;
            delegatecode.Name = "delegatecode";
            delegatecode.ReadOnly = true;
            delegatecode.Width = 125;
            // 
            // DelegateName
            // 
            DelegateName.DataPropertyName = "DelegateName";
            DelegateName.FillWeight = 59.08628f;
            DelegateName.HeaderText = "Tên đại biểu";
            DelegateName.MinimumWidth = 6;
            DelegateName.Name = "DelegateName";
            DelegateName.ReadOnly = true;
            DelegateName.Width = 120;
            // 
            // IdentityCard
            // 
            IdentityCard.DataPropertyName = "IdentityCard";
            IdentityCard.FillWeight = 59.08628f;
            IdentityCard.HeaderText = "CCCD/GPKD";
            IdentityCard.MinimumWidth = 6;
            IdentityCard.Name = "IdentityCard";
            IdentityCard.ReadOnly = true;
            IdentityCard.Width = 94;
            // 
            // DelegateAddress
            // 
            DelegateAddress.DataPropertyName = "DelegateAddress";
            DelegateAddress.FillWeight = 200.0f;
            DelegateAddress.HeaderText = "Địa chỉ";
            DelegateAddress.MinimumWidth = 6;
            DelegateAddress.Name = "DelegateAddress";
            DelegateAddress.ReadOnly = true;
            DelegateAddress.Width = 300;
            // 
            // DelegateListForSelect
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 357);
            Controls.Add(StatusStrip1);
            Controls.Add(DataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "DelegateListForSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn đại biểu";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            Load += new EventHandler(HolderList_Load);
            KeyUp += new KeyEventHandler(HolderListForSelect_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal DataGridViewTextBoxColumn delegatecode;
        internal DataGridViewTextBoxColumn DelegateName;
        internal DataGridViewTextBoxColumn IdentityCard;
        internal DataGridViewTextBoxColumn DelegateAddress;
    }
}