using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AuthorizationUpdate : Form
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
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            GroupBox3 = new GroupBox();
            StockTextBox2 = new Lapas.Controls.StockTextBox();
            Label4 = new Label();
            GroupBox2 = new GroupBox();
            StockTextBox1 = new Lapas.Controls.StockTextBox();
            MaskedTextBox6 = new MaskedTextBox();
            MaskedTextBox7 = new MaskedTextBox();
            MaskedTextBox8 = new MaskedTextBox();
            Label1 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label8 = new Label();
            GroupBox1 = new GroupBox();
            MaskedTextBox4 = new MaskedTextBox();
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox2 = new MaskedTextBox();
            Label3 = new Label();
            Label7 = new Label();
            Label2 = new Label();
            GroupBox3.SuspendLayout();
            GroupBox2.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button2.Location = new Point(541, 540);
            Button2.Margin = new Padding(4, 4, 4, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(193, 58);
            Button2.TabIndex = 68;
            Button2.Text = "Thoát";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.Location = new Point(189, 540);
            Button1.Margin = new Padding(4, 4, 4, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(193, 58);
            Button1.TabIndex = 67;
            Button1.Text = "Cập nhật";
            Button1.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(StockTextBox2);
            GroupBox3.Controls.Add(Label4);
            GroupBox3.Location = new Point(8, 423);
            GroupBox3.Margin = new Padding(4, 4, 4, 4);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(4, 4, 4, 4);
            GroupBox3.Size = new Size(880, 90);
            GroupBox3.TabIndex = 71;
            GroupBox3.TabStop = false;
            // 
            // StockTextBox2
            // 
            StockTextBox2.Alarm = false;
            StockTextBox2.AllowNegativeNumeric = true;
            StockTextBox2.CustomCulture = false;
            StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTextBox2.Location = new Point(220, 28);
            StockTextBox2.Margin = new Padding(4, 4, 4, 4);
            StockTextBox2.MaxLength = 25;
            StockTextBox2.Name = "StockTextBox2";
            StockTextBox2.Precision = 0;
            StockTextBox2.Size = new Size(265, 26);
            StockTextBox2.TabIndex = 4;
            StockTextBox2.Text = "0";
            StockTextBox2.TextAlign = HorizontalAlignment.Right;
            StockTextBox2.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(16, 36);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(179, 20);
            Label4.TabIndex = 35;
            Label4.Text = "Số quyền BQ ủy quyền";
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(StockTextBox1);
            GroupBox2.Controls.Add(MaskedTextBox6);
            GroupBox2.Controls.Add(MaskedTextBox7);
            GroupBox2.Controls.Add(MaskedTextBox8);
            GroupBox2.Controls.Add(Label1);
            GroupBox2.Controls.Add(Label5);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Controls.Add(Label8);
            GroupBox2.Location = new Point(8, 191);
            GroupBox2.Margin = new Padding(4, 4, 4, 4);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4, 4, 4, 4);
            GroupBox2.Size = new Size(880, 225);
            GroupBox2.TabIndex = 69;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Cổ đông";
            // 
            // StockTextBox1
            // 
            StockTextBox1.Alarm = false;
            StockTextBox1.AllowNegativeNumeric = true;
            StockTextBox1.CustomCulture = false;
            StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTextBox1.Location = new Point(220, 166);
            StockTextBox1.Margin = new Padding(4, 4, 4, 4);
            StockTextBox1.MaxLength = 25;
            StockTextBox1.Name = "StockTextBox1";
            StockTextBox1.Precision = 0;
            StockTextBox1.ReadOnly = true;
            StockTextBox1.Size = new Size(265, 26);
            StockTextBox1.TabIndex = 36;
            StockTextBox1.Text = "0";
            StockTextBox1.TextAlign = HorizontalAlignment.Right;
            StockTextBox1.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // MaskedTextBox6
            // 
            MaskedTextBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox6.Location = new Point(220, 116);
            MaskedTextBox6.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox6.Name = "MaskedTextBox6";
            MaskedTextBox6.ReadOnly = true;
            MaskedTextBox6.Size = new Size(505, 26);
            MaskedTextBox6.TabIndex = 32;
            // 
            // MaskedTextBox7
            // 
            MaskedTextBox7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox7.Location = new Point(220, 65);
            MaskedTextBox7.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox7.Name = "MaskedTextBox7";
            MaskedTextBox7.ReadOnly = true;
            MaskedTextBox7.Size = new Size(265, 26);
            MaskedTextBox7.TabIndex = 33;
            MaskedTextBox7.TabStop = false;
            // 
            // MaskedTextBox8
            // 
            MaskedTextBox8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox8.Location = new Point(220, 12);
            MaskedTextBox8.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox8.Name = "MaskedTextBox8";
            MaskedTextBox8.ReadOnly = true;
            MaskedTextBox8.Size = new Size(265, 26);
            MaskedTextBox8.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(17, 170);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(159, 20);
            Label1.TabIndex = 35;
            Label1.Text = "Số quyền biểu quyết";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(16, 116);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(101, 20);
            Label5.TabIndex = 38;
            Label5.Text = "Tên cổ đông";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(17, 65);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(146, 20);
            Label6.TabIndex = 37;
            Label6.Text = "Số đăng ký sở hữu";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(17, 20);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(96, 20);
            Label8.TabIndex = 36;
            Label8.Text = "Mã cổ đông";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(MaskedTextBox4);
            GroupBox1.Controls.Add(MaskedTextBox3);
            GroupBox1.Controls.Add(MaskedTextBox2);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Location = new Point(8, 14);
            GroupBox1.Margin = new Padding(4, 4, 4, 4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 4, 4, 4);
            GroupBox1.Size = new Size(880, 170);
            GroupBox1.TabIndex = 70;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Đại biểu";
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(220, 116);
            MaskedTextBox4.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.ReadOnly = true;
            MaskedTextBox4.Size = new Size(505, 26);
            MaskedTextBox4.TabIndex = 32;
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(220, 65);
            MaskedTextBox3.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.ReadOnly = true;
            MaskedTextBox3.Size = new Size(265, 26);
            MaskedTextBox3.TabIndex = 1;
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(220, 12);
            MaskedTextBox2.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.ReadOnly = true;
            MaskedTextBox2.Size = new Size(265, 26);
            MaskedTextBox2.TabIndex = 0;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(16, 116);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 20);
            Label3.TabIndex = 38;
            Label3.Text = "Tên đại biểu";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(17, 65);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(88, 20);
            Label7.TabIndex = 37;
            Label7.Text = "CCCD/HC";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(17, 20);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 20);
            Label2.TabIndex = 36;
            Label2.Text = "Mã đại biểu";
            // 
            // AuthorizationUpdate
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 612);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AuthorizationUpdate";
            Text = "Cập nhật thông tin Ủy quyền";
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(AuthorizationUpdate_Load);
            ResumeLayout(false);

        }
        internal Button Button2;
        internal Button Button1;
        internal GroupBox GroupBox3;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Label Label4;
        internal GroupBox GroupBox2;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal MaskedTextBox MaskedTextBox6;
        internal MaskedTextBox MaskedTextBox7;
        internal MaskedTextBox MaskedTextBox8;
        internal Label Label1;
        internal Label Label5;
        internal Label Label6;
        internal Label Label8;
        internal GroupBox GroupBox1;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox2;
        internal Label Label3;
        internal Label Label7;
        internal Label Label2;
    }
}