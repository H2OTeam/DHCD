using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Holder_ins_update : Form
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
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            MaskedTextBox5 = new MaskedTextBox();
            MaskedTextBox4 = new MaskedTextBox();
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox2 = new MaskedTextBox();
            MaskedTextBox1 = new MaskedTextBox();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            Label7 = new Label();
            StockTextBox1 = new Lapas.Controls.StockTextBox();
            StockTextBox2 = new Lapas.Controls.StockTextBox();
            Label8 = new Label();
            identityDate = new DateTimePicker();
            SuspendLayout();
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.Location = new Point(472, 450);
            Button3.Margin = new Padding(4, 4, 4, 4);
            Button3.Name = "Button3";
            Button3.Size = new Size(180, 43);
            Button3.TabIndex = 7;
            Button3.Text = "Đóng";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.Location = new Point(98, 450);
            Button1.Margin = new Padding(4, 4, 4, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(161, 43);
            Button1.TabIndex = 6;
            Button1.Text = "Thêm";
            Button1.UseVisualStyleBackColor = true;
            // 
            // MaskedTextBox5
            // 
            MaskedTextBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox5.Location = new Point(247, 249);
            MaskedTextBox5.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox5.Name = "MaskedTextBox5";
            MaskedTextBox5.Size = new Size(456, 26);
            MaskedTextBox5.TabIndex = 3;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(247, 203);
            MaskedTextBox4.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.Size = new Size(456, 26);
            MaskedTextBox4.TabIndex = 2;
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(248, 123);
            MaskedTextBox3.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.Size = new Size(265, 26);
            MaskedTextBox3.TabIndex = 1;
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(248, 70);
            MaskedTextBox2.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.Size = new Size(265, 26);
            MaskedTextBox2.TabIndex = 0;
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(248, 27);
            MaskedTextBox1.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(265, 26);
            MaskedTextBox1.TabIndex = 10;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(43, 363);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(159, 20);
            Label6.TabIndex = 9;
            Label6.Text = "Số quyền biểu quyết";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(44, 311);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(93, 20);
            Label5.TabIndex = 8;
            Label5.Text = "Số cổ phần";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(44, 257);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(61, 20);
            Label4.TabIndex = 11;
            Label4.Text = "Địa chỉ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(43, 203);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(101, 20);
            Label3.TabIndex = 14;
            Label3.Text = "Tên cổ đông";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(45, 78);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(96, 20);
            Label2.TabIndex = 13;
            Label2.Text = "Mã cổ đông";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(45, 27);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 20);
            Label1.TabIndex = 12;
            Label1.Text = "Mã cuộc họp";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(45, 123);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(141, 20);
            Label7.TabIndex = 13;
            Label7.Text = "CCCD/HC/GPKD";
            // 
            // StockTextBox1
            // 
            StockTextBox1.Alarm = false;
            StockTextBox1.AllowNegativeNumeric = true;
            StockTextBox1.CustomCulture = false;
            StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox1.Location = new Point(247, 311);
            StockTextBox1.Margin = new Padding(4, 4, 4, 4);
            StockTextBox1.MaxLength = 25;
            StockTextBox1.Name = "StockTextBox1";
            StockTextBox1.Precision = 0;
            StockTextBox1.Size = new Size(265, 22);
            StockTextBox1.TabIndex = 4;
            StockTextBox1.Text = "0";
            StockTextBox1.TextAlign = HorizontalAlignment.Right;
            StockTextBox1.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // StockTextBox2
            // 
            StockTextBox2.Alarm = false;
            StockTextBox2.AllowNegativeNumeric = true;
            StockTextBox2.CustomCulture = false;
            StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox2.Location = new Point(247, 358);
            StockTextBox2.Margin = new Padding(4, 4, 4, 4);
            StockTextBox2.MaxLength = 25;
            StockTextBox2.Name = "StockTextBox2";
            StockTextBox2.Precision = 0;
            StockTextBox2.Size = new Size(265, 22);
            StockTextBox2.TabIndex = 5;
            StockTextBox2.Text = "0";
            StockTextBox2.TextAlign = HorizontalAlignment.Right;
            StockTextBox2.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(45, 162);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(79, 20);
            Label8.TabIndex = 16;
            Label8.Text = "Ngày cấp";
            // 
            // identityDate
            // 
            identityDate.Format = DateTimePickerFormat.Short;
            identityDate.Location = new Point(248, 162);
            identityDate.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            identityDate.Name = "identityDate";
            identityDate.Size = new Size(200, 22);
            identityDate.TabIndex = 17;
            // 
            // Holder_ins_update
            // 
            AcceptButton = Button1;
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 532);
            Controls.Add(identityDate);
            Controls.Add(Label8);
            Controls.Add(StockTextBox2);
            Controls.Add(StockTextBox1);
            Controls.Add(Button3);
            Controls.Add(Button1);
            Controls.Add(MaskedTextBox5);
            Controls.Add(MaskedTextBox4);
            Controls.Add(MaskedTextBox3);
            Controls.Add(MaskedTextBox2);
            Controls.Add(MaskedTextBox1);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label7);
            Controls.Add(Label2);
            Controls.Add(Label1);
            KeyPreview = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Holder_ins_update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mã cổ đông";
            Load += new EventHandler(Holder_ins_update_Load);
            KeyUp += new KeyEventHandler(Holder_ins_update_KeyUp);
            ResumeLayout(false);
            PerformLayout();

        }
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
        internal Label Label2;
        internal Label Label1;
        internal Label Label7;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Label Label8;
        internal DateTimePicker identityDate;
    }
}