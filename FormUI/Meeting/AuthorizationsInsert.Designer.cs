using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AuthorizationsInsert : Form
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
            StockTextBox2 = new Lapas.Controls.StockTextBox();
            StockTextBox2.KeyDown += new KeyEventHandler(StockTextBox2_KeyDown);
            Label4 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Label2 = new Label();
            Label7 = new Label();
            Label3 = new Label();
            MaskedTextBox2 = new MaskedTextBox();
            MaskedTextBox2.KeyDown += new KeyEventHandler(MaskedTextBox2_KeyDown);
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox3.Leave += new EventHandler(MaskedTextBox3_Leave);
            MaskedTextBox3.KeyUp += new KeyEventHandler(MaskedTextBox3_KeyUp);
            MaskedTextBox3.KeyDown += new KeyEventHandler(MaskedTextBox3_KeyDown);
            MaskedTextBox4 = new MaskedTextBox();
            Label8 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label1 = new Label();
            MaskedTextBox8 = new MaskedTextBox();
            MaskedTextBox8.KeyDown += new KeyEventHandler(MaskedTextBox8_KeyDown);
            MaskedTextBox7 = new MaskedTextBox();
            MaskedTextBox7.KeyDown += new KeyEventHandler(MaskedTextBox7_KeyDown);
            MaskedTextBox6 = new MaskedTextBox();
            StockTextBox1 = new Lapas.Controls.StockTextBox();
            Label9 = new Label();
            Label10 = new Label();
            MaskedTextBox1 = new MaskedTextBox();
            Label11 = new Label();
            btnext = new Button();
            btnext.Click += new EventHandler(btnext_Click);
            SuspendLayout();
            // 
            // StockTextBox2
            // 
            StockTextBox2.Alarm = false;
            StockTextBox2.AllowNegativeNumeric = true;
            StockTextBox2.CustomCulture = false;
            StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTextBox2.Location = new Point(285, 430);
            StockTextBox2.Margin = new Padding(4);
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
            Label4.Location = new Point(81, 437);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(179, 20);
            Label4.TabIndex = 16;
            Label4.Text = "Số quyền BQ ủy quyền";
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.Location = new Point(88, 490);
            Button1.Margin = new Padding(4);
            Button1.Name = "Button1";
            Button1.Size = new Size(193, 58);
            Button1.TabIndex = 5;
            Button1.Text = "Thêm";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button2.Location = new Point(516, 490);
            Button2.Margin = new Padding(4);
            Button2.Name = "Button2";
            Button2.Size = new Size(193, 58);
            Button2.TabIndex = 6;
            Button2.Text = "Thoát";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(84, 44);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 20);
            Label2.TabIndex = 9;
            Label2.Text = "Mã đại biểu";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(84, 90);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(88, 20);
            Label7.TabIndex = 10;
            Label7.Text = "CCCD/HC";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(83, 140);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 20);
            Label3.TabIndex = 11;
            Label3.Text = "Tên đại biểu";
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.BackColor = SystemColors.InactiveBorder;
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(287, 37);
            MaskedTextBox2.Margin = new Padding(4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.Size = new Size(168, 26);
            MaskedTextBox2.TabIndex = 0;
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(287, 90);
            MaskedTextBox3.Margin = new Padding(4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.Size = new Size(265, 26);
            MaskedTextBox3.TabIndex = 1;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(287, 140);
            MaskedTextBox4.Margin = new Padding(4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.ReadOnly = true;
            MaskedTextBox4.Size = new Size(505, 26);
            MaskedTextBox4.TabIndex = 6;
            MaskedTextBox4.TabStop = false;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(81, 236);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(96, 20);
            Label8.TabIndex = 12;
            Label8.Text = "Mã cổ đông";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(81, 267);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(146, 20);
            Label6.TabIndex = 13;
            Label6.Text = "Số đăng ký sở hữu";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(80, 305);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(101, 20);
            Label5.TabIndex = 14;
            Label5.Text = "Tên cổ đông";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(81, 391);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(159, 20);
            Label1.TabIndex = 15;
            Label1.Text = "Số quyền biểu quyết";
            // 
            // MaskedTextBox8
            // 
            MaskedTextBox8.BackColor = SystemColors.InactiveBorder;
            MaskedTextBox8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox8.Location = new Point(284, 229);
            MaskedTextBox8.Margin = new Padding(4);
            MaskedTextBox8.Name = "MaskedTextBox8";
            MaskedTextBox8.Size = new Size(265, 26);
            MaskedTextBox8.TabIndex = 2;
            // 
            // MaskedTextBox7
            // 
            MaskedTextBox7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox7.Location = new Point(284, 267);
            MaskedTextBox7.Margin = new Padding(4);
            MaskedTextBox7.Name = "MaskedTextBox7";
            MaskedTextBox7.Size = new Size(265, 26);
            MaskedTextBox7.TabIndex = 3;
            // 
            // MaskedTextBox6
            // 
            MaskedTextBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox6.Location = new Point(284, 305);
            MaskedTextBox6.Margin = new Padding(4);
            MaskedTextBox6.Name = "MaskedTextBox6";
            MaskedTextBox6.ReadOnly = true;
            MaskedTextBox6.Size = new Size(505, 26);
            MaskedTextBox6.TabIndex = 8;
            MaskedTextBox6.TabStop = false;
            // 
            // StockTextBox1
            // 
            StockTextBox1.Alarm = false;
            StockTextBox1.AllowNegativeNumeric = true;
            StockTextBox1.CustomCulture = false;
            StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTextBox1.Location = new Point(284, 388);
            StockTextBox1.Margin = new Padding(4);
            StockTextBox1.MaxLength = 25;
            StockTextBox1.Name = "StockTextBox1";
            StockTextBox1.Precision = 0;
            StockTextBox1.ReadOnly = true;
            StockTextBox1.Size = new Size(265, 26);
            StockTextBox1.TabIndex = 9;
            StockTextBox1.TabStop = false;
            StockTextBox1.Text = "0";
            StockTextBox1.TextAlign = HorizontalAlignment.Right;
            StockTextBox1.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(56, 199);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(218, 20);
            Label9.TabIndex = 17;
            Label9.Text = "Thông tin người ủy quyền";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(56, 11);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(159, 20);
            Label10.TabIndex = 18;
            Label10.Text = "Thông tin đại biểu";
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(284, 346);
            MaskedTextBox1.Margin = new Padding(4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(505, 26);
            MaskedTextBox1.TabIndex = 19;
            MaskedTextBox1.TabStop = false;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.Location = new Point(80, 346);
            Label11.Margin = new Padding(4, 0, 4, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(61, 20);
            Label11.TabIndex = 20;
            Label11.Text = "Địa chỉ";
            // 
            // btnext
            // 
            btnext.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnext.Location = new Point(306, 490);
            btnext.Margin = new Padding(4);
            btnext.Name = "btnext";
            btnext.Size = new Size(193, 58);
            btnext.TabIndex = 5;
            btnext.Text = "Tiếp tục";
            btnext.UseVisualStyleBackColor = true;
            // 
            // AuthorizationsInsert
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 585);
            Controls.Add(MaskedTextBox1);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(StockTextBox2);
            Controls.Add(Label4);
            Controls.Add(StockTextBox1);
            Controls.Add(MaskedTextBox4);
            Controls.Add(MaskedTextBox6);
            Controls.Add(Button2);
            Controls.Add(MaskedTextBox7);
            Controls.Add(MaskedTextBox3);
            Controls.Add(MaskedTextBox8);
            Controls.Add(Label1);
            Controls.Add(btnext);
            Controls.Add(Button1);
            Controls.Add(Label5);
            Controls.Add(MaskedTextBox2);
            Controls.Add(Label6);
            Controls.Add(Label3);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "AuthorizationsInsert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ủy quyền";
            Load += new EventHandler(AuthorizationsInsert_Load);
            KeyUp += new KeyEventHandler(AuthorizationsInsert_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label4;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Button Button1;
        internal Button Button2;
        internal Label Label2;
        internal Label Label7;
        internal Label Label3;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox4;
        internal Label Label8;
        internal Label Label6;
        internal Label Label5;
        internal Label Label1;
        internal MaskedTextBox MaskedTextBox8;
        internal MaskedTextBox MaskedTextBox7;
        internal MaskedTextBox MaskedTextBox6;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal Label Label9;
        internal Label Label10;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label11;
        internal Button btnext;
    }
}