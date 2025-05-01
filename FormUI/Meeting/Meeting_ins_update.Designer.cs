using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Meeting_ins_update : Form
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
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            MaskedTextBox1 = new MaskedTextBox();
            MaskedTextBox2 = new MaskedTextBox();
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox4 = new MaskedTextBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            MaskedTextBox5 = new MaskedTextBox();
            DateTimePicker1 = new DateTimePicker();
            Label7 = new Label();
            txtPeriod = new MaskedTextBox();
            Label8 = new Label();
            txtMettingType = new ComboBox();
            stockCode = new TextBox();
            Label9 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(17, 49);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Mã cuộc họp";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(17, 100);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(110, 20);
            Label2.TabIndex = 0;
            Label2.Text = "Tên cuộc họp";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(17, 222);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(96, 20);
            Label3.TabIndex = 0;
            Label3.Text = "Tên công ty";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(17, 276);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(120, 20);
            Label4.TabIndex = 0;
            Label4.Text = "Địa chỉ công ty";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(17, 330);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(135, 20);
            Label5.TabIndex = 0;
            Label5.Text = "Địa điểm tổ chức";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(17, 396);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(107, 20);
            Label6.TabIndex = 0;
            Label6.Text = "Ngày tổ chức";
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(220, 49);
            MaskedTextBox1.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.Size = new Size(188, 26);
            MaskedTextBox1.TabIndex = 0;
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(220, 92);
            MaskedTextBox2.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.Size = new Size(456, 26);
            MaskedTextBox2.TabIndex = 1;
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(220, 214);
            MaskedTextBox3.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.Size = new Size(456, 26);
            MaskedTextBox3.TabIndex = 5;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(220, 268);
            MaskedTextBox4.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.Size = new Size(456, 26);
            MaskedTextBox4.TabIndex = 6;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.Location = new Point(71, 469);
            Button1.Margin = new Padding(4, 4, 4, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(161, 43);
            Button1.TabIndex = 9;
            Button1.Text = "Thêm";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.Location = new Point(445, 469);
            Button3.Margin = new Padding(4, 4, 4, 4);
            Button3.Name = "Button3";
            Button3.Size = new Size(180, 43);
            Button3.TabIndex = 10;
            Button3.Text = "Đóng";
            Button3.UseVisualStyleBackColor = true;
            // 
            // MaskedTextBox5
            // 
            MaskedTextBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox5.Location = new Point(220, 322);
            MaskedTextBox5.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox5.Name = "MaskedTextBox5";
            MaskedTextBox5.Size = new Size(456, 26);
            MaskedTextBox5.TabIndex = 7;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            DateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.Location = new Point(220, 396);
            DateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(265, 26);
            DateTimePicker1.TabIndex = 8;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(17, 132);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(78, 20);
            Label7.TabIndex = 0;
            Label7.Text = "Nhiệm kỳ";
            // 
            // txtPeriod
            // 
            txtPeriod.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeriod.Location = new Point(220, 132);
            txtPeriod.Margin = new Padding(4, 4, 4, 4);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(188, 26);
            txtPeriod.TabIndex = 2;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(17, 174);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(114, 20);
            Label8.TabIndex = 0;
            Label8.Text = "Loại cuộc họp";
            // 
            // txtMettingType
            // 
            txtMettingType.FormattingEnabled = true;
            txtMettingType.Items.AddRange(new object[] { "Thường niên", "Bất thường" });
            txtMettingType.Location = new Point(220, 167);
            txtMettingType.Margin = new Padding(4, 4, 4, 4);
            txtMettingType.Name = "txtMettingType";
            txtMettingType.Size = new Size(160, 24);
            txtMettingType.TabIndex = 4;
            // 
            // stockCode
            // 
            stockCode.Location = new Point(575, 135);
            stockCode.Name = "stockCode";
            stockCode.RightToLeft = RightToLeft.Yes;
            stockCode.Size = new Size(100, 22);
            stockCode.TabIndex = 3;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.Location = new Point(435, 137);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(131, 20);
            Label9.TabIndex = 10;
            Label9.Text = "Mã chứng khoán";
            // 
            // Meeting_ins_update
            // 
            AcceptButton = Button1;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 539);
            Controls.Add(Label9);
            Controls.Add(stockCode);
            Controls.Add(txtMettingType);
            Controls.Add(Button3);
            Controls.Add(Button1);
            Controls.Add(DateTimePicker1);
            Controls.Add(MaskedTextBox5);
            Controls.Add(MaskedTextBox4);
            Controls.Add(MaskedTextBox3);
            Controls.Add(MaskedTextBox2);
            Controls.Add(txtPeriod);
            Controls.Add(MaskedTextBox1);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label8);
            Controls.Add(Label3);
            Controls.Add(Label7);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Meeting_ins_update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mã cuộc họp";
            Load += new EventHandler(Meeting_ins_update_Load);
            KeyUp += new KeyEventHandler(Meeting_ins_update_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal MaskedTextBox MaskedTextBox1;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox4;
        internal Button Button1;
        internal Button Button3;
        internal MaskedTextBox MaskedTextBox5;
        internal DateTimePicker DateTimePicker1;
        internal Label Label7;
        internal MaskedTextBox txtPeriod;
        internal Label Label8;
        internal ComboBox txtMettingType;
        internal TextBox stockCode;
        internal Label Label9;
    }
}