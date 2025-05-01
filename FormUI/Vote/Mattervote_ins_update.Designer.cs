using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Mattervote_ins_update : Form
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
            GroupBox1 = new GroupBox();
            NumericUpDown1 = new NumericUpDown();
            NumericUpDown1.ValueChanged += new EventHandler(NumericUpDown1_ValueChanged);
            NumericUpDown1.Validating += new System.ComponentModel.CancelEventHandler(NumericUpDown1_Validating);
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox1 = new MaskedTextBox();
            Label7 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            StockTextBox1 = new Lapas.Controls.StockTextBox();
            CheckBox1 = new CheckBox();
            MaskedTextBox4 = new MaskedTextBox();
            HolderIdentifyMaskedTextBox2 = new MaskedTextBox();
            HolderIdentifyMaskedTextBox2.KeyDown += new KeyEventHandler(MaskedTextBox2_KeyDown);
            HolderCodeMaskedTextBox = new MaskedTextBox();
            HolderCodeMaskedTextBox.KeyDown += new KeyEventHandler(MaskedTextBox5_KeyDown);
            HolderCodeMaskedTextBox.Leave += new EventHandler(MaskedTextBox5_Leave);
            Label6 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            GroupBox3 = new GroupBox();
            rbillegal = new RadioButton();
            RadioButton3 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton1 = new RadioButton();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            delegateNameTextbox = new MaskedTextBox();
            Label8 = new Label();
            delegateIdentityTextBox = new MaskedTextBox();
            delegateCodeMaskedTextBox = new MaskedTextBox();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(NumericUpDown1);
            GroupBox1.Controls.Add(MaskedTextBox3);
            GroupBox1.Controls.Add(MaskedTextBox1);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new Point(1, 1);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(932, 188);
            GroupBox1.TabIndex = 55;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Vấn đề biểu quyết";
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumericUpDown1.Location = new Point(217, 78);
            NumericUpDown1.Margin = new Padding(4);
            NumericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(81, 29);
            NumericUpDown1.TabIndex = 2;
            NumericUpDown1.TabStop = false;
            NumericUpDown1.TextAlign = HorizontalAlignment.Right;
            NumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(217, 133);
            MaskedTextBox3.Margin = new Padding(4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.ReadOnly = true;
            MaskedTextBox3.Size = new Size(635, 26);
            MaskedTextBox3.TabIndex = 23;
            MaskedTextBox3.TabStop = false;
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(217, 37);
            MaskedTextBox1.Margin = new Padding(4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(265, 26);
            MaskedTextBox1.TabIndex = 24;
            MaskedTextBox1.TabStop = false;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(15, 133);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(91, 20);
            Label7.TabIndex = 27;
            Label7.Text = "Tên vấn đề";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(15, 87);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(86, 20);
            Label2.TabIndex = 26;
            Label2.Text = "Mã vấn đề";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(15, 37);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 20);
            Label1.TabIndex = 25;
            Label1.Text = "Mã cuộc họp";
            // 
            // StockTextBox1
            // 
            StockTextBox1.Alarm = false;
            StockTextBox1.AllowNegativeNumeric = true;
            StockTextBox1.CustomCulture = false;
            StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox1.Location = new Point(237, 384);
            StockTextBox1.Margin = new Padding(4);
            StockTextBox1.MaxLength = 25;
            StockTextBox1.Name = "StockTextBox1";
            StockTextBox1.Precision = 0;
            StockTextBox1.ReadOnly = true;
            StockTextBox1.Size = new Size(265, 22);
            StockTextBox1.TabIndex = 3;
            StockTextBox1.TabStop = false;
            StockTextBox1.Text = "0";
            StockTextBox1.TextAlign = HorizontalAlignment.Right;
            StockTextBox1.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(605, 220);
            CheckBox1.Margin = new Padding(4);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(155, 21);
            CheckBox1.TabIndex = 37;
            CheckBox1.TabStop = false;
            CheckBox1.Text = "Chế độ nhập nhanh";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.Visible = false;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(237, 297);
            MaskedTextBox4.Margin = new Padding(4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.ReadOnly = true;
            MaskedTextBox4.Size = new Size(635, 26);
            MaskedTextBox4.TabIndex = 2;
            MaskedTextBox4.TabStop = false;
            // 
            // HolderIdentifyMaskedTextBox2
            // 
            HolderIdentifyMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            HolderIdentifyMaskedTextBox2.Location = new Point(237, 260);
            HolderIdentifyMaskedTextBox2.Margin = new Padding(4);
            HolderIdentifyMaskedTextBox2.Name = "HolderIdentifyMaskedTextBox2";
            HolderIdentifyMaskedTextBox2.Size = new Size(265, 26);
            HolderIdentifyMaskedTextBox2.TabIndex = 1;
            // 
            // HolderCodeMaskedTextBox
            // 
            HolderCodeMaskedTextBox.BackColor = SystemColors.InactiveBorder;
            HolderCodeMaskedTextBox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            HolderCodeMaskedTextBox.Location = new Point(237, 220);
            HolderCodeMaskedTextBox.Margin = new Padding(4);
            HolderCodeMaskedTextBox.Name = "HolderCodeMaskedTextBox";
            HolderCodeMaskedTextBox.Size = new Size(265, 26);
            HolderCodeMaskedTextBox.TabIndex = 0;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(35, 384);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(159, 20);
            Label6.TabIndex = 36;
            Label6.Text = "Số quyền biểu quyết";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(33, 302);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(101, 20);
            Label3.TabIndex = 36;
            Label3.Text = "Tên cổ đông";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(35, 267);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(88, 20);
            Label4.TabIndex = 35;
            Label4.Text = "CCCD/HC";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(35, 228);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(95, 20);
            Label5.TabIndex = 34;
            Label5.Text = "Mã đại biểu";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(rbillegal);
            GroupBox3.Controls.Add(RadioButton3);
            GroupBox3.Controls.Add(RadioButton2);
            GroupBox3.Controls.Add(RadioButton1);
            GroupBox3.Location = new Point(17, 452);
            GroupBox3.Margin = new Padding(4);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(4);
            GroupBox3.Size = new Size(916, 92);
            GroupBox3.TabIndex = 57;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Biểu quyết";
            // 
            // rbillegal
            // 
            rbillegal.AutoSize = true;
            rbillegal.Location = new Point(591, 41);
            rbillegal.Margin = new Padding(4);
            rbillegal.Name = "rbillegal";
            rbillegal.Size = new Size(113, 21);
            rbillegal.TabIndex = 2;
            rbillegal.Text = "Không hợp lệ";
            rbillegal.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(400, 41);
            RadioButton3.Margin = new Padding(4);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(111, 21);
            RadioButton3.TabIndex = 2;
            RadioButton3.Text = "Không ý kiến";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(202, 41);
            RadioButton2.Margin = new Padding(4);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(117, 21);
            RadioButton2.TabIndex = 1;
            RadioButton2.Text = "Không đồng ý";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Checked = true;
            RadioButton1.Location = new Point(39, 41);
            RadioButton1.Margin = new Padding(4);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(74, 21);
            RadioButton1.TabIndex = 0;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Đồng ý";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.ForeColor = Color.Blue;
            Button3.Location = new Point(467, 559);
            Button3.Margin = new Padding(4);
            Button3.Name = "Button3";
            Button3.Size = new Size(188, 43);
            Button3.TabIndex = 7;
            Button3.Text = "Nhập phần còn lại";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.Location = new Point(36, 559);
            Button1.Margin = new Padding(4);
            Button1.Name = "Button1";
            Button1.Size = new Size(153, 43);
            Button1.TabIndex = 4;
            Button1.Text = "Thêm";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.Location = new Point(256, 559);
            Button2.Margin = new Padding(4);
            Button2.Name = "Button2";
            Button2.Size = new Size(161, 43);
            Button2.TabIndex = 5;
            Button2.Text = "Tiếp tục";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button4.Location = new Point(780, 559);
            Button4.Margin = new Padding(4);
            Button4.Name = "Button4";
            Button4.Size = new Size(153, 43);
            Button4.TabIndex = 6;
            Button4.TabStop = false;
            Button4.Text = "Đóng";
            Button4.UseVisualStyleBackColor = true;
            // 
            // delegateNameTextbox
            // 
            delegateNameTextbox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            delegateNameTextbox.Location = new Point(237, 338);
            delegateNameTextbox.Margin = new Padding(4);
            delegateNameTextbox.Name = "delegateNameTextbox";
            delegateNameTextbox.ReadOnly = true;
            delegateNameTextbox.Size = new Size(635, 26);
            delegateNameTextbox.TabIndex = 58;
            delegateNameTextbox.TabStop = false;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(33, 343);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(115, 20);
            Label8.TabIndex = 59;
            Label8.Text = "Người đại diện";
            // 
            // delegateIdentityTextBox
            // 
            delegateIdentityTextBox.BackColor = SystemColors.InactiveBorder;
            delegateIdentityTextBox.Enabled = false;
            delegateIdentityTextBox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            delegateIdentityTextBox.Location = new Point(733, 373);
            delegateIdentityTextBox.Margin = new Padding(4);
            delegateIdentityTextBox.Name = "delegateIdentityTextBox";
            delegateIdentityTextBox.Size = new Size(139, 26);
            delegateIdentityTextBox.TabIndex = 60;
            delegateIdentityTextBox.TabStop = false;
            delegateIdentityTextBox.Visible = false;
            // 
            // delegateCodeMaskedTextBox
            // 
            delegateCodeMaskedTextBox.BackColor = SystemColors.InactiveBorder;
            delegateCodeMaskedTextBox.Enabled = false;
            delegateCodeMaskedTextBox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            delegateCodeMaskedTextBox.Location = new Point(588, 373);
            delegateCodeMaskedTextBox.Margin = new Padding(4);
            delegateCodeMaskedTextBox.Name = "delegateCodeMaskedTextBox";
            delegateCodeMaskedTextBox.Size = new Size(124, 26);
            delegateCodeMaskedTextBox.TabIndex = 61;
            delegateCodeMaskedTextBox.TabStop = false;
            delegateCodeMaskedTextBox.Visible = false;
            // 
            // Mattervote_ins_update
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 645);
            Controls.Add(delegateCodeMaskedTextBox);
            Controls.Add(delegateIdentityTextBox);
            Controls.Add(delegateNameTextbox);
            Controls.Add(Label8);
            Controls.Add(StockTextBox1);
            Controls.Add(Button2);
            Controls.Add(CheckBox1);
            Controls.Add(Button4);
            Controls.Add(MaskedTextBox4);
            Controls.Add(Button3);
            Controls.Add(HolderIdentifyMaskedTextBox2);
            Controls.Add(Button1);
            Controls.Add(HolderCodeMaskedTextBox);
            Controls.Add(Label6);
            Controls.Add(GroupBox3);
            Controls.Add(Label3);
            Controls.Add(Label4);
            Controls.Add(GroupBox1);
            Controls.Add(Label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "Mattervote_ins_update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm phiếu biểu quyết";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            Load += new EventHandler(Mattervote_ins_update_Load);
            KeyUp += new KeyEventHandler(Mattervote_ins_update_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox HolderIdentifyMaskedTextBox2;
        internal MaskedTextBox HolderCodeMaskedTextBox;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal GroupBox GroupBox3;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
        internal Button Button3;
        internal Button Button1;
        internal Button Button2;
        internal CheckBox CheckBox1;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal Label Label6;
        internal Button Button4;
        internal MaskedTextBox delegateNameTextbox;
        internal Label Label8;
        internal MaskedTextBox delegateIdentityTextBox;
        internal MaskedTextBox delegateCodeMaskedTextBox;
        internal RadioButton rbillegal;
    }
}