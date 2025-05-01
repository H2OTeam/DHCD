using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class sodbhl : Form
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
            MaskedTextBox3 = new MaskedTextBox();
            Label7 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label8 = new Label();
            MaskedTextBox1 = new MaskedTextBox();
            MaskedTextBox2 = new MaskedTextBox();
            MaskedTextBox4 = new MaskedTextBox();
            MaskedTextBox5 = new MaskedTextBox();
            MaskedTextBox6 = new MaskedTextBox();
            MaskedTextBox7 = new MaskedTextBox();
            MaskedTextBox8 = new MaskedTextBox();
            MaskedTextBox9 = new MaskedTextBox();
            MaskedTextBox10 = new MaskedTextBox();
            GroupBox2 = new GroupBox();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            GroupBox3 = new GroupBox();
            Label9 = new Label();
            Label10 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Label13 = new Label();
            textsodbhl = new MaskedTextBox();
            sodbkhl = new MaskedTextBox();
            tongqbqhl = new MaskedTextBox();
            tongqbqkhl = new MaskedTextBox();
            tylebqhl = new MaskedTextBox();
            tylebqkhl = new MaskedTextBox();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(NumericUpDown1);
            GroupBox1.Controls.Add(MaskedTextBox3);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(63, 23);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(1056, 117);
            GroupBox1.TabIndex = 58;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Vấn đề biểu quyết";
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumericUpDown1.Location = new Point(217, 16);
            NumericUpDown1.Margin = new Padding(4);
            NumericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(81, 34);
            NumericUpDown1.TabIndex = 0;
            NumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.BackColor = Color.LightYellow;
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(217, 64);
            MaskedTextBox3.Margin = new Padding(4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.ReadOnly = true;
            MaskedTextBox3.Size = new Size(812, 34);
            MaskedTextBox3.TabIndex = 23;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(15, 64);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(111, 25);
            Label7.TabIndex = 27;
            Label7.Text = "Tên vấn đề";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(15, 22);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(104, 25);
            Label2.TabIndex = 26;
            Label2.Text = "Mã vấn đề";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.AppWorkspace;
            Label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(129, 464);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(135, 29);
            Label1.TabIndex = 27;
            Label1.Text = "Số đại biểu";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = SystemColors.AppWorkspace;
            Label3.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(397, 402);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(88, 29);
            Label3.TabIndex = 27;
            Label3.Text = "Đồng ý";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = SystemColors.AppWorkspace;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(669, 402);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(161, 29);
            Label4.TabIndex = 27;
            Label4.Text = "Không đồng ý";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = SystemColors.AppWorkspace;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(957, 402);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(151, 29);
            Label5.TabIndex = 27;
            Label5.Text = "Không ý kiến";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = SystemColors.AppWorkspace;
            Label6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(129, 539);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(155, 29);
            Label6.TabIndex = 27;
            Label6.Text = "Số quyền BQ";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = SystemColors.AppWorkspace;
            Label8.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(129, 616);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(66, 29);
            Label8.TabIndex = 27;
            Label8.Text = "Tỷ lệ";
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.BackColor = Color.LightYellow;
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(355, 461);
            MaskedTextBox1.Margin = new Padding(4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(189, 34);
            MaskedTextBox1.TabIndex = 59;
            MaskedTextBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.BackColor = Color.LightYellow;
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(653, 463);
            MaskedTextBox2.Margin = new Padding(4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.ReadOnly = true;
            MaskedTextBox2.Size = new Size(189, 34);
            MaskedTextBox2.TabIndex = 59;
            MaskedTextBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.BackColor = Color.LightYellow;
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(943, 463);
            MaskedTextBox4.Margin = new Padding(4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.ReadOnly = true;
            MaskedTextBox4.Size = new Size(189, 34);
            MaskedTextBox4.TabIndex = 59;
            MaskedTextBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox5
            // 
            MaskedTextBox5.BackColor = Color.LightYellow;
            MaskedTextBox5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox5.Location = new Point(355, 532);
            MaskedTextBox5.Margin = new Padding(4);
            MaskedTextBox5.Name = "MaskedTextBox5";
            MaskedTextBox5.ReadOnly = true;
            MaskedTextBox5.Size = new Size(189, 34);
            MaskedTextBox5.TabIndex = 59;
            MaskedTextBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox6
            // 
            MaskedTextBox6.BackColor = Color.LightYellow;
            MaskedTextBox6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox6.Location = new Point(653, 535);
            MaskedTextBox6.Margin = new Padding(4);
            MaskedTextBox6.Name = "MaskedTextBox6";
            MaskedTextBox6.ReadOnly = true;
            MaskedTextBox6.Size = new Size(189, 34);
            MaskedTextBox6.TabIndex = 59;
            MaskedTextBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox7
            // 
            MaskedTextBox7.BackColor = Color.LightYellow;
            MaskedTextBox7.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox7.Location = new Point(943, 535);
            MaskedTextBox7.Margin = new Padding(4);
            MaskedTextBox7.Name = "MaskedTextBox7";
            MaskedTextBox7.ReadOnly = true;
            MaskedTextBox7.Size = new Size(189, 34);
            MaskedTextBox7.TabIndex = 59;
            MaskedTextBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox8
            // 
            MaskedTextBox8.BackColor = Color.LightYellow;
            MaskedTextBox8.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox8.Location = new Point(355, 610);
            MaskedTextBox8.Margin = new Padding(4);
            MaskedTextBox8.Name = "MaskedTextBox8";
            MaskedTextBox8.ReadOnly = true;
            MaskedTextBox8.Size = new Size(189, 34);
            MaskedTextBox8.TabIndex = 59;
            MaskedTextBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox9
            // 
            MaskedTextBox9.BackColor = Color.LightYellow;
            MaskedTextBox9.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox9.Location = new Point(653, 613);
            MaskedTextBox9.Margin = new Padding(4);
            MaskedTextBox9.Name = "MaskedTextBox9";
            MaskedTextBox9.ReadOnly = true;
            MaskedTextBox9.Size = new Size(189, 34);
            MaskedTextBox9.TabIndex = 59;
            MaskedTextBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // MaskedTextBox10
            // 
            MaskedTextBox10.BackColor = Color.LightYellow;
            MaskedTextBox10.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox10.Location = new Point(943, 613);
            MaskedTextBox10.Margin = new Padding(4);
            MaskedTextBox10.Name = "MaskedTextBox10";
            MaskedTextBox10.ReadOnly = true;
            MaskedTextBox10.Size = new Size(189, 34);
            MaskedTextBox10.TabIndex = 59;
            MaskedTextBox10.TextAlign = HorizontalAlignment.Right;
            // 
            // GroupBox2
            // 
            GroupBox2.BackColor = SystemColors.ActiveCaption;
            GroupBox2.Controls.Add(tongqbqkhl);
            GroupBox2.Controls.Add(tylebqkhl);
            GroupBox2.Controls.Add(sodbkhl);
            GroupBox2.Controls.Add(tylebqhl);
            GroupBox2.Controls.Add(tongqbqhl);
            GroupBox2.Controls.Add(textsodbhl);
            GroupBox2.Controls.Add(Label12);
            GroupBox2.Controls.Add(Label11);
            GroupBox2.Controls.Add(Label10);
            GroupBox2.Controls.Add(Label13);
            GroupBox2.Controls.Add(Label9);
            GroupBox2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox2.Location = new Point(63, 170);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(1154, 156);
            GroupBox2.TabIndex = 60;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Kết quả chung";
            // 
            // GroupBox3
            // 
            GroupBox3.BackColor = SystemColors.AppWorkspace;
            GroupBox3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox3.Location = new Point(63, 379);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(1154, 289);
            GroupBox3.TabIndex = 61;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Chi tiết biểu quyết hợp lệ";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.Location = new Point(7, 71);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(199, 29);
            Label9.TabIndex = 62;
            Label9.Text = "Biểu quyết hợp lệ";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.Location = new Point(315, 30);
            Label10.Margin = new Padding(4, 0, 4, 0);
            Label10.Name = "Label10";
            Label10.Size = new Size(135, 29);
            Label10.TabIndex = 62;
            Label10.Text = "Số đại biểu";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.Location = new Point(610, 30);
            Label11.Margin = new Padding(4, 0, 4, 0);
            Label11.Name = "Label11";
            Label11.Size = new Size(173, 29);
            Label11.TabIndex = 62;
            Label11.Text = "Tổng số quyền";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label12.Location = new Point(963, 30);
            Label12.Margin = new Padding(4, 0, 4, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(66, 29);
            Label12.TabIndex = 62;
            Label12.Text = "Tỷ lệ";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label13.Location = new Point(7, 112);
            Label13.Margin = new Padding(4, 0, 4, 0);
            Label13.Name = "Label13";
            Label13.Size = new Size(271, 29);
            Label13.TabIndex = 62;
            Label13.Text = "Biểu quyết không hợp lệ";
            // 
            // textsodbhl
            // 
            textsodbhl.BackColor = Color.LightYellow;
            textsodbhl.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsodbhl.Location = new Point(317, 63);
            textsodbhl.Margin = new Padding(4);
            textsodbhl.Name = "textsodbhl";
            textsodbhl.ReadOnly = true;
            textsodbhl.Size = new Size(130, 34);
            textsodbhl.TabIndex = 62;
            textsodbhl.TextAlign = HorizontalAlignment.Right;
            // 
            // sodbkhl
            // 
            sodbkhl.BackColor = Color.LightYellow;
            sodbkhl.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            sodbkhl.Location = new Point(317, 105);
            sodbkhl.Margin = new Padding(4);
            sodbkhl.Name = "sodbkhl";
            sodbkhl.ReadOnly = true;
            sodbkhl.Size = new Size(130, 34);
            sodbkhl.TabIndex = 62;
            sodbkhl.TextAlign = HorizontalAlignment.Right;
            // 
            // tongqbqhl
            // 
            tongqbqhl.BackColor = Color.LightYellow;
            tongqbqhl.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tongqbqhl.Location = new Point(601, 63);
            tongqbqhl.Margin = new Padding(4);
            tongqbqhl.Name = "tongqbqhl";
            tongqbqhl.ReadOnly = true;
            tongqbqhl.Size = new Size(190, 34);
            tongqbqhl.TabIndex = 62;
            tongqbqhl.TextAlign = HorizontalAlignment.Right;
            // 
            // tongqbqkhl
            // 
            tongqbqkhl.BackColor = Color.LightYellow;
            tongqbqkhl.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tongqbqkhl.Location = new Point(601, 105);
            tongqbqkhl.Margin = new Padding(4);
            tongqbqkhl.Name = "tongqbqkhl";
            tongqbqkhl.ReadOnly = true;
            tongqbqkhl.Size = new Size(190, 34);
            tongqbqkhl.TabIndex = 62;
            tongqbqkhl.TextAlign = HorizontalAlignment.Right;
            // 
            // tylebqhl
            // 
            tylebqhl.BackColor = Color.LightYellow;
            tylebqhl.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tylebqhl.Location = new Point(939, 63);
            tylebqhl.Margin = new Padding(4);
            tylebqhl.Name = "tylebqhl";
            tylebqhl.ReadOnly = true;
            tylebqhl.Size = new Size(130, 34);
            tylebqhl.TabIndex = 62;
            tylebqhl.TextAlign = HorizontalAlignment.Right;
            // 
            // tylebqkhl
            // 
            tylebqkhl.BackColor = Color.LightYellow;
            tylebqkhl.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            tylebqkhl.Location = new Point(939, 105);
            tylebqkhl.Margin = new Padding(4);
            tylebqkhl.Name = "tylebqkhl";
            tylebqkhl.ReadOnly = true;
            tylebqkhl.Size = new Size(130, 34);
            tylebqkhl.TabIndex = 62;
            tylebqkhl.TextAlign = HorizontalAlignment.Right;
            // 
            // sodbhl
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 745);
            Controls.Add(GroupBox2);
            Controls.Add(MaskedTextBox10);
            Controls.Add(MaskedTextBox9);
            Controls.Add(MaskedTextBox7);
            Controls.Add(MaskedTextBox6);
            Controls.Add(MaskedTextBox8);
            Controls.Add(MaskedTextBox4);
            Controls.Add(MaskedTextBox5);
            Controls.Add(MaskedTextBox2);
            Controls.Add(MaskedTextBox1);
            Controls.Add(GroupBox1);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label8);
            Controls.Add(Label6);
            Controls.Add(Label1);
            Controls.Add(GroupBox3);
            Margin = new Padding(4);
            Name = "sodbhl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết quả biểu quyết";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Load += new EventHandler(MatterVoteResult_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label8;
        internal MaskedTextBox MaskedTextBox1;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox5;
        internal MaskedTextBox MaskedTextBox6;
        internal MaskedTextBox MaskedTextBox7;
        internal MaskedTextBox MaskedTextBox8;
        internal MaskedTextBox MaskedTextBox9;
        internal MaskedTextBox MaskedTextBox10;
        internal GroupBox GroupBox2;
        internal MaskedTextBox tongqbqkhl;
        internal MaskedTextBox tylebqkhl;
        internal MaskedTextBox sodbkhl;
        internal MaskedTextBox tylebqhl;
        internal MaskedTextBox tongqbqhl;
        internal MaskedTextBox textsodbhl;
        internal Label Label12;
        internal Label Label11;
        internal Label Label10;
        internal Label Label13;
        internal Label Label9;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal GroupBox GroupBox3;
    }
}