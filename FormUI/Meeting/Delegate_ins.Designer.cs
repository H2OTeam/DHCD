using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Delegate_ins : Form
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
            StockTextBox1 = new Lapas.Controls.StockTextBox();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            MaskedTextBox5 = new MaskedTextBox();
            MaskedTextBox4 = new MaskedTextBox();
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox3.KeyDown += new KeyEventHandler(MaskedTextBox3_KeyDown);
            MaskedTextBox2 = new MaskedTextBox();
            MaskedTextBox1 = new MaskedTextBox();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label7 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Label8 = new Label();
            MaskedTextBox6 = new MaskedTextBox();
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            SuspendLayout();
            // 
            // StockTextBox2
            // 
            StockTextBox2.Alarm = false;
            StockTextBox2.AllowNegativeNumeric = true;
            StockTextBox2.CustomCulture = false;
            StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox2.Location = new Point(233, 345);
            StockTextBox2.Margin = new Padding(4, 4, 4, 4);
            StockTextBox2.MaxLength = 25;
            StockTextBox2.Name = "StockTextBox2";
            StockTextBox2.Precision = 0;
            StockTextBox2.ReadOnly = true;
            StockTextBox2.Size = new Size(265, 22);
            StockTextBox2.TabIndex = 20;
            StockTextBox2.TabStop = false;
            StockTextBox2.Text = "0";
            StockTextBox2.TextAlign = HorizontalAlignment.Right;
            StockTextBox2.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // StockTextBox1
            // 
            StockTextBox1.Alarm = false;
            StockTextBox1.AllowNegativeNumeric = true;
            StockTextBox1.CustomCulture = false;
            StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox1.Location = new Point(233, 298);
            StockTextBox1.Margin = new Padding(4, 4, 4, 4);
            StockTextBox1.MaxLength = 25;
            StockTextBox1.Name = "StockTextBox1";
            StockTextBox1.Precision = 0;
            StockTextBox1.ReadOnly = true;
            StockTextBox1.Size = new Size(265, 22);
            StockTextBox1.TabIndex = 19;
            StockTextBox1.TabStop = false;
            StockTextBox1.Text = "0";
            StockTextBox1.TextAlign = HorizontalAlignment.Right;
            StockTextBox1.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.Location = new Point(573, 417);
            Button3.Margin = new Padding(4, 4, 4, 4);
            Button3.Name = "Button3";
            Button3.Size = new Size(199, 75);
            Button3.TabIndex = 5;
            Button3.Text = "Tiếp tục";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.Location = new Point(84, 417);
            Button1.Margin = new Padding(4, 4, 4, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(189, 75);
            Button1.TabIndex = 3;
            Button1.Text = "Thêm đại biểu và tự ủy quyền";
            Button1.UseVisualStyleBackColor = true;
            // 
            // MaskedTextBox5
            // 
            MaskedTextBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox5.Location = new Point(233, 217);
            MaskedTextBox5.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox5.Name = "MaskedTextBox5";
            MaskedTextBox5.Size = new Size(505, 26);
            MaskedTextBox5.TabIndex = 2;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(233, 170);
            MaskedTextBox4.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.Size = new Size(505, 26);
            MaskedTextBox4.TabIndex = 1;
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(233, 119);
            MaskedTextBox3.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.Size = new Size(265, 26);
            MaskedTextBox3.TabIndex = 0;
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(233, 66);
            MaskedTextBox2.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.ReadOnly = true;
            MaskedTextBox2.Size = new Size(265, 26);
            MaskedTextBox2.TabIndex = 15;
            MaskedTextBox2.TabStop = false;
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(233, 23);
            MaskedTextBox1.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(265, 26);
            MaskedTextBox1.TabIndex = 25;
            MaskedTextBox1.TabStop = false;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(29, 350);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(159, 20);
            Label6.TabIndex = 24;
            Label6.Text = "Số quyền biểu quyết";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(31, 298);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(93, 20);
            Label5.TabIndex = 23;
            Label5.Text = "Số cổ phần";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(31, 224);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(61, 20);
            Label4.TabIndex = 26;
            Label4.Text = "Địa chỉ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(29, 170);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 20);
            Label3.TabIndex = 30;
            Label3.Text = "Tên đại biểu";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(31, 119);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(88, 20);
            Label7.TabIndex = 29;
            Label7.Text = "CCCD/HC";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(31, 74);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 20);
            Label2.TabIndex = 28;
            Label2.Text = "Mã đại biểu";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(31, 23);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 20);
            Label1.TabIndex = 27;
            Label1.Text = "Mã cuộc họp";
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.Location = new Point(317, 417);
            Button2.Margin = new Padding(4, 4, 4, 4);
            Button2.Name = "Button2";
            Button2.Size = new Size(189, 75);
            Button2.TabIndex = 4;
            Button2.Text = "Thêm đại biểu không có cổ phần";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Location = new Point(536, 117);
            Button4.Margin = new Padding(4, 4, 4, 4);
            Button4.Name = "Button4";
            Button4.Size = new Size(204, 30);
            Button4.TabIndex = 31;
            Button4.Text = "Tìm trong DS cổ đông";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(29, 262);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(96, 20);
            Label8.TabIndex = 26;
            Label8.Text = "Mã cổ đông";
            // 
            // MaskedTextBox6
            // 
            MaskedTextBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox6.Location = new Point(233, 255);
            MaskedTextBox6.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox6.Name = "MaskedTextBox6";
            MaskedTextBox6.ReadOnly = true;
            MaskedTextBox6.Size = new Size(265, 26);
            MaskedTextBox6.TabIndex = 16;
            MaskedTextBox6.TabStop = false;
            // 
            // Button5
            // 
            Button5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button5.Location = new Point(84, 514);
            Button5.Margin = new Padding(4, 4, 4, 4);
            Button5.Name = "Button5";
            Button5.Size = new Size(189, 54);
            Button5.TabIndex = 6;
            Button5.Text = "&In thẻ biểu quyết";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.Enabled = false;
            Button6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button6.Location = new Point(317, 514);
            Button6.Margin = new Padding(4, 4, 4, 4);
            Button6.Name = "Button6";
            Button6.Size = new Size(189, 54);
            Button6.TabIndex = 7;
            Button6.Text = "In &phiếu bầu";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button7.Location = new Point(573, 514);
            Button7.Margin = new Padding(4, 4, 4, 4);
            Button7.Name = "Button7";
            Button7.Size = new Size(199, 54);
            Button7.TabIndex = 8;
            Button7.Text = "Thoát(Esc)";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Delegate_ins
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 590);
            Controls.Add(Button4);
            Controls.Add(StockTextBox2);
            Controls.Add(StockTextBox1);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button7);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Button1);
            Controls.Add(MaskedTextBox5);
            Controls.Add(MaskedTextBox4);
            Controls.Add(MaskedTextBox6);
            Controls.Add(MaskedTextBox3);
            Controls.Add(MaskedTextBox2);
            Controls.Add(MaskedTextBox1);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label8);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label7);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Delegate_ins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đại biểu";
            Load += new EventHandler(Delegate_ins_Load);
            KeyUp += new KeyEventHandler(Delegate_ins_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal Button Button3;
        internal Button Button1;
        internal MaskedTextBox MaskedTextBox5;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal Button Button2;
        internal Button Button4;
        internal Label Label8;
        internal MaskedTextBox MaskedTextBox6;
        internal Button Button5;
        internal Button Button6;
        internal Button Button7;
    }
}