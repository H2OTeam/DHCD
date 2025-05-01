using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PrintHolders : Form
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
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new TableLayoutPanel();
            OK_Button = new Button();
            OK_Button.Click += new EventHandler(OK_Button_Click);
            Cancel_Button = new Button();
            Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
            txtFromHolder = new TextBox();
            txtToHolder = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            ErrorProvider1 = new ErrorProvider(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 0, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0);
            TableLayoutPanel1.Location = new Point(173, 90);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.None;
            OK_Button.Location = new Point(3, 3);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(67, 23);
            OK_Button.TabIndex = 0;
            OK_Button.Text = "OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = AnchorStyles.None;
            Cancel_Button.DialogResult = DialogResult.Cancel;
            Cancel_Button.Location = new Point(76, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(67, 23);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            // 
            // txtFromHolder
            // 
            txtFromHolder.Location = new Point(41, 34);
            txtFromHolder.Name = "txtFromHolder";
            txtFromHolder.Size = new Size(100, 20);
            txtFromHolder.TabIndex = 1;
            txtFromHolder.Text = "0";
            // 
            // txtToHolder
            // 
            txtToHolder.Location = new Point(196, 34);
            txtToHolder.Name = "txtToHolder";
            txtToHolder.Size = new Size(100, 20);
            txtToHolder.TabIndex = 2;
            txtToHolder.Text = "1";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(38, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(80, 13);
            Label1.TabIndex = 3;
            Label1.Text = "Từ mã cổ đông";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(189, 18);
            Label2.Name = "Label2";
            Label2.Size = new Size(82, 13);
            Label2.TabIndex = 4;
            Label2.Text = "Tới mã cổ đông";
            // 
            // ErrorProvider1
            // 
            ErrorProvider1.ContainerControl = this;
            // 
            // PrintHolders
            // 
            AcceptButton = OK_Button;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel_Button;
            ClientSize = new Size(331, 131);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(txtToHolder);
            Controls.Add(txtFromHolder);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrintHolders";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "In thẻ biểu quyết";
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal TextBox txtFromHolder;
        internal TextBox txtToHolder;
        internal Label Label1;
        internal Label Label2;
        internal ErrorProvider ErrorProvider1;

    }
}