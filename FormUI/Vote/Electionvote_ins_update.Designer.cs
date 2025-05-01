using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Electionvote_ins_update : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            GroupBox1 = new GroupBox();
            NumericUpDown1 = new NumericUpDown();
            NumericUpDown1.ValueChanged += new EventHandler(NumericUpDown1_ValueChanged);
            MaskedTextBox6 = new MaskedTextBox();
            MaskedTextBox3 = new MaskedTextBox();
            MaskedTextBox1 = new MaskedTextBox();
            Label8 = new Label();
            Label7 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            GroupBox2 = new GroupBox();
            StockTextBox2 = new Lapas.Controls.StockTextBox();
            StockTextBox1 = new Lapas.Controls.StockTextBox();
            MaskedTextBox4 = new MaskedTextBox();
            MaskedTextBox2 = new MaskedTextBox();
            MaskedTextBox2.Leave += new EventHandler(MaskedTextBox2_Leave);
            MaskedTextBox5 = new MaskedTextBox();
            MaskedTextBox5.Leave += new EventHandler(MaskedTextBox5_Leave);
            MaskedTextBox5.KeyDown += new KeyEventHandler(MaskedTextBox5_KeyDown);
            Label9 = new Label();
            Label6 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            GroupBox3 = new GroupBox();
            DataGridView1 = new DataGridView();
            Candidatecode = new DataGridViewTextBoxColumn();
            CandidateName = new DataGridViewTextBoxColumn();
            Choosen = new DataGridViewCheckBoxColumn();
            Votes = new DataGridViewTextBoxColumn();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            GroupBox4 = new GroupBox();
            RadioButton2 = new RadioButton();
            RadioButton2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);
            RadioButton1 = new RadioButton();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            GroupBox2.SuspendLayout();
            GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            GroupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(NumericUpDown1);
            GroupBox1.Controls.Add(MaskedTextBox6);
            GroupBox1.Controls.Add(MaskedTextBox3);
            GroupBox1.Controls.Add(MaskedTextBox1);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new Point(1, 2);
            GroupBox1.Margin = new Padding(4);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4);
            GroupBox1.Size = new Size(932, 198);
            GroupBox1.TabIndex = 56;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Vấn đề bầu cử";
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            NumericUpDown1.Location = new Point(217, 58);
            NumericUpDown1.Margin = new Padding(4);
            NumericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(81, 29);
            NumericUpDown1.TabIndex = 0;
            NumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaskedTextBox6
            // 
            MaskedTextBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox6.Location = new Point(217, 154);
            MaskedTextBox6.Margin = new Padding(4);
            MaskedTextBox6.Name = "MaskedTextBox6";
            MaskedTextBox6.ReadOnly = true;
            MaskedTextBox6.Size = new Size(265, 26);
            MaskedTextBox6.TabIndex = 23;
            // 
            // MaskedTextBox3
            // 
            MaskedTextBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox3.Location = new Point(217, 110);
            MaskedTextBox3.Margin = new Padding(4);
            MaskedTextBox3.Name = "MaskedTextBox3";
            MaskedTextBox3.ReadOnly = true;
            MaskedTextBox3.Size = new Size(635, 26);
            MaskedTextBox3.TabIndex = 23;
            // 
            // MaskedTextBox1
            // 
            MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox1.Location = new Point(217, 22);
            MaskedTextBox1.Margin = new Padding(4);
            MaskedTextBox1.Name = "MaskedTextBox1";
            MaskedTextBox1.ReadOnly = true;
            MaskedTextBox1.Size = new Size(635, 26);
            MaskedTextBox1.TabIndex = 24;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.Location = new Point(13, 161);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(169, 20);
            Label8.TabIndex = 27;
            Label8.Text = "Số ứng viên được bầu";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.Location = new Point(15, 110);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(92, 20);
            Label7.TabIndex = 27;
            Label7.Text = "Tên bầu cử";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(15, 68);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(87, 20);
            Label2.TabIndex = 26;
            Label2.Text = "Mã bầu cử";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(15, 22);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 20);
            Label1.TabIndex = 25;
            Label1.Text = "Mã cuộc họp";
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(StockTextBox2);
            GroupBox2.Controls.Add(StockTextBox1);
            GroupBox2.Controls.Add(MaskedTextBox4);
            GroupBox2.Controls.Add(MaskedTextBox2);
            GroupBox2.Controls.Add(MaskedTextBox5);
            GroupBox2.Controls.Add(Label9);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Controls.Add(Label3);
            GroupBox2.Controls.Add(Label4);
            GroupBox2.Controls.Add(Label5);
            GroupBox2.Location = new Point(1, 202);
            GroupBox2.Margin = new Padding(4);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Padding = new Padding(4);
            GroupBox2.Size = new Size(687, 238);
            GroupBox2.TabIndex = 57;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Đại biểu";
            // 
            // StockTextBox2
            // 
            StockTextBox2.Alarm = false;
            StockTextBox2.AllowNegativeNumeric = true;
            StockTextBox2.CustomCulture = false;
            StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-US");
            StockTextBox2.Location = new Point(217, 198);
            StockTextBox2.Margin = new Padding(4);
            StockTextBox2.MaxLength = 25;
            StockTextBox2.Name = "StockTextBox2";
            StockTextBox2.Precision = 0;
            StockTextBox2.ReadOnly = true;
            StockTextBox2.Size = new Size(265, 22);
            StockTextBox2.TabIndex = 38;
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
            StockTextBox1.Location = new Point(217, 154);
            StockTextBox1.Margin = new Padding(4);
            StockTextBox1.MaxLength = 25;
            StockTextBox1.Name = "StockTextBox1";
            StockTextBox1.Precision = 0;
            StockTextBox1.ReadOnly = true;
            StockTextBox1.Size = new Size(265, 22);
            StockTextBox1.TabIndex = 38;
            StockTextBox1.Text = "0";
            StockTextBox1.TextAlign = HorizontalAlignment.Right;
            StockTextBox1.ValueAlarm = new decimal(new int[] { 1000000000, 0, 0, 0 });
            // 
            // MaskedTextBox4
            // 
            MaskedTextBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox4.Location = new Point(217, 110);
            MaskedTextBox4.Margin = new Padding(4);
            MaskedTextBox4.Name = "MaskedTextBox4";
            MaskedTextBox4.ReadOnly = true;
            MaskedTextBox4.Size = new Size(265, 26);
            MaskedTextBox4.TabIndex = 32;
            // 
            // MaskedTextBox2
            // 
            MaskedTextBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox2.Location = new Point(217, 64);
            MaskedTextBox2.Margin = new Padding(4);
            MaskedTextBox2.Name = "MaskedTextBox2";
            MaskedTextBox2.Size = new Size(265, 26);
            MaskedTextBox2.TabIndex = 2;
            // 
            // MaskedTextBox5
            // 
            MaskedTextBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTextBox5.Location = new Point(217, 16);
            MaskedTextBox5.Margin = new Padding(4);
            MaskedTextBox5.Name = "MaskedTextBox5";
            MaskedTextBox5.Size = new Size(265, 26);
            MaskedTextBox5.TabIndex = 1;
            MaskedTextBox5.TabStop = false;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.Location = new Point(15, 198);
            Label9.Margin = new Padding(4, 0, 4, 0);
            Label9.Name = "Label9";
            Label9.Size = new Size(106, 20);
            Label9.TabIndex = 36;
            Label9.Text = "Số phiếu bầu";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.Location = new Point(15, 159);
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
            Label3.Location = new Point(13, 110);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 20);
            Label3.TabIndex = 36;
            Label3.Text = "Tên đại biểu";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(15, 64);
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
            Label5.Location = new Point(15, 23);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(95, 20);
            Label5.TabIndex = 34;
            Label5.Text = "Mã đại biểu";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(DataGridView1);
            GroupBox3.Location = new Point(1, 447);
            GroupBox3.Margin = new Padding(4);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(4);
            GroupBox3.Size = new Size(932, 287);
            GroupBox3.TabIndex = 58;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Bầu chọn";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Candidatecode, CandidateName, Choosen, Votes });
            DataGridView1.Dock = DockStyle.Fill;
            DataGridView1.Location = new Point(4, 19);
            DataGridView1.Margin = new Padding(4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(924, 264);
            DataGridView1.TabIndex = 13;
            // 
            // Candidatecode
            // 
            Candidatecode.DataPropertyName = "Candidatecode";
            Candidatecode.FillWeight = 59.08628f;
            Candidatecode.HeaderText = "Mã ứng viên";
            Candidatecode.MinimumWidth = 6;
            Candidatecode.Name = "Candidatecode";
            Candidatecode.ReadOnly = true;
            // 
            // CandidateName
            // 
            CandidateName.DataPropertyName = "CandidateName";
            CandidateName.FillWeight = 59.08628f;
            CandidateName.HeaderText = "Tên ứng viên";
            CandidateName.MinimumWidth = 6;
            CandidateName.Name = "CandidateName";
            CandidateName.ReadOnly = true;
            // 
            // Choosen
            // 
            Choosen.DataPropertyName = "Choosen";
            Choosen.FillWeight = 59.08628f;
            Choosen.HeaderText = "Chọn";
            Choosen.MinimumWidth = 6;
            Choosen.Name = "Choosen";
            Choosen.Resizable = DataGridViewTriState.True;
            Choosen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Votes
            // 
            Votes.DataPropertyName = "Votes";
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Votes.DefaultCellStyle = DataGridViewCellStyle4;
            Votes.HeaderText = "Số phiếu bầu";
            Votes.MinimumWidth = 6;
            Votes.Name = "Votes";
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.Location = new Point(571, 738);
            Button2.Margin = new Padding(4);
            Button2.Name = "Button2";
            Button2.Size = new Size(168, 43);
            Button2.TabIndex = 60;
            Button2.Text = "Tiếp tục";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.Location = new Point(776, 738);
            Button3.Margin = new Padding(4);
            Button3.Name = "Button3";
            Button3.Size = new Size(153, 43);
            Button3.TabIndex = 61;
            Button3.Text = "Đóng";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.Location = new Point(5, 738);
            Button1.Margin = new Padding(4);
            Button1.Name = "Button1";
            Button1.Size = new Size(152, 43);
            Button1.TabIndex = 59;
            Button1.Text = "Thêm";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button4.Location = new Point(179, 738);
            Button4.Margin = new Padding(4);
            Button4.Name = "Button4";
            Button4.Size = new Size(160, 43);
            Button4.TabIndex = 3;
            Button4.Text = "Chia đều phiếu";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button5.Location = new Point(363, 738);
            Button5.Margin = new Padding(4);
            Button5.Name = "Button5";
            Button5.Size = new Size(168, 43);
            Button5.TabIndex = 60;
            Button5.Text = "Để trống phiếu";
            Button5.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            GroupBox4.Controls.Add(RadioButton2);
            GroupBox4.Controls.Add(RadioButton1);
            GroupBox4.Location = new Point(696, 202);
            GroupBox4.Margin = new Padding(4);
            GroupBox4.Name = "GroupBox4";
            GroupBox4.Padding = new Padding(4);
            GroupBox4.Size = new Size(233, 238);
            GroupBox4.TabIndex = 39;
            GroupBox4.TabStop = false;
            GroupBox4.Text = "TRẠNG THÁI PHIẾU";
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(39, 132);
            RadioButton2.Margin = new Padding(4);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(123, 21);
            RadioButton2.TabIndex = 0;
            RadioButton2.Text = "KHÔNG hợp lệ";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Checked = true;
            RadioButton1.Location = new Point(39, 43);
            RadioButton1.Margin = new Padding(4);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(70, 21);
            RadioButton1.TabIndex = 0;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Hợp lệ";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Electionvote_ins_update
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 796);
            Controls.Add(GroupBox4);
            Controls.Add(Button4);
            Controls.Add(Button5);
            Controls.Add(Button2);
            Controls.Add(Button3);
            Controls.Add(Button1);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Margin = new Padding(4);
            Name = "Electionvote_ins_update";
            Text = "Thêm phiếu bầu cử";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            GroupBox4.ResumeLayout(false);
            GroupBox4.PerformLayout();
            Load += new EventHandler(Electionvote_ins_update_Load);
            ResumeLayout(false);

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal GroupBox GroupBox2;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox5;
        internal Label Label6;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal GroupBox GroupBox3;
        internal DataGridView DataGridView1;
        internal Button Button2;
        internal Button Button3;
        internal Button Button1;
        internal Button Button4;
        internal MaskedTextBox MaskedTextBox6;
        internal Label Label8;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Label Label9;
        internal DataGridViewTextBoxColumn Candidatecode;
        internal DataGridViewTextBoxColumn CandidateName;
        internal DataGridViewCheckBoxColumn Choosen;
        internal DataGridViewTextBoxColumn Votes;
        internal Button Button5;
        internal GroupBox GroupBox4;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
    }
}