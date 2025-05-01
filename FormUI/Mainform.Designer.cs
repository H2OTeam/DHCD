using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Mainform : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            MenuStrip1 = new MenuStrip();
            HệThốngToolStripMenuItem = new ToolStripMenuItem();
            CuộcHọpToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchCuộcHọpToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchCuộcHọpToolStripMenuItem.Click += new EventHandler(DanhSáchCuộcHọpToolStripMenuItem_Click);
            DanhSáchCổĐôngToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchCổĐôngToolStripMenuItem.Click += new EventHandler(DanhSáchCổĐôngToolStripMenuItem_Click);
            DanhSáchĐạiBiểuToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchĐạiBiểuToolStripMenuItem.Click += new EventHandler(DanhSáchĐạiBiểuToolStripMenuItem_Click);
            DanhSáchỦyQuyềnToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchỦyQuyềnToolStripMenuItem.Click += new EventHandler(DanhSáchỦyQuyềnToolStripMenuItem_Click);
            ThôngTinCuộcHọpToolStripMenuItem = new ToolStripMenuItem();
            ThôngTinCuộcHọpToolStripMenuItem.Click += new EventHandler(ThôngTinCuộcHọpToolStripMenuItem_Click);
            BiểuQuyếtToolStripMenuItem = new ToolStripMenuItem();
            BiểuQuyếtToolStripMenuItem.Click += new EventHandler(BiểuQuyếtToolStripMenuItem_Click);
            DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Click += new EventHandler(DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem_Click);
            ToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem1.Click += new EventHandler(ToolStripMenuItem1_Click);
            KếtQuảBiểuQuyếtToolStripMenuItem = new ToolStripMenuItem();
            KếtQuảBiểuQuyếtToolStripMenuItem.Click += new EventHandler(KếtQuảBiểuQuyếtToolStripMenuItem_Click);
            BầuCửToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchVấnĐềBầuCửToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchVấnĐềBầuCửToolStripMenuItem.Click += new EventHandler(DanhSáchVấnĐềBầuCửToolStripMenuItem_Click);
            DanhSáchỨngViênToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchỨngViênToolStripMenuItem.Click += new EventHandler(DanhSáchỨngViênToolStripMenuItem_Click);
            DanhSáchPhiếuBầuCửToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchPhiếuBầuCửToolStripMenuItem.Click += new EventHandler(DanhSáchPhiếuBầuCửToolStripMenuItem_Click);
            KếtQuảBầuCửToolStripMenuItem = new ToolStripMenuItem();
            KếtQuảBầuCửToolStripMenuItem.Click += new EventHandler(KếtQuảBầuCửToolStripMenuItem_Click);
            DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem = new ToolStripMenuItem();
            DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Click += new EventHandler(DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem_Click);
            HiểnThịToolStripMenuItem = new ToolStripMenuItem();
            MainStatusStrip = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripStatusLabel3 = new ToolStripStatusLabel();
            ToolStrip1 = new ToolStrip();
            MenuStrip1.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.ImageScalingSize = new Size(20, 20);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { HệThốngToolStripMenuItem, CuộcHọpToolStripMenuItem, BiểuQuyếtToolStripMenuItem, BầuCửToolStripMenuItem, HiểnThịToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(1456, 28);
            MenuStrip1.TabIndex = 0;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // HệThốngToolStripMenuItem
            // 
            HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem";
            HệThốngToolStripMenuItem.Size = new Size(96, 24);
            HệThốngToolStripMenuItem.Text = "&1.Hệ thống";
            // 
            // CuộcHọpToolStripMenuItem
            // 
            CuộcHọpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DanhSáchCuộcHọpToolStripMenuItem, DanhSáchCổĐôngToolStripMenuItem, DanhSáchĐạiBiểuToolStripMenuItem, DanhSáchỦyQuyềnToolStripMenuItem, ThôngTinCuộcHọpToolStripMenuItem });
            CuộcHọpToolStripMenuItem.Name = "CuộcHọpToolStripMenuItem";
            CuộcHọpToolStripMenuItem.Size = new Size(101, 24);
            CuộcHọpToolStripMenuItem.Text = "&2.Cuộc họp ";
            // 
            // DanhSáchCuộcHọpToolStripMenuItem
            // 
            DanhSáchCuộcHọpToolStripMenuItem.Name = "DanhSáchCuộcHọpToolStripMenuItem";
            DanhSáchCuộcHọpToolStripMenuItem.Size = new Size(240, 26);
            DanhSáchCuộcHọpToolStripMenuItem.Text = "1. Danh sách cuộc họp";
            // 
            // DanhSáchCổĐôngToolStripMenuItem
            // 
            DanhSáchCổĐôngToolStripMenuItem.Name = "DanhSáchCổĐôngToolStripMenuItem";
            DanhSáchCổĐôngToolStripMenuItem.Size = new Size(240, 26);
            DanhSáchCổĐôngToolStripMenuItem.Text = "2. Danh sách cổ đông";
            // 
            // DanhSáchĐạiBiểuToolStripMenuItem
            // 
            DanhSáchĐạiBiểuToolStripMenuItem.Name = "DanhSáchĐạiBiểuToolStripMenuItem";
            DanhSáchĐạiBiểuToolStripMenuItem.Size = new Size(240, 26);
            DanhSáchĐạiBiểuToolStripMenuItem.Text = "3. Danh sách đại biểu";
            // 
            // DanhSáchỦyQuyềnToolStripMenuItem
            // 
            DanhSáchỦyQuyềnToolStripMenuItem.Name = "DanhSáchỦyQuyềnToolStripMenuItem";
            DanhSáchỦyQuyềnToolStripMenuItem.Size = new Size(240, 26);
            DanhSáchỦyQuyềnToolStripMenuItem.Text = "4. Danh sách ủy quyền";
            // 
            // ThôngTinCuộcHọpToolStripMenuItem
            // 
            ThôngTinCuộcHọpToolStripMenuItem.Name = "ThôngTinCuộcHọpToolStripMenuItem";
            ThôngTinCuộcHọpToolStripMenuItem.Size = new Size(240, 26);
            ThôngTinCuộcHọpToolStripMenuItem.Text = "5. Thông tin cuộc họp";
            // 
            // BiểuQuyếtToolStripMenuItem
            // 
            BiểuQuyếtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem, ToolStripMenuItem1, KếtQuảBiểuQuyếtToolStripMenuItem });
            BiểuQuyếtToolStripMenuItem.Name = "BiểuQuyếtToolStripMenuItem";
            BiểuQuyếtToolStripMenuItem.Size = new Size(104, 24);
            BiểuQuyếtToolStripMenuItem.Text = "&3.Biểu quyết";
            // 
            // DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem
            // 
            DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Name = "DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem";
            DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Size = new Size(297, 26);
            DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Text = "1. Danh sách vấn đề biểu quyết";
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(297, 26);
            ToolStripMenuItem1.Text = "2. Danh sách phiếu biểu quyết";
            // 
            // KếtQuảBiểuQuyếtToolStripMenuItem
            // 
            KếtQuảBiểuQuyếtToolStripMenuItem.Name = "KếtQuảBiểuQuyếtToolStripMenuItem";
            KếtQuảBiểuQuyếtToolStripMenuItem.Size = new Size(297, 26);
            KếtQuảBiểuQuyếtToolStripMenuItem.Text = "3. Kết quả biểu quyết";
            // 
            // BầuCửToolStripMenuItem
            // 
            BầuCửToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DanhSáchVấnĐềBầuCửToolStripMenuItem, DanhSáchỨngViênToolStripMenuItem, DanhSáchPhiếuBầuCửToolStripMenuItem, KếtQuảBầuCửToolStripMenuItem, DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem });
            BầuCửToolStripMenuItem.Name = "BầuCửToolStripMenuItem";
            BầuCửToolStripMenuItem.Size = new Size(79, 24);
            BầuCửToolStripMenuItem.Text = "&4.Bầu cử";
            // 
            // DanhSáchVấnĐềBầuCửToolStripMenuItem
            // 
            DanhSáchVấnĐềBầuCửToolStripMenuItem.Name = "DanhSáchVấnĐềBầuCửToolStripMenuItem";
            DanhSáchVấnĐềBầuCửToolStripMenuItem.Size = new Size(347, 26);
            DanhSáchVấnĐềBầuCửToolStripMenuItem.Text = "1. Danh sách vấn đề bầu cử";
            // 
            // DanhSáchỨngViênToolStripMenuItem
            // 
            DanhSáchỨngViênToolStripMenuItem.Name = "DanhSáchỨngViênToolStripMenuItem";
            DanhSáchỨngViênToolStripMenuItem.Size = new Size(347, 26);
            DanhSáchỨngViênToolStripMenuItem.Text = "2. Danh sách ứng viên";
            // 
            // DanhSáchPhiếuBầuCửToolStripMenuItem
            // 
            DanhSáchPhiếuBầuCửToolStripMenuItem.Name = "DanhSáchPhiếuBầuCửToolStripMenuItem";
            DanhSáchPhiếuBầuCửToolStripMenuItem.Size = new Size(347, 26);
            DanhSáchPhiếuBầuCửToolStripMenuItem.Text = "3. Danh sách phiếu bầu cử";
            // 
            // KếtQuảBầuCửToolStripMenuItem
            // 
            KếtQuảBầuCửToolStripMenuItem.Name = "KếtQuảBầuCửToolStripMenuItem";
            KếtQuảBầuCửToolStripMenuItem.Size = new Size(347, 26);
            KếtQuảBầuCửToolStripMenuItem.Text = "4. Kết quả bầu cử";
            // 
            // DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem
            // 
            DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Name = "DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem";
            DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Size = new Size(347, 26);
            DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Text = "5. Danh sách phiếu bầu KHÔNG hợp lệ";
            // 
            // HiểnThịToolStripMenuItem
            // 
            HiểnThịToolStripMenuItem.Name = "HiểnThịToolStripMenuItem";
            HiểnThịToolStripMenuItem.Size = new Size(86, 24);
            HiểnThịToolStripMenuItem.Text = "&5.Hiển thị";
            HiểnThịToolStripMenuItem.Visible = false;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3 });
            MainStatusStrip.Location = new Point(0, 826);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Padding = new Padding(1, 0, 19, 0);
            MainStatusStrip.Size = new Size(1456, 26);
            MainStatusStrip.TabIndex = 1;
            MainStatusStrip.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(106, 20);
            ToolStripStatusLabel1.Text = "Mã cuộc họp : ";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // ToolStripStatusLabel3
            // 
            ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            ToolStripStatusLabel3.Size = new Size(153, 20);
            ToolStripStatusLabel3.Text = "ToolStripStatusLabel3";
            // 
            // ToolStrip1
            // 
            ToolStrip1.ImageScalingSize = new Size(20, 20);
            ToolStrip1.Location = new Point(0, 28);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.Size = new Size(1456, 25);
            ToolStrip1.TabIndex = 2;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1456, 852);
            Controls.Add(ToolStrip1);
            Controls.Add(MainStatusStrip);
            Controls.Add(MenuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip1;
            Margin = new Padding(4);
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm họp đại hội cổ đông";
            WindowState = FormWindowState.Maximized;
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            Load += new EventHandler(Mainform_Load);
            Shown += new EventHandler(Mainform_Shown);
            ResumeLayout(false);
            PerformLayout();

        }
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem HệThốngToolStripMenuItem;
        internal ToolStripMenuItem CuộcHọpToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchCuộcHọpToolStripMenuItem;
        internal ToolStripMenuItem BiểuQuyếtToolStripMenuItem;
        internal ToolStripMenuItem BầuCửToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchCổĐôngToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchĐạiBiểuToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchỦyQuyềnToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem;
        internal ToolStripMenuItem KếtQuảBiểuQuyếtToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchVấnĐềBầuCửToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchỨngViênToolStripMenuItem;
        internal ToolStripMenuItem KếtQuảBầuCửToolStripMenuItem;
        internal ToolStripMenuItem HiểnThịToolStripMenuItem;
        internal StatusStrip MainStatusStrip;
        internal ToolStrip ToolStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripMenuItem ToolStripMenuItem1;
        internal ToolStripMenuItem DanhSáchPhiếuBầuCửToolStripMenuItem;
        internal ToolStripMenuItem ThôngTinCuộcHọpToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem;
        internal ToolStripStatusLabel ToolStripStatusLabel3;

    }
}