using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MatterVotes_ins_remain : Form
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
            MaskedTextBox5 = new MaskedTextBox();
            MaskedTextBox4 = new MaskedTextBox();
            Label5 = new Label();
            MaskedTextBox3 = new MaskedTextBox();
            Label4 = new Label();
            MaskedTextBox2 = new MaskedTextBox();
            Label3 = new Label();
            MaskedTextBox1 = new MaskedTextBox();
            Label2 = new Label();
            Label1 = new Label();
            GroupBox2 = new GroupBox();
            MaskedTextBox8 = new MaskedTextBox();
            Label8 = new Label();
            MaskedTextBox7 = new MaskedTextBox();
            Label7 = new Label();
            MaskedTextBox6 = new MaskedTextBox();
            Label6 = new Label();
            GroupBox3 = new GroupBox();
            RadioButton3 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton1 = new RadioButton();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            rbillegal = new RadioButton();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(MaskedTextBox5);
            GroupBox1.Controls.Add(MaskedTextBox4);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(MaskedTextBox3);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(MaskedTextBox2);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(MaskedTextBox1);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new Point(1, 0);
            GroupBox1.Margin = new Padding(4, 4, 4, 4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 4, 4, 4);
            GroupBox1.Size = new Size(721, 254);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Thông tin vấn đề";
            // 
            // MaskedTextBox5
            // 
            MaskedTextBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox5.Location = new Point(277, 213);
            MaskedTextBox5.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox5.Name = "MaskedTextBox5";
            MaskedTextBox5.ReadOnly = true;
            MaskedTextBox5.Size = new Size(265, 26);
            MaskedTextBox5.TabIndex = 26;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(277, 165);
            MaskedTextBox4.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.ReadOnly = true;
            MaskedTextBox4.Size = new Size(265, 26);
            MaskedTextBox4.TabIndex = 26;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(15, 213);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(128, 20);
            Label5.TabIndex = 27;
            Label5.Text = "Số phiếu còn lại";
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(277, 117);
            MaskedTextBox3.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.ReadOnly = true;
            MaskedTextBox3.Size = new Size(265, 26);
            MaskedTextBox3.TabIndex = 26;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(15, 165);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(138, 20);
            Label4.TabIndex = 27;
            Label4.Text = "Số phiếu đã nhập";
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(277, 65);
            MaskedTextBox2.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.ReadOnly = true;
            MaskedTextBox2.Size = new Size(265, 26);
            MaskedTextBox2.TabIndex = 26;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(15, 117);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(132, 20);
            Label3.TabIndex = 27;
            Label3.Text = "Tổng số đại biểu";
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(277, 20);
            MaskedTextBox1.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(265, 26);
            MaskedTextBox1.TabIndex = 26;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(15, 65);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(91, 20);
            Label2.TabIndex = 27;
            Label2.Text = "Tên vấn đề";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(15, 20);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(86, 20);
            Label1.TabIndex = 27;
            Label1.Text = "Mã vấn đề";
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(MaskedTextBox8);
            GroupBox2.Controls.Add(Label8);
            GroupBox2.Controls.Add(MaskedTextBox7);
            GroupBox2.Controls.Add(Label7);
            GroupBox2.Controls.Add(MaskedTextBox6);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Location = new Point(1, 257);
            GroupBox2.Margin = new Padding(4, 4, 4, 4);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4, 4, 4, 4);
            GroupBox2.Size = new Size(721, 201);
            GroupBox2.TabIndex = 1;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Thông tin về các phiếu đã nhập";
            // 
            // MaskedTextBox8
            // 
            MaskedTextBox8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox8.Location = new Point(277, 139);
            MaskedTextBox8.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox8.Name = "MaskedTextBox8";
            MaskedTextBox8.ReadOnly = true;
            MaskedTextBox8.Size = new Size(265, 26);
            MaskedTextBox8.TabIndex = 26;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(15, 139);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(171, 20);
            Label8.TabIndex = 27;
            Label8.Text = "Số lượng không ý kiến";
            // 
            // MaskedTextBox7
            // 
            MaskedTextBox7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox7.Location = new Point(277, 90);
            MaskedTextBox7.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox7.Name = "MaskedTextBox7";
            MaskedTextBox7.ReadOnly = true;
            MaskedTextBox7.Size = new Size(265, 26);
            MaskedTextBox7.TabIndex = 26;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(15, 90);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(177, 20);
            Label7.TabIndex = 27;
            Label7.Text = "Số lượng không đồng ý";
            // 
            // MaskedTextBox6
            // 
            MaskedTextBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox6.Location = new Point(277, 42);
            MaskedTextBox6.Margin = new Padding(4, 4, 4, 4);
            MaskedTextBox6.Name = "MaskedTextBox6";
            MaskedTextBox6.ReadOnly = true;
            MaskedTextBox6.Size = new Size(265, 26);
            MaskedTextBox6.TabIndex = 26;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(15, 42);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(128, 20);
            Label6.TabIndex = 27;
            Label6.Text = "Số lượng đồng ý";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(rbillegal);
            GroupBox3.Controls.Add(RadioButton3);
            GroupBox3.Controls.Add(RadioButton2);
            GroupBox3.Controls.Add(RadioButton1);
            GroupBox3.Location = new Point(1, 459);
            GroupBox3.Margin = new Padding(4, 4, 4, 4);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(4, 4, 4, 4);
            GroupBox3.Size = new Size(721, 69);
            GroupBox3.TabIndex = 2;
            GroupBox3.TabStop = false;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(328, 25);
            RadioButton3.Margin = new Padding(4, 4, 4, 4);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(111, 21);
            RadioButton3.TabIndex = 7;
            RadioButton3.Text = "Không ý kiến";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(164, 25);
            RadioButton2.Margin = new Padding(4, 4, 4, 4);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(117, 21);
            RadioButton2.TabIndex = 6;
            RadioButton2.Text = "Không đồng ý";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Checked = true;
            RadioButton1.Location = new Point(49, 25);
            RadioButton1.Margin = new Padding(4, 4, 4, 4);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(74, 21);
            RadioButton1.TabIndex = 5;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Đồng ý";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.Location = new Point(411, 562);
            Button3.Margin = new Padding(4, 4, 4, 4);
            Button3.Name = "Button3";
            Button3.Size = new Size(213, 53);
            Button3.TabIndex = 8;
            Button3.Text = "Đóng";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.Red;
            Button1.Location = new Point(51, 562);
            Button1.Margin = new Padding(4, 4, 4, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(189, 53);
            Button1.TabIndex = 7;
            Button1.Text = "Nhập phần còn lại";
            Button1.UseVisualStyleBackColor = true;
            // 
            // rbillegal
            // 
            rbillegal.AutoSize = true;
            rbillegal.Location = new Point(484, 25);
            rbillegal.Margin = new Padding(4);
            rbillegal.Name = "rbillegal";
            rbillegal.Size = new Size(113, 21);
            rbillegal.TabIndex = 7;
            rbillegal.Text = "Không hợp lệ";
            rbillegal.UseVisualStyleBackColor = true;
            // 
            // MatterVotes_ins_remain
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 660);
            Controls.Add(Button3);
            Controls.Add(Button1);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MatterVotes_ins_remain";
            Text = "Nhập TẤT CẢ phiếu biểu quyết CÒN LẠI";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            Load += new EventHandler(MatterVotes_ins_remain_Load);
            ResumeLayout(false);

        }
        internal GroupBox GroupBox1;
        internal MaskedTextBox MaskedTextBox5;
        internal MaskedTextBox MaskedTextBox4;
        internal Label Label5;
        internal MaskedTextBox MaskedTextBox3;
        internal Label Label4;
        internal MaskedTextBox MaskedTextBox2;
        internal Label Label3;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label2;
        internal Label Label1;
        internal GroupBox GroupBox2;
        internal MaskedTextBox MaskedTextBox8;
        internal Label Label8;
        internal MaskedTextBox MaskedTextBox7;
        internal Label Label7;
        internal MaskedTextBox MaskedTextBox6;
        internal Label Label6;
        internal GroupBox GroupBox3;
        internal Button Button3;
        internal Button Button1;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
        internal RadioButton rbillegal;
    }
}