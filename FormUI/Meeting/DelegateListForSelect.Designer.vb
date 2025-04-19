<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelegateListForSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.delegatecode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelegateName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentityCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelegateAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.delegatecode, Me.DelegateName, Me.IdentityCard, Me.DelegateAddress})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(833, 357)
        Me.DataGridView1.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 331)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(833, 26)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(134, 20)
        Me.ToolStripStatusLabel1.Text = "Số lượng bản ghi : "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 20)
        '
        'delegatecode
        '
        Me.delegatecode.DataPropertyName = "delegatecode"
        Me.delegatecode.FillWeight = 59.08628!
        Me.delegatecode.HeaderText = "Mã đại biểu"
        Me.delegatecode.MinimumWidth = 6
        Me.delegatecode.Name = "delegatecode"
        Me.delegatecode.ReadOnly = True
        Me.delegatecode.Width = 125
        '
        'DelegateName
        '
        Me.DelegateName.DataPropertyName = "DelegateName"
        Me.DelegateName.FillWeight = 59.08628!
        Me.DelegateName.HeaderText = "Tên đại biểu"
        Me.DelegateName.MinimumWidth = 6
        Me.DelegateName.Name = "DelegateName"
        Me.DelegateName.ReadOnly = True
        Me.DelegateName.Width = 120
        '
        'IdentityCard
        '
        Me.IdentityCard.DataPropertyName = "IdentityCard"
        Me.IdentityCard.FillWeight = 59.08628!
        Me.IdentityCard.HeaderText = "CCCD/GPKD"
        Me.IdentityCard.MinimumWidth = 6
        Me.IdentityCard.Name = "IdentityCard"
        Me.IdentityCard.ReadOnly = True
        Me.IdentityCard.Width = 94
        '
        'DelegateAddress
        '
        Me.DelegateAddress.DataPropertyName = "DelegateAddress"
        Me.DelegateAddress.FillWeight = 200.0!
        Me.DelegateAddress.HeaderText = "Địa chỉ"
        Me.DelegateAddress.MinimumWidth = 6
        Me.DelegateAddress.Name = "DelegateAddress"
        Me.DelegateAddress.ReadOnly = True
        Me.DelegateAddress.Width = 300
        '
        'DelegateListForSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 357)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DelegateListForSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn đại biểu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents delegatecode As DataGridViewTextBoxColumn
    Friend WithEvents DelegateName As DataGridViewTextBoxColumn
    Friend WithEvents IdentityCard As DataGridViewTextBoxColumn
    Friend WithEvents DelegateAddress As DataGridViewTextBoxColumn
End Class
